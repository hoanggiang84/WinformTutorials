using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUTORIALS.Library;

namespace WinformTutorials.SideForms
{
    public partial class AlbumEditDlg : SideForms.BaseEditDlg
    {
        private PhotoAlbum _album;
        public AlbumEditDlg(PhotoAlbum album)
        {
            InitializeComponent();
            radioButtonCaption.Tag = (int) DisplayValEnum.Caption;
            radioButtonDate.Tag = (int) DisplayValEnum.Date;
            radioButtonFilename.Tag = (int) DisplayValEnum.FileName;
            _album = album;
            ResetSettings();
        }

        protected override void ResetSettings()
        {
            textBoxAlbumFile.Text = _album.FileName;
            textBoxTitle.Text = _album.Title;
            Text = string.Format("{0} - Album Properties", textBoxTitle.Text);

            _selectedDisplayOption = _album.DisplayOption;
            switch (_selectedDisplayOption)
            {
                case DisplayValEnum.FileName:
                    radioButtonFilename.Checked = true;
                    break;
                case DisplayValEnum.Date:
                    radioButtonDate.Checked = true;
                    break;
                default:
                case DisplayValEnum.Caption:
                    radioButtonCaption.Checked = true;
                    break;
            }

            var passWd = _album.Password;
            checkBoxRequiredPassword.Checked = !string.IsNullOrEmpty(passWd);
            textBoxPassword.Text = passWd;
            textBoxConfrimPassword.Text = passWd;
        }

        protected override bool SaveSettings()
        {
            var valid = ValidPasswords();

            if(valid)
            {
                _album.Title = textBoxTitle.Text;
                _album.DisplayOption = _selectedDisplayOption;
                _album.Password = checkBoxRequiredPassword.Checked ? textBoxPassword.Text : null;
            }

            return valid;
        }


        private DisplayValEnum _selectedDisplayOption;

        private void displayOption_Click(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null)
                _selectedDisplayOption = (DisplayValEnum) rb.Tag;
        }

        private void checkBoxRequiredPassword_CheckedChanged(object sender, EventArgs e)
        {
            var enable = checkBoxRequiredPassword.Checked;
            textBoxPassword.Enabled = enable;
            textBoxConfrimPassword.Enabled = enable;
            labelConfirmPassword.Enabled = enable;

            if (enable)
                textBoxPassword.Focus();
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxPassword.TextLength == 0)
            {
                MessageBox.Show(this, "The password for the album cannot be blank", "Invalid Password",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private bool ValidPasswords()
        {
            if(checkBoxRequiredPassword.Checked 
                && textBoxPassword.Text != textBoxConfrimPassword.Text)
            {
                MessageBox.Show(this, "The password and confirm values do not match", "Password Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            Text = string.Format("{0} - Album Properties", textBoxTitle.Text);
        }
    }
}
