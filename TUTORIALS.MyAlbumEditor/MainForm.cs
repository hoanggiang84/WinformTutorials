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
        private static Rectangle _drawRect = new Rectangle(0, 0, 45, 45);
        private static SolidBrush _textBrush = new SolidBrush(SystemColors.WindowText);

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
            UpdatePhotographs();
        }

        private void UpdatePhotographs()
        {
            if(tabControlPhotos.SelectedTab == tabPagePhotos)
                UpdateList();
            else
                UpdateCalender();
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
            if (_album.Count == 0 || listBoxPhotos.SelectedIndex < 0) return;

            if (DisplayPhotoEditDlg(listBoxPhotos.SelectedIndex))
                UpdateList();
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
                tabControlPhotos.Enabled = true;
                buttonAlbumProperties.Enabled = true;
                listBoxPhotos.BackColor = SystemColors.Window;
            }
            catch (Exception)
            {
                Text = "Unable to open selected album";
                listBoxPhotos.Items.Clear();
                listBoxPhotos.BackColor = SystemColors.Control;
                tabControlPhotos.Enabled = false;
                monthCalendarPhotoDate.RemoveAllBoldedDates();
                buttonAlbumProperties.Enabled = false;
            }
        }

        private void menuThumbs_Click(object sender, EventArgs e)
        {
            menuThumbs.Checked = !menuThumbs.Checked;
            if(menuThumbs.Checked)
            {
                listBoxPhotos.DrawMode = DrawMode.OwnerDrawVariable;
            }
            else
            {
                listBoxPhotos.DrawMode = DrawMode.Normal;
                listBoxPhotos.ItemHeight = listBoxPhotos.Font.Height + 2;
            }
        }

        private void listBoxPhotos_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            var p = _album[e.Index];
            var scaledRect = p.ScaleToFit(_drawRect);

            e.ItemHeight = Math.Max(scaledRect.Height, listBoxPhotos.Font.Height) + 2;
            e.ItemWidth = scaledRect.Width + 2 + (int) e.Graphics.MeasureString(p.Caption, listBoxPhotos.Font).Width;
        }

        private void listBoxPhotos_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var p = _album[e.Index];

            var scaledRect = p.ScaleToFit(_drawRect);
            var imageRect = e.Bounds;
            imageRect.Y += 1;
            imageRect.Height = scaledRect.Height;
            imageRect.X += 2;
            imageRect.Width = scaledRect.Width;

            g.DrawImage(p.Thumbnail, imageRect);
            g.DrawRectangle(Pens.Black, imageRect);

            var textRect = new Rectangle(imageRect.Right + 2, imageRect.Y + ((imageRect.Height - e.Font.Height)/2),
                                         e.Bounds.Width - imageRect.Width - 4, e.Font.Height);

            if((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                _textBrush.Color = SystemColors.Highlight;
                g.FillRectangle(_textBrush, textRect);
                _textBrush.Color = SystemColors.HighlightText;
            }
            else
            {
                _textBrush.Color = SystemColors.Window;
                g.FillRectangle(_textBrush,textRect);
                _textBrush.Color = SystemColors.WindowText;
            }

            g.DrawString(p.Caption, e.Font, _textBrush, textRect);
        }

        private void imagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imagesDlg = new Form();
            var tcImages = new TabControl();

            imagesDlg.SuspendLayout();
            tcImages.SuspendLayout();

            foreach (Photograph photograph in _album)
            {
                var shortFileName = Path.GetFileName(photograph.FileName);
                var newPage = new TabPage(shortFileName);
                newPage.SuspendLayout();
                var pbox = new PictureBox
                               {
                                   BorderStyle = BorderStyle.Fixed3D,
                                   Dock = DockStyle.Fill,
                                   Image = photograph.Image,
                                   SizeMode = PictureBoxSizeMode.StretchImage
                               };
                newPage.Controls.Add(pbox);
                newPage.ToolTipText = photograph.FileName;
                tcImages.Controls.Add(newPage);
                newPage.ResumeLayout();
            }

            tcImages.Dock = DockStyle.Fill;
            tcImages.HotTrack = true;
            tcImages.ShowToolTips = true;

            imagesDlg.Controls.Add(tcImages);
            imagesDlg.ShowInTaskbar = false;
            imagesDlg.Size = new Size(400,300);
            imagesDlg.Text = "Images in " + Path.GetFileName(_album.FileName);

            tcImages.ResumeLayout();
            imagesDlg.ResumeLayout();
            imagesDlg.ShowDialog();
            imagesDlg.Dispose();
        }

        private void UpdateCalender()
        {
            var minDate = DateTime.MaxValue;
            var maxDate = DateTime.MinValue;

            var dates = new DateTime[_album.Count];
            for (int i = 0; i < _album.Count; i++)
            {
                var newDate = _album[i].DateTaken;
                dates[i] = newDate;
                if (newDate < minDate)
                    minDate = newDate;

                if (newDate > maxDate)
                    maxDate = newDate;
            }

            if(_album.Count>0)
            {
                monthCalendarPhotoDate.BoldedDates = dates;
                monthCalendarPhotoDate.MinDate = minDate;
                monthCalendarPhotoDate.MaxDate = maxDate;
                monthCalendarPhotoDate.SelectionStart = minDate;
            }
        }

        private void tabControlPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePhotographs();
        }

        private void monthCalendarPhotoDate_MouseDown(object sender, MouseEventArgs e)
        {
            var info = monthCalendarPhotoDate.HitTest(e.X, e.Y);
            if(info.HitArea == MonthCalendar.HitArea.Date)
            {
                var photoMenu = new ContextMenuStrip();
                for (int i = 0; i < _album.Count; i++)
                {
                    if(_album[i].DateTaken.Date == info.Time.Date)
                    {
                        var newPhotoItem = new ToolStripMenuItem()
                                               {
                                                   Tag = 1,
                                                   Text = _album[i].FileName
                                               };
                        newPhotoItem.Click += newPhotoItem_Click;
                        photoMenu.Items.Add(newPhotoItem);
                    }
                }

                if(photoMenu.Items.Count>=1)
                    photoMenu.Show(monthCalendarPhotoDate, new Point(e.X,e.Y));
            }
        }

        private void newPhotoItem_Click(object sender, EventArgs e)
        {
            var mi = sender as ToolStripMenuItem;
            if (mi != null && DisplayPhotoEditDlg((int)mi.Tag))
                UpdateCalender();
        }

        private bool DisplayPhotoEditDlg(int index)
        {
            _album.CurrentPosition = index;
            using (var dlg = new PhotoEditDlg(_album))
                return (dlg.ShowDialog() == DialogResult.OK);
        }
    }
}
