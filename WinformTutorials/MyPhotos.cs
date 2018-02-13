using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinformTutorials
{
    public partial class MyPhotos : Form
    {
        public MyPhotos()
        {
            InitializeComponent();

            DefineContextMenu();
        }

        private void DefineContextMenu()
        {

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
    }
}
