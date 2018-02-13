using System;
using System.Drawing;

namespace TUTORIALS.Library
{
    public class Photograph:IDisposable
    {
        private string _fileName;
        private Bitmap _bitmap;

        public Photograph(string fileName)
        {
            _fileName = fileName;
            _bitmap = InvalidPhotoImage;
        }

        public string FileName { get { return _fileName; } }

        public Bitmap Image
        {
            get
            {
                if (_bitmap == null)
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
    }
}