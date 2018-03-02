using System;
using System.Windows.Forms;

namespace TUTORIALS.Library.Forms
{
    public partial class PhotoEditDlg : BaseEditDlg
    {
        private PhotoAlbum _album;
        private int _index;
        private string _origCaption;
        private DateTime _origDateTaken;
        private string _origPhotographer;
        private bool _modifiedTxtNotes;

        public PhotoEditDlg(PhotoAlbum album)
        {
            InitializeComponent();

            _album = album;
            _index = album.CurrentPosition;
            ResetSettings();
            SetOriginals();
        }

        private void SetOriginals()
        {
            var photo = _album[_index];

            if(photo != null)
            {
                _origCaption = photo.Caption;
                _origDateTaken = photo.DateTaken;
                _origPhotographer = photo.Photographer;
                _modifiedTxtNotes = false;
            }
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

            var photo = _album[_index];
            if(photo!=null)
            {
                comboBoxPhotographer.SelectedItem = photo.Photographer;
                comboBoxPhotographer.DroppedDown = false;
                textBoxPhotoFile.Text = photo.FileName;
                textBoxCaption.Text = photo.Caption;
                dtpDateTaken.Value = photo.DateTaken;
                textBoxNotes.Text = photo.Notes;
                buttonPrevious.Enabled = _index > 0;
                buttonNext.Enabled = (_index < _album.Count - 1);
            }

            base.ResetSettings();
        }

        protected override bool SaveSettings()
        {
            if(NewControlValues())
            {
                var photo = _album[_index];
                if (photo != null)
                {
                    photo.Caption = textBoxCaption.Text;
                    photo.Photographer = comboBoxPhotographer.Text;
                    photo.Notes = textBoxNotes.Text;
                    photo.DateTaken = dtpDateTaken.Value;
                    _album.SetAlbumChanged();
                }
            }
            return true;
        }

        private bool NewControlValues()
        {
            return (_origCaption != textBoxCaption.Text
                    || _origDateTaken != dtpDateTaken.Value
                    || _origPhotographer != comboBoxPhotographer.Text
                    || _modifiedTxtNotes);
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
                _album[_index].Photographer = pg;
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

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            SaveSettings();
            if (_index > 0)
            {
                _index--;
                ResetSettings();
                SetOriginals();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            SaveSettings();
            if(_index<_album.Count-1)
            {
                _index++;
                ResetSettings();
                SetOriginals();
            }
        }
    }
}
