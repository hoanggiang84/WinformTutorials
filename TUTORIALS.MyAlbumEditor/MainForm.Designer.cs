namespace TUTORIALS.MyAlbumEditor
{
    partial class MainForm
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
            this.groupBoxAlbums = new System.Windows.Forms.GroupBox();
            this.groupBoxPhotographs = new System.Windows.Forms.GroupBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.groupBoxAlbums.SuspendLayout();
            this.groupBoxPhotographs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlbums
            // 
            this.groupBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAlbums.Controls.Add(this.buttonOpen);
            this.groupBoxAlbums.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAlbums.Name = "groupBoxAlbums";
            this.groupBoxAlbums.Size = new System.Drawing.Size(360, 61);
            this.groupBoxAlbums.TabIndex = 0;
            this.groupBoxAlbums.TabStop = false;
            this.groupBoxAlbums.Text = "&Albums";
            // 
            // groupBoxPhotographs
            // 
            this.groupBoxPhotographs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPhotographs.Controls.Add(this.listBoxPhotos);
            this.groupBoxPhotographs.Location = new System.Drawing.Point(12, 79);
            this.groupBoxPhotographs.Name = "groupBoxPhotographs";
            this.groupBoxPhotographs.Size = new System.Drawing.Size(360, 137);
            this.groupBoxPhotographs.TabIndex = 1;
            this.groupBoxPhotographs.TabStop = false;
            this.groupBoxPhotographs.Text = "&Photographs";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(285, 19);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(69, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "&Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClose.Location = new System.Drawing.Point(155, 227);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(69, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.Location = new System.Drawing.Point(6, 19);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(256, 108);
            this.listBoxPhotos.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxPhotographs);
            this.Controls.Add(this.groupBoxAlbums);
            this.Name = "MainForm";
            this.Text = "MyAlbumEditor";
            this.groupBoxAlbums.ResumeLayout(false);
            this.groupBoxPhotographs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlbums;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBoxPhotographs;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.Button buttonClose;
    }
}

