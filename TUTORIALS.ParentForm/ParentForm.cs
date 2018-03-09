using System;
using System.Windows.Forms;
using TUTORIALS.Library;
using WinformTutorials;

namespace TUTORIALS.ParentForm
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            var newChild = new MyPhotos {MdiParent = this};
            newChild.Show();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog
            {
                Title = "Open Album",
                Filter = "abm files(*.abm)|*.abm|All files(*.*)|*.*",
                InitialDirectory = PhotoAlbum.DefaultDir,
                RestoreDirectory = true
            })
            {
                if(dlg.ShowDialog()== DialogResult.OK)
                {
                    try
                    {
                        foreach (Form f in MdiChildren)
                        {
                            var mf = f as MyPhotos;
                            if (mf != null)
                            {
                                if(mf.AlbumFile == dlg.FileName)
                                {
                                    if(mf.WindowState == FormWindowState.Minimized)
                                    {
                                        mf.WindowState = FormWindowState.Normal;
                                    }
                                    mf.BringToFront();
                                    return;
                                }
                            }
                        }

                        var form = new MyPhotos(dlg.FileName) {MdiParent = this};
                        form.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to open file" + dlg.FileName + "\n (" + ex.Message + ")",
                                        "Open Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ParentForm_MdiChildActivate(object sender, EventArgs e)
        {
            var child = ActiveMdiChild as MyPhotos;
            if(child != null)
            {
                ToolStripManager.Merge(child.toolStripMain, toolStripParent);
                toolStripParent.Show();
                child.toolStripMain.Hide();
                child.FormClosing += delegate
                                         {
                                             child.toolStripMain.Show();
                                             ToolStripManager.RevertMerge(toolStripParent);
                                             toolStripParent.Items.Clear();
                                             toolStripParent.Hide();
                                         };
            }
        }

        private void toolStripParent_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var menuButton = e.ClickedItem.Tag as ToolStripMenuItem;
            if (menuButton != null)
                menuButton.PerformClick();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            PixelDlg.GlobalMdiParent = this;
        }
    }
}
