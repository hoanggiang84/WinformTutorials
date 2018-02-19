using System;
using System.Drawing;
using System.IO;

namespace TUTORIALS.Library
{
    public class Photograph:IDisposable
    {
        private readonly string _fileName;
        private string _caption;
        private Bitmap _bitmap;


        public Photograph(string fileName)
        {
            _fileName = fileName;
            _bitmap = InvalidPhotoImage;
            _caption = Path.GetFileNameWithoutExtension(_fileName);
        }

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

    }
}