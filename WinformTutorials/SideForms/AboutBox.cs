using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

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

        private void AboutBox_Load(object sender, System.EventArgs e)
        {
            int BrowserVer, RegVal;

            // get the installed IE version
            using (var Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;

            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key
            using (RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree))
                if (Key.GetValue(Process.GetCurrentProcess().ProcessName + ".exe") == null)
                    Key.SetValue(Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
        }

        private void labelIcon_Click(object sender, EventArgs e)
        {
            linkLabelSite_LinkClicked(sender, null);
        }
    }
}
