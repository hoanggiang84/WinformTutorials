using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTutorials
{
    public partial class PixelDlg : Form
    {
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
