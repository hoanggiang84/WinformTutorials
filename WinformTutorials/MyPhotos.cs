using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TUTORIALS.Library;

namespace WinformTutorials
{
    public partial class MyPhotos : Form
    {
        protected PhotoAlbum _album;
        protected bool _bAlbumChanged;

        public MyPhotos()
        {
            InitializeComponent();
            _album = new PhotoAlbum();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
                          {
                              Title = "Load Photo",
                              Filter = "jpg files (*.jpg)"
                                       + "|*.jpg|All files (*.*)|*.*"
                          };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    updateStatus("Loading " + dlg.FileName);
                    pbxPhoto.Image = new Bitmap(dlg.OpenFile());
                    statusImageSize.Text = string.Format("[{0}x{1}]", pbxPhoto.Image.Width, pbxPhoto.Image.Height);

                    int percent = 100;
                    if (pbxPhoto.SizeMode != PictureBoxSizeMode.StretchImage)
                    {
                        var rect = pbxPhoto.ClientRectangle;
                        int imgWidth = pbxPhoto.Image.Width;
                        int imgHeight = pbxPhoto.Image.Height;
                        percent = 100*Math.Min(rect.Width, imgWidth)*Math.Min(rect.Height, imgHeight)/
                                  (imgWidth*imgHeight);
                    }
                    statusZoomFactor.Text = string.Format("{0}%", percent);
                    updateStatus("Loaded " + dlg.FileName);
                }
                catch (Exception ex)
                {
                    updateStatus("Unable to Load " + dlg.FileName);
                    MessageBox.Show("Unable to load file: " + ex.Message);
                }
            }
            dlg.Dispose();
        }

        private void updateStatus(string message)
        {
            labelStatus.Text = message;
        }

        private void menuStretch_Click(object sender, EventArgs e)
        {
            setPhotoSizeMode(PictureBoxSizeMode.StretchImage);
        }

        private void setPhotoSizeMode(PictureBoxSizeMode mode)
        {
            pbxPhoto.SizeMode = mode;
            pbxPhoto.Invalidate();
        }

        private void menuActualSize_Click(object sender, EventArgs e)
        {
            setPhotoSizeMode(PictureBoxSizeMode.Normal);
        }

        private void menuCenter_Click(object sender, EventArgs e)
        {
            setPhotoSizeMode(PictureBoxSizeMode.Normal);
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
                          {
                              Title = "Add Photos",
                              Multiselect = true,
                              Filter = "Image Files (JPEG, GIF, BMP, etc.)|" +
                                       "*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png|" +
                                       "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg |" +
                                       "GIF files  (*.gif)|*.gif |" +
                                       "BMP files  (*.bmp)|*.bmp |" +
                                       "TIFF files  (*.tif;*.tiff)|*.tif;*.tiff |" +
                                       "PNG files  (*.png)|*.png |" +
                                       "All files  (*.*)|*.*",
                              InitialDirectory = Environment.CurrentDirectory
                          };

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                var files = dlg.FileNames;
                updateStatus(string.Format("Loading {0} Files", files.Length));
                foreach (var photo in 
                    from s in files 
                    select new Photograph(s) into photo 
                    let index = _album.IndexOf(photo) 
                    where index<0 
                    select photo)
                {
                    _album.Add(photo);
                    _bAlbumChanged = true;
                }

                dlg.Dispose();
                Invalidate();
            }
        }

        private void menuRemove_Click(object sender, EventArgs e)
        {
            if(_album.Count>0)
            {
                _album.RemoveAt(_album.CurrentPosition);
                _bAlbumChanged = true;
            }
            Invalidate();
        }
    }
}
