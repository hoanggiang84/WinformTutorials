using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTORIALS.Library;
using TUTORIALS.Library.Forms;

namespace TUTORIALS.MyAlbumEditor
{
    public partial class MainForm : Form
    {
        private PhotoAlbum _album;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            _album = new PhotoAlbum();
            base.OnLoad(e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseAlbum()
        {
            if(_album.IsChanged)
            {
                var dlgAns = MessageBox.Show(
                    string.Format("Do you want to save your changes to {0}?", _album.FileName), "Save Changes?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dlgAns == DialogResult.Yes)
                    _album.Save();
            }

            _album = new PhotoAlbum();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            CloseAlbum();
            base.OnClosing(e);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            CloseAlbum();

            using (var openDlg = new OpenFileDialog())
            {
                openDlg.Title = "Open Album";
                openDlg.Filter = "abm files (*.abm)|*.abm| All Files (*.*)|*.*";
                openDlg.InitialDirectory = PhotoAlbum.DefaultDir;

                try
                {
                    if(openDlg.ShowDialog() == DialogResult.OK)
                    {
                        _album.Open(openDlg.FileName);
                        _album.ResetAlbumChanged();
                        Text = _album.FileName;
                        UpdateList();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(string.Format("Unable to open album: {0}", openDlg.FileName), "Open Album Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateList()
        {
            //listBoxPhotos.DataSource = _album;
            listBoxPhotos.BeginUpdate();
            listBoxPhotos.Items.Clear();
            foreach (var p in _album)
                listBoxPhotos.Items.Add(p);
            listBoxPhotos.EndUpdate();
        }

        private void buttonAlbumProperties_Click(object sender, EventArgs e)
        {
            using (var dlg = new AlbumEditDlg(_album))
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    UpdateList();
                }
            }
        }

        private void buttonPhotoProperties_Click(object sender, EventArgs e)
        {
            if (_album.Count == 0) return;

            if (listBoxPhotos.SelectedIndex >= 0)
                _album.CurrentPosition = listBoxPhotos.SelectedIndex;

            using (var dlg = new PhotoEditDlg(_album))
            {
                if(dlg.ShowDialog()==DialogResult.OK)
                {
                    UpdateList();
                }
            }
        }

        private void listBoxPhotos_DoubleClick(object sender, EventArgs e)
        {
            buttonPhotoProperties.PerformClick();
        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var numSelected = listBoxPhotos.SelectedIndices.Count;
            var someSelected = numSelected > 0;

            buttonMoveUp.Enabled = (someSelected && !listBoxPhotos.GetSelected(0));
            buttonMoveDown.Enabled = (someSelected && !listBoxPhotos.GetSelected(listBoxPhotos.Items.Count - 1));
            buttonRemove.Enabled = someSelected;
            buttonPhotoProperties.Enabled = numSelected == 1;
        }

    }
}
