using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUTORIALS.Library;
using TUTORIALS.Library.Forms;

namespace TUTORIALS.Library.Forms
{
    public partial class PhotoEditDlg : BaseEditDlg
    {
        private PhotoAlbum _album;

        public PhotoEditDlg(PhotoAlbum album)
        {
            InitializeComponent();

            _album = album;
            ResetSettings();
        }

        protected override void ResetSettings()
        {
            var photo = _album.CurrentPhoto;
            if(photo!=null)
            {
                textBoxPhotoFile.Text = photo.FileName;
                textBoxCaption.Text = photo.Caption;
                textBoxDateTaken.Text = photo.DateTaken.ToString();
                textBoxPhotographer.Text = photo.Photographer;
                textBoxNotes.Text = photo.Notes;
            }

            base.ResetSettings();
        }

        protected override bool SaveSettings()
        {
            var photo = _album.CurrentPhoto;
            if(photo!=null)
            {
                photo.Caption = textBoxCaption.Text;
                photo.Photographer = textBoxPhotographer.Text;
                photo.Notes = textBoxNotes.Text;
                _album.SetAlbumChanged();
            }
            return true;
        }

        private void textBoxCaption_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || char.IsControl(c));
        }

        private void textBoxCaption_TextChanged(object sender, EventArgs e)
        {
            Text = string.Format("{0} - Photo Properties", textBoxCaption.Text);
        }
    }
}
