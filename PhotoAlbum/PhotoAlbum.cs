using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinformTutorials.SideForms;

namespace TUTORIALS.Library
{
    public class PhotoAlbum : CollectionBase, IDisposable
    {
        private string _title;
        private string _password;
        private DisplayValEnum _displayOption = DisplayValEnum.Caption;

        public bool IsChanged { get; private set; }
        private int _currentPos;
        public int CurrentPosition
        {
            get { return _currentPos; }
            set
            {
                if (value < 0)
                {
                    _currentPos = 0;
                }
                else if (value>=Count)
                {
                    _currentPos = Count - 1;
                }
                else
                {
                    _currentPos = value;
                }
            }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                SetAlbumChanged();
            }
        }

        public void ResetAlbumChanged()
        {
            IsChanged = false;
        }

        public void SetAlbumChanged()
        {
            IsChanged = true;
        }

        protected override void OnClear()
        {
            _currentPos = 0;
            _fileName = null;
            _title = null;
            _password = null;
            _displayOption = DisplayValEnum.Caption;
            SetAlbumChanged();
            Dispose();
            base.OnClear();
        }

        protected override void OnRemoveComplete(int index, object value)
        {
            CurrentPosition = _currentPos;
            SetAlbumChanged();
            base.OnRemoveComplete(index, value);
        }

        public Photograph CurrentPhoto
        {
            get
            {
                if (Count == 0)
                    return null;

                return List[CurrentPosition] as Photograph;
            }
        }

        public bool CurrentNext()
        {
            if(CurrentPosition+1<Count)
            {
                CurrentPosition++;
                return true;
            }
            return false;
        }

        public bool CurrentPrev()
        {
            if(CurrentPosition>0)
            {
                CurrentPosition--;
                return true;
            }
            return false;
        }

        private bool _disposing;
        private static string _defaultDir;
        private static bool _initializeDir;

        public void Dispose()
        {
            if(!_disposing)
            {
                _disposing = true;
                foreach (Photograph photograph in List)
                {
                    photograph.Dispose();
                }
                Clear();
            }
        }

        public virtual int IndexOf(Photograph p)
        {
            return List.IndexOf(p);
        }

        public virtual int Add(Photograph p)
        {
            SetAlbumChanged();
            return List.Add(p);
        }

        //private const int CurrentVersion = 66;   Chapter 6.6
        //private const int CurrentVersion = 83;
        //private const int CurrentVersion = 92;
        private const int CurrentVersion = 93;
        public void Save(string fileName)
        {
            var fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            var sw = new StreamWriter(fs);
            try
            {
                sw.WriteLine(CurrentVersion.ToString());
                sw.WriteLine(_title);
                sw.WriteLine(_password);
                sw.WriteLine( ((int)_displayOption).ToString());
                foreach (Photograph photo in this)
                {
                    photo.Write(sw);
                }
                ResetAlbumChanged();
            }
            finally
            {

                sw.Close();
                fs.Close();
            }
        }

        public void Save()
        {
            Save(FileName);
        }

        public void Open(string fileName)
        {
            var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs);
            int version;
            if (!Int32.TryParse(sr.ReadLine(), out version))
                version = 0;

            try
            {
                Clear();
                _fileName = fileName;
                ReadAlbumData(sr, version);
                if(!string.IsNullOrEmpty(_password))
                {
                    using (var passDlg = new PasswordDlg())
                    {
                        passDlg.Text = string.Format("Opening album {0}", Path.GetFileName(_fileName));
                        if(passDlg.ShowDialog() == DialogResult.OK && passDlg.Password != _password)
                        {

                            throw new ApplicationException("Invalid password provided");
                        }
                    }
                }

                Photograph.ReadDelegate ReadPhoto;
                switch (version)
                {
                    case 66:
                        ReadPhoto = Photograph.ReadVersion66;
                        break;
                    case 83:
                        ReadPhoto = Photograph.ReadVersion83;
                        break;
                    case 92:
                    case 93:
                        ReadPhoto = Photograph.ReadVersion92;
                        break;
                    default:
                        throw new IOException("Unrecognized album file format");
                }

                var p = ReadPhoto(sr);
                while (p!=null)
                {
                    Add(p);
                    p = ReadPhoto(sr);
                }
            }
            finally
            {
                ResetAlbumChanged();
                sr.Close();
                fs.Close();
            }
        }

        private void ReadAlbumData(StreamReader sr, int version)
        {
            _title = null;
            _password = null;
            _displayOption = DisplayValEnum.Caption;

            if(version>=93)
            {
                _title = sr.ReadLine();
                _password = sr.ReadLine();
                _displayOption = (DisplayValEnum) (int.Parse(sr.ReadLine()));
            }

            if(string.IsNullOrEmpty(_title))
            {
                _title = Path.GetFileNameWithoutExtension(_fileName);
            }
        }

        public string CurrentDisplayText
        {
            get { return CurrentPhoto.GetDisplayText(_displayOption); }
        }

        private static void InitDefaultDir()
        {
            if (String.IsNullOrWhiteSpace(_defaultDir))
            {
                _defaultDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                _defaultDir += @"\Album";
            }

            Directory.CreateDirectory(_defaultDir);
        }

        public static string DefaultDir
        {
            get
            {
                if (!_initializeDir)
                {
                    InitDefaultDir();
                    _initializeDir = false;
                }
                return _defaultDir;
            }

            set
            {
                _defaultDir = value;
                _initializeDir = true;
            }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public DisplayValEnum DisplayOption
        {
            get { return _displayOption; }
            set { _displayOption = value; }
        }

        public virtual Photograph this[int index]
        {
            get { return (Photograph) (List[index]); }
            set { List[index] = value; }
        }

        public virtual bool IsFixedSize
        {
            get { return false; }
        }

        public virtual bool IsReadOnly
        {
            get { return false; }
        }

        public virtual bool Contains(Photograph photo)
        {
            return List.Contains(photo);
        }

        public virtual void Insert(int index, Photograph photo)
        {
            List.Insert(index,photo);
            SetAlbumChanged();
        }

        public virtual void Remove(Photograph photo)
        {
            List.Remove(photo);
            SetAlbumChanged();
        }

        public void MoveBefore(int i)
        {
            if (i > 0 && i < Count)
            {
                var photo = this[i];
                RemoveAt(i);
                Insert(i-1,photo);
                SetAlbumChanged();
            }
        }

        public void MoveAfter(int i)
        {
            if (i >= 0 && i < Count - 1)
            {
                var photo = this[i];
                RemoveAt(i);
                Insert(i + 1, photo);
                SetAlbumChanged();
            }
        }

        public string GetDisplayText(Photograph photograph)
        {
            return photograph.GetDisplayText(_displayOption);
        }

        public bool HasPhotoEdits
        {
            get { return this.Cast<Photograph>().Any(photograph => photograph.HasEdits); }
        }
    }
}