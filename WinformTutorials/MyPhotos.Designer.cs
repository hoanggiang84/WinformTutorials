namespace WinformTutorials
{
    partial class MyPhotos
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
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActualSize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.contextMenuView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextImage = new System.Windows.Forms.ToolStripMenuItem();
            this.contextStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.contextActual = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusZoomFactor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFileIndex = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextNext = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.contextMenuView.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.editToolStripMenuItem,
            this.menuView});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(396, 24);
            this.menuStripMainMenu.TabIndex = 0;
            this.menuStripMainMenu.Text = "MainMenu";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.toolStripSeparator1,
            this.menuSave,
            this.menuSaveAs,
            this.toolStripSeparator2,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(152, 22);
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(146, 22);
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(152, 22);
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(152, 22);
            this.menuSaveAs.Text = "Save &As";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(146, 22);
            this.menuExit.Text = "&Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuRemove});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuAdd.Size = new System.Drawing.Size(158, 22);
            this.menuAdd.Text = "&Add";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuRemove
            // 
            this.menuRemove.Name = "menuRemove";
            this.menuRemove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuRemove.Size = new System.Drawing.Size(158, 22);
            this.menuRemove.Text = "&Remove";
            this.menuRemove.Click += new System.EventHandler(this.menuRemove_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage,
            this.toolStripSeparator3,
            this.menuNext,
            this.menuPrevious});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            // 
            // menuImage
            // 
            this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStretch,
            this.menuActualSize,
            this.menuCenter});
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(192, 22);
            this.menuImage.Text = "&Image";
            // 
            // menuStretch
            // 
            this.menuStretch.Name = "menuStretch";
            this.menuStretch.Size = new System.Drawing.Size(152, 22);
            this.menuStretch.Text = "S&tretch to Fit";
            this.menuStretch.Click += new System.EventHandler(this.menuStretch_Click);
            // 
            // menuActualSize
            // 
            this.menuActualSize.Name = "menuActualSize";
            this.menuActualSize.Size = new System.Drawing.Size(152, 22);
            this.menuActualSize.Text = "&Actual Size";
            this.menuActualSize.Click += new System.EventHandler(this.menuActualSize_Click);
            // 
            // menuCenter
            // 
            this.menuCenter.Name = "menuCenter";
            this.menuCenter.Size = new System.Drawing.Size(152, 22);
            this.menuCenter.Text = "&Center Image";
            this.menuCenter.Click += new System.EventHandler(this.menuCenter_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(189, 6);
            // 
            // menuNext
            // 
            this.menuNext.Name = "menuNext";
            this.menuNext.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menuNext.Size = new System.Drawing.Size(192, 22);
            this.menuNext.Text = "&Next";
            this.menuNext.Click += new System.EventHandler(this.menuNext_Click);
            // 
            // menuPrevious
            // 
            this.menuPrevious.Name = "menuPrevious";
            this.menuPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.menuPrevious.Size = new System.Drawing.Size(192, 22);
            this.menuPrevious.Text = "&Previous";
            this.menuPrevious.Click += new System.EventHandler(this.menuPrevious_Click);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxPhoto.ContextMenuStrip = this.contextMenuView;
            this.pbxPhoto.Location = new System.Drawing.Point(12, 27);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(372, 301);
            this.pbxPhoto.TabIndex = 1;
            this.pbxPhoto.TabStop = false;
            // 
            // contextMenuView
            // 
            this.contextMenuView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextImage,
            this.toolStripSeparator4,
            this.contextNext,
            this.contextPrevious});
            this.contextMenuView.Name = "contextMenuView";
            this.contextMenuView.Size = new System.Drawing.Size(120, 76);
            // 
            // contextImage
            // 
            this.contextImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextStretch,
            this.contextActual,
            this.contextCenter});
            this.contextImage.Name = "contextImage";
            this.contextImage.Size = new System.Drawing.Size(152, 22);
            this.contextImage.Text = "&Image";
            // 
            // contextStretch
            // 
            this.contextStretch.Name = "contextStretch";
            this.contextStretch.Size = new System.Drawing.Size(152, 22);
            this.contextStretch.Text = "Stretch to Fit";
            this.contextStretch.Click += new System.EventHandler(this.menuStretch_Click);
            // 
            // contextActual
            // 
            this.contextActual.Name = "contextActual";
            this.contextActual.Size = new System.Drawing.Size(152, 22);
            this.contextActual.Text = "Actual Size";
            this.contextActual.Click += new System.EventHandler(this.menuActualSize_Click);
            // 
            // contextCenter
            // 
            this.contextCenter.Name = "contextCenter";
            this.contextCenter.Size = new System.Drawing.Size(152, 22);
            this.contextCenter.Text = "Center Image";
            this.contextCenter.Click += new System.EventHandler(this.menuCenter_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus,
            this.statusImageSize,
            this.statusFileIndex,
            this.statusZoomFactor});
            this.statusStrip.Location = new System.Drawing.Point(0, 331);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(396, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelStatus.Size = new System.Drawing.Size(49, 17);
            this.labelStatus.Text = "Ready";
            // 
            // statusImageSize
            // 
            this.statusImageSize.Name = "statusImageSize";
            this.statusImageSize.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.statusImageSize.Size = new System.Drawing.Size(10, 17);
            // 
            // statusZoomFactor
            // 
            this.statusZoomFactor.Name = "statusZoomFactor";
            this.statusZoomFactor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.statusZoomFactor.Size = new System.Drawing.Size(10, 17);
            // 
            // statusFileIndex
            // 
            this.statusFileIndex.Name = "statusFileIndex";
            this.statusFileIndex.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.statusFileIndex.Size = new System.Drawing.Size(10, 17);
            // 
            // contextNext
            // 
            this.contextNext.Name = "contextNext";
            this.contextNext.Size = new System.Drawing.Size(152, 22);
            this.contextNext.Text = "&Next";
            this.contextNext.Click += new System.EventHandler(this.menuNext_Click);
            // 
            // contextPrevious
            // 
            this.contextPrevious.Name = "contextPrevious";
            this.contextPrevious.Size = new System.Drawing.Size(152, 22);
            this.contextPrevious.Text = "&Previous";
            this.contextPrevious.Click += new System.EventHandler(this.menuPrevious_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // MyPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 353);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.menuStripMainMenu);
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "MyPhotos";
            this.Text = "My Photo";
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.contextMenuView.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuImage;
        private System.Windows.Forms.ToolStripMenuItem menuStretch;
        private System.Windows.Forms.ToolStripMenuItem menuActualSize;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.ToolStripMenuItem menuCenter;
        private System.Windows.Forms.ContextMenuStrip contextMenuView;
        private System.Windows.Forms.ToolStripMenuItem contextImage;
        private System.Windows.Forms.ToolStripMenuItem contextStretch;
        private System.Windows.Forms.ToolStripMenuItem contextActual;
        private System.Windows.Forms.ToolStripMenuItem contextCenter;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusImageSize;
        private System.Windows.Forms.ToolStripStatusLabel statusZoomFactor;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuRemove;
        private System.Windows.Forms.ToolStripMenuItem menuNext;
        private System.Windows.Forms.ToolStripMenuItem menuPrevious;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel statusFileIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem contextNext;
        private System.Windows.Forms.ToolStripMenuItem contextPrevious;


    }
}

