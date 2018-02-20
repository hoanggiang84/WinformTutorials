using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUTORIALS.Library.Forms
{
    public partial class BaseEditDlg : Form
    {
        public BaseEditDlg()
        {
            InitializeComponent();
        }

        protected virtual void ResetSettings()
        {
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }

        protected virtual bool SaveSettings()
        {
            return true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if(!e.Cancel && DialogResult == DialogResult.OK)
            {
                e.Cancel = !SaveSettings();
            }
            base.OnClosing(e);
        }
    }
}
