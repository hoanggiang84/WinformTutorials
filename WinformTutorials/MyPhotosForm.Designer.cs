namespace WinformTutorials
{
    partial class MyPhotosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPhotosForm));
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPhotoProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.albumPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActualSize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScaleToFit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPixel = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextImage = new System.Windows.Forms.ToolStripMenuItem();
            this.contextStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.contextActual = new System.Windows.Forms.ToolStripMenuItem();
            this.contextScale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.contextNext = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFileIndex = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusZoomFactor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonImages = new System.Windows.Forms.ToolStripDropDownButton();
            this.scaleToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPixelData = new System.Windows.Forms.ToolStripButton();
            this.menuStripMainMenu.SuspendLayout();
            this.contextMenuView.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(396, 24);
            this.menuStripMainMenu.TabIndex = 0;
            this.menuStripMainMenu.Text = "MainMenu";
            this.menuStripMainMenu.Visible = false;
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
            this.menuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuFile.MergeIndex = 0;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuNew.MergeIndex = 0;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(152, 22);
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuOpen.MergeIndex = 1;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(152, 22);
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 3;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuSave
            // 
            this.menuSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.menuSave.MergeIndex = 4;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(152, 22);
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.menuSaveAs.MergeIndex = 5;
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(152, 22);
            this.menuSaveAs.Text = "Save &As";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator2.MergeIndex = 6;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuExit
            // 
            this.menuExit.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.menuExit.MergeIndex = 2;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "&Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuRemove,
            this.toolStripSeparator5,
            this.menuPhotoProperties,
            this.albumPropertiesToolStripMenuItem});
            this.menuEdit.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.menuEdit.MergeIndex = 1;
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.DropDownOpening += new System.EventHandler(this.menuEdit_DropDownOpening);
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuAdd.Size = new System.Drawing.Size(175, 22);
            this.menuAdd.Text = "&Add";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuRemove
            // 
            this.menuRemove.Name = "menuRemove";
            this.menuRemove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuRemove.Size = new System.Drawing.Size(175, 22);
            this.menuRemove.Text = "&Remove";
            this.menuRemove.Click += new System.EventHandler(this.menuRemove_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
            // 
            // menuPhotoProperties
            // 
            this.menuPhotoProperties.Enabled = false;
            this.menuPhotoProperties.Name = "menuPhotoProperties";
            this.menuPhotoProperties.Size = new System.Drawing.Size(175, 22);
            this.menuPhotoProperties.Text = "&Photo Properties...";
            this.menuPhotoProperties.Click += new System.EventHandler(this.menuPhotoPro_Click);
            // 
            // albumPropertiesToolStripMenuItem
            // 
            this.albumPropertiesToolStripMenuItem.Name = "albumPropertiesToolStripMenuItem";
            this.albumPropertiesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.albumPropertiesToolStripMenuItem.Text = "A&lbum Properties...";
            this.albumPropertiesToolStripMenuItem.Click += new System.EventHandler(this.albumPropertiesToolStripMenuItem_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage,
            this.toolStripSeparator3,
            this.menuNext,
            this.menuPrevious,
            this.toolStripSeparator6,
            this.menuPixel});
            this.menuView.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.menuView.MergeIndex = 2;
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            // 
            // menuImage
            // 
            this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStretch,
            this.menuActualSize,
            this.menuScaleToFit});
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(192, 22);
            this.menuImage.Text = "&Image";
            // 
            // menuStretch
            // 
            this.menuStretch.Name = "menuStretch";
            this.menuStretch.Size = new System.Drawing.Size(141, 22);
            this.menuStretch.Text = "S&tretch to Fit";
            this.menuStretch.Click += new System.EventHandler(this.menuStretch_Click);
            // 
            // menuActualSize
            // 
            this.menuActualSize.Name = "menuActualSize";
            this.menuActualSize.Size = new System.Drawing.Size(141, 22);
            this.menuActualSize.Text = "&Actual Size";
            this.menuActualSize.Click += new System.EventHandler(this.menuActualSize_Click);
            // 
            // menuScaleToFit
            // 
            this.menuScaleToFit.Name = "menuScaleToFit";
            this.menuScaleToFit.Size = new System.Drawing.Size(141, 22);
            this.menuScaleToFit.Text = "S&cale to Fit";
            this.menuScaleToFit.Click += new System.EventHandler(this.menuScaleToFit_Click);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(189, 6);
            // 
            // menuPixel
            // 
            this.menuPixel.Name = "menuPixel";
            this.menuPixel.Size = new System.Drawing.Size(192, 22);
            this.menuPixel.Text = "Pi&xel Data...";
            this.menuPixel.Click += new System.EventHandler(this.menuPixel_Click);
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
            this.contextScale});
            this.contextImage.Name = "contextImage";
            this.contextImage.Size = new System.Drawing.Size(119, 22);
            this.contextImage.Text = "&Image";
            // 
            // contextStretch
            // 
            this.contextStretch.Name = "contextStretch";
            this.contextStretch.Size = new System.Drawing.Size(141, 22);
            this.contextStretch.Text = "Stretch to Fit";
            this.contextStretch.Click += new System.EventHandler(this.menuStretch_Click);
            // 
            // contextActual
            // 
            this.contextActual.Name = "contextActual";
            this.contextActual.Size = new System.Drawing.Size(141, 22);
            this.contextActual.Text = "Actual Size";
            this.contextActual.Click += new System.EventHandler(this.menuActualSize_Click);
            // 
            // contextScale
            // 
            this.contextScale.Name = "contextScale";
            this.contextScale.Size = new System.Drawing.Size(141, 22);
            this.contextScale.Text = "Scale to Fit";
            this.contextScale.Click += new System.EventHandler(this.menuScaleToFit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(116, 6);
            // 
            // contextNext
            // 
            this.contextNext.Name = "contextNext";
            this.contextNext.Size = new System.Drawing.Size(119, 22);
            this.contextNext.Text = "&Next";
            this.contextNext.Click += new System.EventHandler(this.menuNext_Click);
            // 
            // contextPrevious
            // 
            this.contextPrevious.Name = "contextPrevious";
            this.contextPrevious.Size = new System.Drawing.Size(119, 22);
            this.contextPrevious.Text = "&Previous";
            this.contextPrevious.Click += new System.EventHandler(this.menuPrevious_Click);
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
            // statusFileIndex
            // 
            this.statusFileIndex.Name = "statusFileIndex";
            this.statusFileIndex.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.statusFileIndex.Size = new System.Drawing.Size(10, 17);
            // 
            // statusZoomFactor
            // 
            this.statusZoomFactor.Name = "statusZoomFactor";
            this.statusZoomFactor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.statusZoomFactor.Size = new System.Drawing.Size(10, 17);
            // 
            // panelImage
            // 
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(0, 24);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(396, 307);
            this.panelImage.TabIndex = 3;
            this.panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImage_Paint);
            this.panelImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelImage_MouseDown);
            this.panelImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelImage_MouseMove);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator7,
            this.toolStripButtonPrevious,
            this.toolStripButtonNext,
            this.toolStripSeparator8,
            this.toolStripDropDownButtonImages,
            this.toolStripSeparator9,
            this.toolStripButtonPixelData});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(396, 25);
            this.toolStripMain.TabIndex = 4;
            this.toolStripMain.Visible = false;
            this.toolStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMain_ItemClicked);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "Create album";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "Open album";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Save album";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPrevious
            // 
            this.toolStripButtonPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrevious.Image")));
            this.toolStripButtonPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrevious.Name = "toolStripButtonPrevious";
            this.toolStripButtonPrevious.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrevious.Text = "Previous image";
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNext.Image")));
            this.toolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNext.Text = "Next image";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButtonImages
            // 
            this.toolStripDropDownButtonImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonImages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleToFitToolStripMenuItem,
            this.stretchToFitToolStripMenuItem,
            this.actualSizeToolStripMenuItem});
            this.toolStripDropDownButtonImages.Image = global::WinformTutorials.Properties.Resources.album1;
            this.toolStripDropDownButtonImages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonImages.Name = "toolStripDropDownButtonImages";
            this.toolStripDropDownButtonImages.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButtonImages.Text = "Album";
            // 
            // scaleToFitToolStripMenuItem
            // 
            this.scaleToFitToolStripMenuItem.Name = "scaleToFitToolStripMenuItem";
            this.scaleToFitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scaleToFitToolStripMenuItem.Text = "&Scale to Fit";
            // 
            // stretchToFitToolStripMenuItem
            // 
            this.stretchToFitToolStripMenuItem.Name = "stretchToFitToolStripMenuItem";
            this.stretchToFitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.stretchToFitToolStripMenuItem.Text = "S&tretch to Fit";
            // 
            // actualSizeToolStripMenuItem
            // 
            this.actualSizeToolStripMenuItem.Name = "actualSizeToolStripMenuItem";
            this.actualSizeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.actualSizeToolStripMenuItem.Text = "&Actual Size";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPixelData
            // 
            this.toolStripButtonPixelData.CheckOnClick = true;
            this.toolStripButtonPixelData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPixelData.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPixelData.Image")));
            this.toolStripButtonPixelData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPixelData.Name = "toolStripButtonPixelData";
            this.toolStripButtonPixelData.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPixelData.Text = "Show pixel data";
            this.toolStripButtonPixelData.Click += new System.EventHandler(this.toolStripButtonPixelData_Click);
            // 
            // MyPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 353);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "MyPhotos";
            this.Text = "My Photo";
            this.Deactivate += new System.EventHandler(this.MyPhotos_Deactivate);
            this.Load += new System.EventHandler(this.MyPhotos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyPhotos_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyPhotos_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MyPhotos_PreviewKeyDown);
            this.Resize += new System.EventHandler(this.MyPhotos_Resize);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.contextMenuView.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuImage;
        private System.Windows.Forms.ToolStripMenuItem menuStretch;
        private System.Windows.Forms.ToolStripMenuItem menuActualSize;
        private System.Windows.Forms.ToolStripMenuItem menuScaleToFit;
        private System.Windows.Forms.ContextMenuStrip contextMenuView;
        private System.Windows.Forms.ToolStripMenuItem contextImage;
        private System.Windows.Forms.ToolStripMenuItem contextStretch;
        private System.Windows.Forms.ToolStripMenuItem contextActual;
        private System.Windows.Forms.ToolStripMenuItem contextScale;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusImageSize;
        private System.Windows.Forms.ToolStripStatusLabel statusZoomFactor;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuRemove;
        private System.Windows.Forms.ToolStripMenuItem menuNext;
        private System.Windows.Forms.ToolStripMenuItem menuPrevious;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel statusFileIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem contextNext;
        private System.Windows.Forms.ToolStripMenuItem contextPrevious;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuPhotoProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menuPixel;
        private System.Windows.Forms.ToolStripMenuItem albumPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrevious;
        private System.Windows.Forms.ToolStripButton toolStripButtonNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonImages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButtonPixelData;
        private System.Windows.Forms.ToolStripMenuItem scaleToFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStrip toolStripMain;


    }
}

