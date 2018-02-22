using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            comboBoxAlbums.Items.AddRange(Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm"));
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

        private void OpenAlbum(string fileName)
        {
            CloseAlbum();
            _album.Open(fileName);
            Text = _album.FileName;
            UpdateList();
        }

        private void UpdateList()
        {
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

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            var indices = listBoxPhotos.SelectedIndices;
            var newSelects = new int[indices.Count];

            for (int i = 0; i < indices.Count; i++)
            {
                int index = indices[i];
                _album.MoveBefore(index);
                newSelects[i] = index - 1;
            }
            UpdateList();

            listBoxPhotos.ClearSelected();
            foreach (var i in newSelects)
                listBoxPhotos.SetSelected(i,true);
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            var indices = listBoxPhotos.SelectedIndices;
            var newSelects = new int[indices.Count];

            for (int i = indices.Count - 1; i >=0; i--)
            {
                int index = indices[i];
                _album.MoveAfter(index);
                newSelects[i] = index + 1;
            }
            UpdateList();

            listBoxPhotos.ClearSelected();
            foreach (var i in newSelects)
                listBoxPhotos.SetSelected(i, true);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int numSelects = listBoxPhotos.SelectedItems.Count;
            string msg = numSelects == 1 ? "Do you really want to remove the selected photo?" 
                             : string.Format("Do you really want to remove the {0} selected photos?", numSelects);
            var dlgAns = MessageBox.Show(msg, "Remove Photos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dlgAns == DialogResult.Yes)
            {
                var indices = listBoxPhotos.SelectedIndices;
                for (int i = indices.Count - 1; i >=0; i--)
                {
                    _album.RemoveAt(indices[i]);
                }
                UpdateList();
            }
        }

        private void comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            var albumPath = comboBoxAlbums.SelectedItem.ToString();
            if(albumPath == _album.FileName)
                return;

            try
            {
                CloseAlbum();
                OpenAlbum(albumPath);
                buttonAlbumProperties.Enabled = true;
                listBoxPhotos.BackColor = SystemColors.Window;
            }
            catch (Exception)
            {
                Text = "Unable to open selected album";
                listBoxPhotos.Items.Clear();
                listBoxPhotos.BackColor = SystemColors.Control;
                buttonAlbumProperties.Enabled = false;
            }
        }

        private void thumbnailsMenu_Click(object sender, EventArgs e)
        {
            thumbnailsMenu.Checked = !thumbnailsMenu.Checked;
            if(thumbnailsMenu.Checked)
            {
                listBoxPhotos.DrawMode
            }
        }
    }
}
