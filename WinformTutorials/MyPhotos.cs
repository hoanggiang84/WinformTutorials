using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using TUTORIALS.Library;
using TUTORIALS.Library.Forms;

namespace WinformTutorials
{
    public partial class MyPhotos : Form
    {
        protected PhotoAlbum _album = new PhotoAlbum();
        private DisplayMode _selectedMode = DisplayMode.ScaleToFit;
        private PixelDlg _dlgPixel;
        private int _nPixelDlgIndex;
     
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
            InitToolStripItems();
            menuNew_Click(this,EventArgs.Empty);
        }

        private void InitToolStripItems()
        {
            toolStripButtonNew.Tag = menuNew;
            toolStripButtonOpen.Tag = menuOpen;
            toolStripButtonSave.Tag = menuSave;

            toolStripButtonPrevious.Tag = menuPrevious;
            toolStripButtonNext.Tag = menuNext;

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            if(!closeCurrentAlbum())
                return;

            using( var dlg = new OpenFileDialog
                          {
                              Title = "Open Album",
                              Filter = "Album files (*.abm)|*.abm|" +
                                       "All files (*.*)|*.*",
                                       InitialDirectory = PhotoAlbum.DefaultDir,
                                       RestoreDirectory = true
                          })
            try
            {
                if(dlg.ShowDialog() != DialogResult.OK)
                    return;
                _album.Open(dlg.FileName);
                _album.FileName = dlg.FileName;
                _album.ResetAlbumChanged();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Unable to open file {0}\n" +
                                                    "Error: {1}", dlg.FileName, ex.Message),
                    "Open Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Invalidate();
            }
        }

        private void updateStatus(string message)
        {
            labelStatus.Text = message;
        }

        private void menuStretch_Click(object sender, EventArgs e)
        {
            setPhotoDisplayMode(DisplayMode.StretchToFit);
        }

        private void setPhotoDisplayMode(DisplayMode displayMode)
        {
            _selectedMode = displayMode;
            panelImage.Invalidate();
            Invalidate();
        }

        private void menuActualSize_Click(object sender, EventArgs e)
        {
            setPhotoDisplayMode(DisplayMode.ActualSize);
        }

        private void menuScaleToFit_Click(object sender, EventArgs e)
        {
            setPhotoDisplayMode(DisplayMode.ScaleToFit);
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog
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
            })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var files = dlg.FileNames;
                    updateStatus(string.Format("Loading {0} Files", files.Length));
                    foreach (var file in files)
                    {
                        var photo = new Photograph(file);
                        if (_album.IndexOf(photo) < 0)
                            _album.Add(photo);
                    }

                    Invalidate();
                }
            }
        }

        private void menuRemove_Click(object sender, EventArgs e)
        {
            if(_album.Count>0)
            {
                var dlgAns = MessageBox.Show(this,
                                             string.Format("Are you sure want to remove {0} from current album?",
                                                           _album.CurrentPhoto.FileName), "Remove Current Photo",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                             MessageBoxDefaultButton.Button2);
                if(dlgAns == DialogResult.Yes)
                    _album.RemoveAt(_album.CurrentPosition);
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(_album.Count > 0)
            {
                var photo = _album.CurrentPhoto;
                updateStatus(_album.CurrentDisplayText);
                statusImageSize.Text = string.Format("{0:#} x {1:#}", photo.Image.Width, photo.Image.Height);
                statusFileIndex.Text = string.Format("{0}/{1}", _album.CurrentPosition + 1, _album.Count);
            }
            else
            {
                updateStatus("No Photos in Album");
                statusImageSize.Text = string.Empty;
                statusFileIndex.Text = string.Empty;
            }

            if (toolStripButtonPixelData.Checked && !(_dlgPixel == null || _dlgPixel.IsDisposed))
                toolStripButtonPixelData.Checked = false;

            statusStrip.Invalidate();
            panelImage.Invalidate();
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
            if (closeCurrentAlbum())
            {
                createNewAlbum();
                Invalidate();
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog
                              {
                                  Title = "Save Album",
                                  DefaultExt = "abm",
                                  Filter = "Album files (*.abm)|*.abm|" + "All files|*.*",
                                  InitialDirectory = PhotoAlbum.DefaultDir,
                                  RestoreDirectory = true

                              })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _album.FileName = dlg.FileName;
                    menuSave_Click(sender, e);
                    SetTitleBar();
                }
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(_album.FileName))
            {
                menuSaveAs_Click(sender,e);
            }
            else
            {
                try
                {
                    _album.Save();
                }
                catch (Exception ex)
                {
                    var msg = string.Format("Unable to save file {0} - {1}" +
                                            "\nWould you like to save the album in an alternate file?", _album.FileName, ex.Message);
                    var dlgAns = MessageBox.Show(this, msg, "Save Album Error", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    if(dlgAns == DialogResult.Yes)
                        menuSaveAs_Click(sender, e);
                }
            }
        }

        private enum DisplayMode
        {
            ScaleToFit = 0,
            StretchToFit = 1,
            ActualSize = 2
        }

        private void MyPhotos_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void panelImage_Paint(object sender, PaintEventArgs e)
        {
            if(_dlgPixel!= null && _nPixelDlgIndex != _album.CurrentPosition)
            {
                _nPixelDlgIndex = _album.CurrentPosition;
                var p = panelImage.PointToClient(MousePosition);
                UpdatePixelData(p.X, p.Y);
            }

            if(_album.Count>0)
            {
                var photo = _album.CurrentPhoto;
                var g = e.Graphics;
                switch (_selectedMode)
                {
                    case DisplayMode.ScaleToFit:
                        panelImage.AutoScroll = false;
                        g.DrawImage(photo.Image, photo.ScaleToFit(panelImage.DisplayRectangle));
                        break;
                    case DisplayMode.StretchToFit:
                        panelImage.AutoScroll = false;
                        g.DrawImage(photo.Image, panelImage.DisplayRectangle);
                        break;
                    case DisplayMode.ActualSize:
                        panelImage.AutoScroll = true;
                        g.DrawImage(photo.Image,
                            panelImage.AutoScrollPosition.X,
                            panelImage.AutoScrollPosition.Y,
                            photo.Image.Width,
                            photo.Image.Height);
                        panelImage.AutoScrollMinSize = photo.Image.Size;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                if(!ctrlKeyHeld)
                    panelImage.ContextMenuStrip = contextMenuView;
            }
            else
            {
                e.Graphics.Clear(SystemColors.Control);
                panelImage.ContextMenuStrip = null;
            }
        }

        private bool closeCurrentAlbum()
        {
            if(_album.IsChanged)
            {
                string msg = string.IsNullOrWhiteSpace(_album.FileName) ? "Do you want to save the current album?" 
                                 : string.Format("Do you want to save your changes to {0}", _album.FileName);

                var dlgAns = MessageBox.Show(this, msg, "Save Current Album?", MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                switch (dlgAns)
                {
                    case DialogResult.Yes:
                        menuSave_Click(this, EventArgs.Empty);
                        break;
                    case DialogResult.Cancel:
                        return false;
                }
            }

            return true;
        }

        private void createNewAlbum()
        {
            if (_album != null)
                _album.Dispose();

            _album = new PhotoAlbum();
            SetTitleBar();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !closeCurrentAlbum();
            base.OnClosing(e);
        }

        private void menuEdit_DropDownOpening(object sender, EventArgs e)
        {
            menuPhotoProperties.Enabled = (_album.Count > 0);
        }

        private void menuPhotoPro_Click(object sender, EventArgs e)
        {
            using (var dlg = new PhotoEditDlg(_album))
            {
                if (dlg.ShowDialog()==DialogResult.OK) { }
                updateStatus(_album.CurrentPhoto.Caption);
            }
        }

        private void menuPixel_Click(object sender, EventArgs e)
        {
            if(_dlgPixel == null || _dlgPixel.IsDisposed)
                _dlgPixel = new PixelDlg {Owner = this};

            _nPixelDlgIndex = _album.CurrentPosition;
            var p = panelImage.PointToClient(MousePosition);
            UpdatePixelData(p.X, p.Y);
            _dlgPixel.Show();

        }

        private void UpdatePixelData(int x, int y)
        {
            if(_dlgPixel == null || !_dlgPixel.Visible)
                return;

            var photo = _album.CurrentPhoto;
            _dlgPixel.Text = photo.Caption;

            var rect = panelImage.ClientRectangle;
            if(photo == null || !rect.Contains(x,y))
            {
                _dlgPixel.Text = (photo == null) ? " " : photo.Caption;
                _dlgPixel.XVal = 0;
                _dlgPixel.YVal = 0;
                _dlgPixel.RedVal = 0;
                _dlgPixel.GreenVal = 0;
                _dlgPixel.BlueVal = 0;
                _dlgPixel.Update();
                Cursor = Cursors.Default;
                return;
            }

            int xp, yp;
            var bmp = photo.Image;
            switch (_selectedMode)
            {
                case DisplayMode.StretchToFit:
                    xp = x*bmp.Width/rect.Width;
                    yp = y*bmp.Height/rect.Height;
                    break;
                case DisplayMode.ScaleToFit:
                    var rect2 = photo.ScaleToFit(rect);
                    if(!rect2.Contains(x,y))
                        return;

                    xp = (x - rect2.Left)*bmp.Width/rect2.Width;
                    yp = (y - rect2.Top)*bmp.Height/rect2.Height;
                    break;
                case DisplayMode.ActualSize:
                    var rect3 = new Rectangle(rect.X, rect.Y, photo.Image.Width, photo.Image.Height);
                    if(!rect3.Contains(x,y))
                        return;
                    xp = x;
                    yp = y;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var c = bmp.GetPixel(xp, yp);
            _dlgPixel.XVal = xp;
            _dlgPixel.YVal = yp;
            _dlgPixel.RedVal = c.R;
            _dlgPixel.GreenVal = c.G;
            _dlgPixel.BlueVal = c.B;
            _dlgPixel.Update();
            _dlgPixel.Focus();
        }

        private void panelImage_MouseMove(object sender, MouseEventArgs e)
        {
            UpdatePixelData(e.X, e.Y);
        }

        private void albumPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new AlbumEditDlg(_album))
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    _album.SetAlbumChanged();
                    SetTitleBar();
                    Invalidate();
                }
            }
        }

        private void MyPhotos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    e.IsInputKey = false;
                    menuNext.PerformClick();
                    break;

                case Keys.Subtract:
                    e.IsInputKey = false;
                    menuPrevious.PerformClick();
                    break;
            }
        }

        private void MyPhotos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.PageUp:
                    e.Handled = true;
                    menuNext.PerformClick();
                    break;
                case Keys.PageDown:
                    e.Handled = true;
                    menuPrevious.PerformClick();
                    break;
                case Keys.Home:
                    e.Handled = true;
                    _album.CurrentPosition = 0;
                    Invalidate();
                    break;
                case Keys.End:
                    e.Handled = true;
                    _album.CurrentPosition = _album.Count - 1;
                    Invalidate();
                    break;
                case Keys.ControlKey:
                    ctrlKeyHeld = true;
                    panelImage.Cursor = Cursors.SizeWE;
                    panelImage.ContextMenuStrip = null;
                    break;
            }
        }

        private bool ctrlKeyHeld;
        private void panelImage_MouseDown(object sender, MouseEventArgs e)
        {
            if(ctrlKeyHeld)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        menuPrevious.PerformClick();
                        break;
                    case MouseButtons.Right:
                        menuNext.PerformClick();
                        break;
                }
            }
        }

        private void MyPhotos_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                    case Keys.ControlKey:
                    ReleaseControlKey();
                    break;
            }
        }

        private void ReleaseControlKey()
        {
            ctrlKeyHeld = false;
            panelImage.Cursor = Cursors.Default;
            panelImage.ContextMenuStrip = contextMenuView;
        }

        private void MyPhotos_Deactivate(object sender, EventArgs e)
        {
            if(ctrlKeyHeld)
                ReleaseControlKey();
        }

        private void toolStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var menuButton = e.ClickedItem.Tag as ToolStripMenuItem;
            if(menuButton != null)
                menuButton.PerformClick();
        }

        private void toolStripButtonPixelData_Click(object sender, EventArgs e)
        {
            if(toolStripButtonPixelData.Checked)
            {
                menuPixel.PerformClick();
                toolStripButtonPixelData.Text = "Hide pixel data";
            }
            else
            {
                toolStripButtonPixelData.Text = "Show pixel data";
                _dlgPixel.Close();
            }
        }


    }
}
