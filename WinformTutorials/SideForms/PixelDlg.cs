using System;
using System.Windows.Forms;

namespace WinformTutorials
{
    public partial class PixelDlg : Form
    {
        private static Form _mdiForm = null;
        private static PixelDlg _globalDlg;

        public static Form GlobalMdiParent
        {
            get { return _mdiForm; }
            set { _mdiForm = value; }
        }

        public static PixelDlg GlobalDialog
        {
            get
            {
                if (_globalDlg == null || _globalDlg.IsDisposed)
                {
                    _globalDlg = new PixelDlg { MdiParent = GlobalMdiParent };
                }
                return _globalDlg;
            }
        }

        public PixelDlg()
        {
            InitializeComponent();
        }

        public int XVal
        {
            set { textBoxX.Text = value.ToString(); }
        }

        public int YVal
        {
            set { textBoxY.Text = value.ToString(); }
        }

        public int RedVal
        {
            set { textBoxRed.Text = value.ToString(); }

        }

        public int GreenVal
        {
            set { textBoxGreen.Text = value.ToString(); }
        }

        public int BlueVal
        {
            set { textBoxBlue.Text = value.ToString(); }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
