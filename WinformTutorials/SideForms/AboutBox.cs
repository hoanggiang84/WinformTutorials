using System.Drawing;
using System.Windows.Forms;

namespace WinformTutorials.SideForms
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        protected const int SDI_ICON = 0;
        protected const int MDI_ICON = 1;

        public bool IsMdiApplication
        {
            get { return labelIcon.ImageIndex == MDI_ICON; }
            set { labelIcon.ImageIndex = value ? MDI_ICON : SDI_ICON; }
        }

        public string AboutText
        {
            get { return labelAboutText.Text; }
            set { labelAboutText.Text = value; }
        }

        private void linkLabelClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }


        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(webBrowserBookSite.Visible)
            {
                Size = new Size(400,170);
                linkLabelSite.Text = "Click book's web site";
                webBrowserBookSite.Hide();
            }
            else
            {
                Size = new Size(600, 400);
                linkLabelSite.Text = "Click to hide web page";
                webBrowserBookSite.Show();
            }
        }
    }
}
