using System;
using System.Windows.Forms;
using TUTORIALS.Library;
using WinformTutorials;
using WinformTutorials.SideForms;

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
            var newChild = new MyPhotosForm {MdiParent = this};
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
                            var mf = f as MyPhotosForm;
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

                        var form = new MyPhotosForm(dlg.FileName) {MdiParent = this};
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
            var child = ActiveMdiChild as MyPhotosForm;
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
            SetTitleBar();
        }

        private void SetTitleBar()
        {
            var ver = new Version(Application.ProductVersion);
            var titleBar = "{0} - MyPhotos MDI {1:#}.{2:#}";
            if(ActiveMdiChild is MyPhotosForm)
            {
                var albumTitle = ((MyPhotosForm) ActiveMdiChild).AlbumTitle;
                Text = string.Format(titleBar, albumTitle, ver.Major, ver.Minor);
            }
            else if (ActiveMdiChild is PixelDlg)
            {
                Text = string.Format(titleBar, "Pixel Data", ver.Major, ver.Minor);
            }
            else
            {
                Text = string.Format("MyPhotos MDI {0:#}.{1:#}", ver.Major, ver.Minor);
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
            SetTitleBar();
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuPageSetup_Click(object sender, EventArgs e)
        {
            var dlg = new PageSetupDialog{ Document = printDoc };
            dlg.ShowDialog();
        }

        private void menuPrintPreview_Click(object sender, EventArgs e)
        {
            var dlg = new PrintPreviewDialog{ Document = printDoc };
            dlg.ShowDialog();
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var f = ActiveMdiChild as MyPhotosForm;
            if (f != null)
                f.PrintCurrentImage(e);
            else 
                e.Cancel = true;
        }

        private void menuPrint_Click(object sender, EventArgs e)
        {
            var dlg = new PrintDialog {Document = printDoc};
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            var ver = new Version(Application.ProductVersion);
            var dlg = new AboutBox
            {
                IsMdiApplication = true,
                AboutText = string.Format("MyPhotos (MDI) Application, Version {0:#}.{1:#}\n" +
                                          "Sample for \"Windows Forms Programming with C#\"\n" +
                                          "by Erik Brown\nCopyright (C) 2001 Manning Publications Co.", ver.Major, ver.Minor),
                Owner = this,
                Icon = Icon
            };

            dlg.Show();
        }
    }
}
