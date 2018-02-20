using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace TUTORIALS.Library
{
    public class Photograph:IDisposable
    {
        private readonly string _fileName;
        private string _caption;
        private string _photographer;
        private string _notes;
        private DateTime _dateTaken;
        private Bitmap _bitmap;


        public Photograph(string fileName)
        {
            _fileName = fileName;
            _bitmap = InvalidPhotoImage;
            _caption = Path.GetFileNameWithoutExtension(_fileName);
            _dateTaken = DateTime.Now;
            _photographer = "unknown";
            _notes = "no notes provided";
        }

        public string Photographer { get { return _photographer; } set { _photographer = value; } }

        public string Notes { get { return _notes; } set { _notes = value; } }

        public DateTime DateTaken { get { return _dateTaken; } set { _dateTaken = value; } }

        public string Caption
        {
            get { return _caption; }
            set
            {
                _caption = string.IsNullOrWhiteSpace(value) ? Path.GetFileNameWithoutExtension(_fileName) : value;
            }
        }

        public string FileName { get { return _fileName; } }

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

        private static Bitmap _invalidImageBitmap;
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

        public bool IsImageValid
        {
            get { return (_bitmap != InvalidPhotoImage); }
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

        public delegate Photograph ReadDelegate(StreamReader sr);
    }
}