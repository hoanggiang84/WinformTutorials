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
            if(comboBoxPhotographer.Items.Count == 0)
            {
                comboBoxPhotographer.BeginUpdate();
                comboBoxPhotographer.Items.Clear();
                comboBoxPhotographer.Items.Add("unknown");

                foreach (Photograph p in _album)
                {
                    if (p.Photographer != null
                        && !comboBoxPhotographer.Items.Contains(p.Photographer))
                    {
                        comboBoxPhotographer.Items.Add(p.Photographer);
                    } 
                }

                comboBoxPhotographer.EndUpdate();
            }

            var photo = _album.CurrentPhoto;
            if(photo!=null)
            {
                textBoxPhotoFile.Text = photo.FileName;
                textBoxCaption.Text = photo.Caption;
                textBoxDateTaken.Text = photo.DateTaken.ToString();
                textBoxNotes.Text = photo.Notes;
                comboBoxPhotographer.SelectedItem = photo.Photographer;
            }

            base.ResetSettings();
        }

        protected override bool SaveSettings()
        {
            var photo = _album.CurrentPhoto;
            if(photo!=null)
            {
                photo.Caption = textBoxCaption.Text;
                photo.Photographer = comboBoxPhotographer.Text;
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

        private void comboBoxPhotographer_Validated(object sender, EventArgs e)
        {
            var pg = comboBoxPhotographer.Text;
            if(!comboBoxPhotographer.Items.Contains(pg))
            {
                _album.CurrentPhoto.Photographer = pg;
                comboBoxPhotographer.Items.Add(pg);
            }
            comboBoxPhotographer.SelectedItem = pg;
        }

        private void comboBoxPhotographer_TextChanged(object sender, EventArgs e)
        {
            var text = comboBoxPhotographer.Text;
            var index = comboBoxPhotographer.FindString(text);
            var strFound = index > 0;
            comboBoxPhotographer.DroppedDown = strFound;
            if (strFound)
            {
                var newText = comboBoxPhotographer.Items[index].ToString();
                comboBoxPhotographer.Text = newText;
                comboBoxPhotographer.SelectionStart = text.Length;
                comboBoxPhotographer.SelectionLength = newText.Length - text.Length;
            }
        }

        private void comboBoxPhotographer_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            e.Handled = !(char.IsWhiteSpace(c) || char.IsLetterOrDigit(c) || char.IsControl(c));
        }
    }
}
