using System;
using System.IO;
using System.Windows.Forms;
using TUTORIALS.Library;

namespace TUTORIALS.MyAlbumData
{
    public partial class MyAlbumDataForm : Form
    {
        private PhotoAlbum _album;

        public MyAlbumDataForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MyAlbumDataForm_Load(object sender, EventArgs e)
        {
            var ver = new Version(Application.ProductVersion);
            Text = string.Format("MyAlbumData {0:#}.{1:#}", ver.Major, ver.Minor);
            _album = new PhotoAlbum();
            comboBoxAlbum.DataSource = Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm");
        }
    }
}
