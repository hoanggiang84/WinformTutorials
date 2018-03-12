using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace TUTORIALS.Library
{
    public class Photograph:IDisposable,IEditableObject
    {
        private const int ThumbSize = 90;
        private readonly string _fileName;
        private string _caption;
        private string _photographer;
        private string _notes;
        private DateTime _dateTaken;
        private Bitmap _bitmap;
        private Bitmap _thumbnail;
        private static Bitmap _invalidImageBitmap;
        private bool _modified;
        private bool _editing;
        private string _editCaption;
        private DateTime _editDateTaken;
        private string _editPhotographer;
        private string _editNotes;


        public Photograph(string fileName)
        {
            _fileName = fileName;
            _bitmap = InvalidPhotoImage;
            _caption = Path.GetFileNameWithoutExtension(_fileName);
            _dateTaken = DateTime.Now;
            _photographer = "unknown";
            _notes = "no notes provided";
            _modified = false;
            _editing = false;
        }

        public string Caption
        {
            get { return _caption; }
            set
            {
                _caption = string.IsNullOrWhiteSpace(value) ? Path.GetFileNameWithoutExtension(_fileName) : value;
            }
        }

        public bool IsImageValid { get { return (Image != InvalidPhotoImage); } }

        public DateTime DateTaken { get { return _dateTaken; } set { _dateTaken = value; } }

        public string Photographer { get { return _photographer; } set { _photographer = value; } }
        
        public string FileName { get { return _fileName; } }

        public string Notes { get { return _notes; } set { _notes = value; } }

        public Bitmap Image
        {
            get
            {
                if (_bitmap == null || _bitmap.Equals(InvalidPhotoImage))
                {
                    try
                    {
                        _bitmap = new Bitmap(_fileName);
                    }
                    catch (Exception)
                    {
                        _bitmap = InvalidPhotoImage;
                    }
                }
                  
                return _bitmap;
            }
        }


        public static Bitmap InvalidPhotoImage
        {
            get
            {
                if (_invalidImageBitmap == null)
                {
                    var bm = new Bitmap(100, 100);
                    var g = Graphics.FromImage(bm);
                    g.Clear(Color.WhiteSmoke);

                    using (var p = new Pen(Color.Red, 5))
                    {
                        g.DrawLine(p, 0, 0, 100, 100);
                        g.DrawLine(p, 100, 0, 0, 100);
                        _invalidImageBitmap = bm;
                    }
                }
                return _invalidImageBitmap;
            }
        }



        public override bool Equals(object obj)
        {
            if(obj is Photograph)
            {
                var p = obj as Photograph;
                return _fileName.ToLower().Equals(p.FileName.ToLower());
            }
            return false;
        }

        public override int GetHashCode()
        {
            return FileName.GetHashCode();
        }

        public void Dispose()
        {
            if(_bitmap!= null && _bitmap != InvalidPhotoImage)
                _bitmap.Dispose();

            if(_thumbnail != null)
                _thumbnail.Dispose();
            
            _thumbnail = null;
            _bitmap = null;
        }

        public bool IsDisposed()
        {
            return _bitmap == null;
        }

        public override string ToString()
        {
            return FileName;
        }

        public Rectangle ScaleToFit(Rectangle targetArea)
        {
            var resultRect = new Rectangle(targetArea.Location, targetArea.Size);

            // Determine best fit: width or height
            if (resultRect.Height * Image.Width > resultRect.Width * Image.Height)
            {
                // Final width should match target,
                // determine and center height
                resultRect.Height = resultRect.Width * Image.Height / Image.Width;
                resultRect.Y += (targetArea.Height - resultRect.Height) / 2;
            }
            else
            {
                // Final height shoud match target,
                // determine and center width
                resultRect.Width = resultRect.Height * Image.Width / Image.Height;
                resultRect.X += (targetArea.Width - resultRect.Width) / 2;
            }
            return resultRect;
        }

        public void Write(StreamWriter sw)
        {
            sw.WriteLine(FileName);
            sw.WriteLine(Caption);
            sw.WriteLine(DateTaken.Ticks);
            sw.WriteLine(Photographer);

            sw.WriteLine(Notes.Length);
            sw.Write(Notes.ToCharArray());
            sw.WriteLine();
            _modified = false;
            _editing = false;
        }

        public static Photograph ReadVersion66(StreamReader sr)
        {
            var name = sr.ReadLine();
            return (name == null) ? null : new Photograph(name);
        }

        public static Photograph ReadVersion83(StreamReader sr)
        {
            var name = sr.ReadLine();
            return (name == null) ? null : new Photograph(name) {Caption = sr.ReadLine()};
        }

        public static Photograph ReadVersion92(StreamReader sr)
        {
            var p = ReadVersion83(sr);
            if (p == null)
                return null;

            long ticks = long.Parse(sr.ReadLine());
            p.DateTaken = new DateTime(ticks);
            p.Photographer = sr.ReadLine();
            int noteLen = int.Parse(sr.ReadLine());
            var notesArray = new char[noteLen];
            sr.Read(notesArray, 0, noteLen);
            p.Notes = new string(notesArray);
            sr.ReadLine();
            return p;
        }

        public string GetDisplayText(DisplayValEnum displayOption)
        {
            switch (displayOption)
            {
                case DisplayValEnum.FileName:
                    return Path.GetFileName(FileName);
                case DisplayValEnum.Date:
                    return DateTaken.ToString("g");
                default:
                case DisplayValEnum.Caption:
                    return Caption;
            }
        }

        public Bitmap Thumbnail
        {
            get
            {
                if(_thumbnail==null)
                {
                    var scaleRect = ScaleToFit(new Rectangle(0, 0, ThumbSize, ThumbSize));
                    var bm = new Bitmap(scaleRect.Width, scaleRect.Height);
                    var g = Graphics.FromImage(bm);
                    var gu = g.PageUnit;
                    g.DrawImage(Image, bm.GetBounds(ref gu));
                    _thumbnail = bm;
                }
                return _thumbnail;
            }
        }
        public delegate Photograph ReadDelegate(StreamReader sr);

        public void BeginEdit()
        {
            if (!_editing)
            {
                _editCaption = Caption;
                _editDateTaken = DateTaken;
                _editPhotographer = Photographer;
                _editNotes = Notes;
                _editing = true;
            }
        }

        public void EndEdit()
        {
            if(_editing)
            {
                _modified = Caption != _editCaption
                            || Photographer != _editPhotographer
                            || DateTaken != _editDateTaken
                            || Notes != _editNotes;
                _editing = false;
            }
        }

        public void CancelEdit()
        {
            if (_editing)
            {
                Caption = _editCaption;
                Photographer = _editPhotographer;
                DateTaken = _editDateTaken;
                Notes = _editNotes;
                _editing = false;
            }
        }

        public bool HasEdits { get { return _modified; } }
    }
}