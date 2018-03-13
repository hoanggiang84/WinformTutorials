using System;
using System.Drawing;
using System.Windows.Forms;
using TUTORIALS.Library;

namespace WinformTutorials.SideForms
{
    public partial class SlideShowForm : Form
    {
        public SlideShowForm(PhotoAlbum album)
        {
            InitializeComponent();

            _album = album;
            _albumPos = 0;
        }

        private PhotoAlbum _album;
        private int _albumPos;

        protected void SetInterval()
        {
            int interval;
            try
            {
                interval = Convert.ToInt32(textBoxInterval.Text);
            }
            catch (Exception)
            {
                textBoxInterval.Text = "2";
                interval = 2;
            }

            timerSlide.Interval = interval*1000;
        }

        private void SlideShowForm_Load(object sender, EventArgs e)
        {
            SetInterval();
            timerSlide.Enabled = true;
            trackBarSlide.Minimum = 0;
            trackBarSlide.Maximum = _album.Count - 1;
        }

        private void pictureBoxSlide_Paint(object sender, PaintEventArgs e)
        {
            if(_albumPos >= _album.Count)
                return;

            var photo = _album[_albumPos];
            if(photo != null)
            {
                Text = string.Format("{0} ({1:#}/{2:#})", photo.Caption, _albumPos + 1, _album.Count);
                e.Graphics.DrawImage(photo.Image, photo.ScaleToFit(pictureBoxSlide.ClientRectangle));
            }
            else
            {
                e.Graphics.Clear(SystemColors.Control);
            }
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            _albumPos++;
            if(_albumPos > _album.Count)
            {
                buttonStop.Text = "&Start";
                _albumPos = 0;
                trackBarSlide.Value = 0;
                pictureBoxSlide.Invalidate();
                timerSlide.Enabled = false;
            }
            else if (_albumPos == _album.Count)
            {
                Text = "Finished";
            }
            else
            {
                pictureBoxSlide.Invalidate();
                trackBarSlide.Value = _albumPos;
            }

            SetInterval();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if(buttonStop.Text =="&Stop")
            {
                timerSlide.Stop();
                buttonStop.Text = "Re&sume";
            }
            else
            {
                timerSlide.Start();
                buttonStop.Text = "&Stop";
            }
        }

        private void trackBarSlide_Scroll(object sender, EventArgs e)
        {
            _albumPos = trackBarSlide.Value;
            pictureBoxSlide.Invalidate();
        }

        private void pictureBoxSlide_Resize(object sender, EventArgs e)
        {
            pictureBoxSlide.Invalidate();
        }
    }
}
