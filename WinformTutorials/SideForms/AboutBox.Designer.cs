namespace WinformTutorials.SideForms
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.labelIcon = new System.Windows.Forms.Label();
            this.labelAboutText = new System.Windows.Forms.Label();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.linkLabelClose = new System.Windows.Forms.LinkLabel();
            this.webBrowserBookSite = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "book_open.png");
            this.imageListIcons.Images.SetKeyName(1, "book_link.png");
            // 
            // labelIcon
            // 
            this.labelIcon.AutoSize = true;
            this.labelIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIcon.ImageIndex = 0;
            this.labelIcon.ImageList = this.imageListIcons;
            this.labelIcon.Location = new System.Drawing.Point(12, 9);
            this.labelIcon.MaximumSize = new System.Drawing.Size(50, 50);
            this.labelIcon.MinimumSize = new System.Drawing.Size(50, 50);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(50, 50);
            this.labelIcon.TabIndex = 0;
            this.labelIcon.Click += new System.EventHandler(this.labelIcon_Click);
            // 
            // labelAboutText
            // 
            this.labelAboutText.AutoSize = true;
            this.labelAboutText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAboutText.Location = new System.Drawing.Point(68, 9);
            this.labelAboutText.MinimumSize = new System.Drawing.Size(300, 60);
            this.labelAboutText.Name = "labelAboutText";
            this.labelAboutText.Size = new System.Drawing.Size(300, 60);
            this.labelAboutText.TabIndex = 1;
            this.labelAboutText.Text = "MyPhotos";
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(12, 81);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(121, 13);
            this.linkLabelSite.TabIndex = 2;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "Click for book\'s web site";
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // linkLabelClose
            // 
            this.linkLabelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelClose.AutoSize = true;
            this.linkLabelClose.Location = new System.Drawing.Point(263, 81);
            this.linkLabelClose.Name = "linkLabelClose";
            this.linkLabelClose.Size = new System.Drawing.Size(109, 13);
            this.linkLabelClose.TabIndex = 3;
            this.linkLabelClose.TabStop = true;
            this.linkLabelClose.Text = "Click to close window";
            this.linkLabelClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClose_LinkClicked);
            // 
            // webBrowserBookSite
            // 
            this.webBrowserBookSite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserBookSite.Location = new System.Drawing.Point(12, 100);
            this.webBrowserBookSite.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserBookSite.Name = "webBrowserBookSite";
            this.webBrowserBookSite.Size = new System.Drawing.Size(360, 20);
            this.webBrowserBookSite.TabIndex = 4;
            this.webBrowserBookSite.Url = new System.Uri("https://www.manning.com/books/windows-forms-programming-with-c-sharp", System.UriKind.Absolute);
            this.webBrowserBookSite.Visible = false;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 132);
            this.Controls.Add(this.webBrowserBookSite);
            this.Controls.Add(this.linkLabelClose);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.labelAboutText);
            this.Controls.Add(this.labelIcon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About MyPhotos";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.Label labelAboutText;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.LinkLabel linkLabelClose;
        private System.Windows.Forms.WebBrowser webBrowserBookSite;
    }
}