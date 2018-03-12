using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TUTORIALS.Library;

namespace TUTORIALS.MyAlbumData
{
    public partial class MyAlbumDataForm : Form
    {
        private PhotoAlbum _album;

        public MyAlbumDataForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MyAlbumDataForm_Load(object sender, EventArgs e)
        {
            var ver = new Version(Application.ProductVersion);
            Text = string.Format("MyAlbumData {0:#}.{1:#}", ver.Major, ver.Minor);
            _album = new PhotoAlbum();
            comboBoxAlbum.DataSource = Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm");

            dataGridViewPhotoAlbum.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewPhotoAlbum.Name = "PhotoAlbum";
            dataGridViewPhotoAlbum.RowHeadersWidth = 15;

            dataGridViewPhotoAlbum.Columns[0].Name = "Caption";
            dataGridViewPhotoAlbum.Columns[0].HeaderText = "Caption";
            dataGridViewPhotoAlbum.Columns[0].Width = 100;

            dataGridViewPhotoAlbum.Columns[1].HeaderText = "Valid?";
            dataGridViewPhotoAlbum.Columns[1].ReadOnly = true;
            dataGridViewPhotoAlbum.Columns[1].Width = 30;

            dataGridViewPhotoAlbum.Columns[2].DefaultCellStyle.Format = "d";
            dataGridViewPhotoAlbum.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPhotoAlbum.Columns[2].Width = 80;
            dataGridViewPhotoAlbum.Columns[2].HeaderText = "Date Taken";

            textBoxFileName.DataBindings.Add("Text", _album, "FileName");
            textBoxCaption.DataBindings.Add("Text", _album, "Caption");
            textBoxPhotographer.DataBindings.Add("Text", _album, "Photographer");
            textBoxNotes.DataBindings.Add("Text", _album, "Notes");
            dateTimePickerDateTaken.DataBindings.Add("Value", _album, "DateTaken");
            pictureBoxPhoto.DataBindings.Add("Tag", _album, "Image");

        }

        private void comboBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var albumFile = comboBoxAlbum.SelectedItem.ToString();
            if(_album != null)
            {
                SaveChanges();
                _album.Dispose();
            }

            _album.Clear();
            try
            {
                _album.Open(albumFile);
                dataGridViewPhotoAlbum.Text = _album.Title;
            }
            catch(Exception)
            {
                _album.Clear();
                dataGridViewPhotoAlbum.Text = "Unable to open album";
            }

            dataGridViewPhotoAlbum.DataSource = null;
            dataGridViewPhotoAlbum.DataSource = _album;

            if (_album.Count == 0)
                _album.Add(new Photograph(""));

            var bm = BindingContext[_album];
            var cm = bm as CurrencyManager;
            if(cm!=null)    
                cm.Refresh();
            EnablePhotoButtons(bm);
        }

        private void SaveChanges()
        {
            if(_album.HasPhotoEdits)
            {
                var ans = MessageBox.Show("Do you wish to save your changes to the album\'" + _album.Title + "\'?",
                                          "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ans==DialogResult.Yes)
                    _album.Save();
            }
        }

        private void MyAlbumDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindingContext[_album].EndCurrentEdit();
            SaveChanges();
        }

        private void EnablePhotoButtons(BindingManagerBase bm)
        {
            buttonNext.Enabled = bm.Position < _album.Count - 1;
            buttonPrevious.Enabled = bm.Position > 0;

            pictureBoxPhoto.Invalidate();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var bm = BindingContext[_album];
            if (bm.Position < bm.Count - 1)
                bm.Position++;
            EnablePhotoButtons(bm);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            var bm = BindingContext[_album];
            if (bm.Position > 0)
                bm.Position--;
            EnablePhotoButtons(bm);
        }

        private void pictureBoxPhoto_Paint(object sender, PaintEventArgs e)
        {
            var image = pictureBoxPhoto.Tag as Bitmap;
            if(image==null)
            {
                e.Graphics.Clear(SystemColors.Control);
                return;
            }

            var bm = BindingContext[_album];
            var photo = bm.Current as Photograph;

            var rect = pictureBoxPhoto.ClientRectangle;
            e.Graphics.DrawImage(image, photo == null ? rect : photo.ScaleToFit(rect));
        }
    }
}
