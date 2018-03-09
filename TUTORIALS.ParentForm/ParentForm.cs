using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformTutorials;

namespace TUTORIALS.ParentForm
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void menuFile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var newChild = new MyPhotos {MdiParent = this};
            newChild.Show();
        }
    }
}
