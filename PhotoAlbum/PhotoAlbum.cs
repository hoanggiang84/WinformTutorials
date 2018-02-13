using System;
using System.Collections;
using System.Drawing;

namespace TUTORIALS.Library
{
    public class PhotoAlbum : CollectionBase, IDisposable
    {
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
        public string FileName { get { return _fileName; } set { _fileName = value; } }

        protected override void OnClear()
        {
            _currentPos = 0;
            _fileName = null;
            Dispose();
            base.OnClear();

        }

        protected override void OnRemoveComplete(int index, object value)
        {
            CurrentPosition = _currentPos;
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
            return List.Add(p);
        }
    }
}