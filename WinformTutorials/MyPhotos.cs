using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using TUTORIALS.Library;

namespace WinformTutorials
{
    public partial class MyPhotos : Form
    {
        protected PhotoAlbum _album;
        protected bool _bAlbumChanged;

        private void SetTitleBar()
        {
            var ver = new Version(Application.ProductVersion);
            if (string.IsNullOrWhiteSpace(_album.FileName))
            {
                Text = string.Format("MyPhotos {0:#}.{1:#}", ver.Major, ver.Minor);
            }
            else
            {
                var baseFile = Path.GetFileNameWithoutExtension(_album.FileName);
                Text = string.Format("{0} - MyPhotos {1:#}.{2:#}", baseFile, ver.Major, ver.Minor);
            }
        }

   

        public MyPhotos()
        {
            InitializeComponent();
            menuNew_Click(this,EventArgs.Empty);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            if(_bAlbumChanged && !string.IsNullOrWhiteSpace(_album.FileName))
            {
                menuSave_Click(sender,e);
            }

            var dlg = new OpenFileDialog
                          {
                              Title = "Open Album",
                              Filter = "Album files (*.abm)|*.abm|" +
                                       "All files (*.*)|*.*",
                                       InitialDirectory = PhotoAlbum.DefaultDir,
                                       RestoreDirectory = true
                                       
                          };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _album.Open(dlg.FileName);
                _album.FileName = dlg.FileName;
                _bAlbumChanged = false;
                Invalidate();
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
                              InitialDirectory = @"D:\CurrentWork\Tmp"
                          };

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                var files = dlg.FileNames;
                updateStatus(string.Format("Loading {0} Files", files.Length));
                foreach (var file in files)
                {
                    var photo = new Photograph(file);
                    if(_album.IndexOf(photo) < 0)
                    {
                        _album.Add(photo);
                        _bAlbumChanged = true;
                    }
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

        protected override void OnPaint(PaintEventArgs e)
        {
            if(_album.Count>0)
            {
                var photo = _album.CurrentPhoto;
                pbxPhoto.Image = photo.Image;

                updateStatus(photo.FileName);
                statusImageSize.Text = string.Format("{0:#} x {1:#}", photo.Image.Width, photo.Image.Height);
                statusFileIndex.Text = string.Format("{0}/{1}", _album.CurrentPosition + 1, _album.Count);
            }
            else
            {
                pbxPhoto.Image = null;
                updateStatus("No Photos in Album");
                statusImageSize.Text = string.Empty;
                statusFileIndex.Text = string.Empty;
            }

            statusStrip.Invalidate();
            base.OnPaint(e);
        }

        private void menuNext_Click(object sender, EventArgs e)
        {
            if(_album.CurrentNext())
            {
               Invalidate();
            }
        }

        private void menuPrevious_Click(object sender, EventArgs e)
        {
            if (_album.CurrentPrev())
            {
                Invalidate();
            }
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            if(_album != null)
                _album.Dispose();
            _album = new PhotoAlbum();
            SetTitleBar();
            Invalidate();
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog
                          {
                              Title = "Save Album",
                              DefaultExt = "abm",
                              Filter = "Album files (*.abm)|*.abm|" + "All files|*.*",
                              InitialDirectory = PhotoAlbum.DefaultDir,
                              RestoreDirectory = true

                          };
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                _album.FileName = dlg.FileName;
                menuSave_Click(sender, e);
                SetTitleBar();
            }
            dlg.Dispose();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(_album.FileName))
                menuSaveAs_Click(sender,e);
            else
            {
                _album.Save();
                _bAlbumChanged = false;
            }
        }
    }
}
