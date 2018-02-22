using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTORIALS.Library;

namespace TUTORIALS.MyAlbumEditor
{
    public partial class MainForm : Form
    {
        private PhotoAlbum _album;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            _album = new PhotoAlbum();
            base.OnLoad(e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
