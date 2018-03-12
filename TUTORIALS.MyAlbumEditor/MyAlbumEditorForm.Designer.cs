namespace TUTORIALS.MyAlbumEditor
{
    partial class MyAlbumEditorForm
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
            this.groupBoxAlbums = new System.Windows.Forms.GroupBox();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.buttonAlbumProperties = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuThumbs = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlPhotos = new System.Windows.Forms.TabControl();
            this.tabPagePhotos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPhotoCtrl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonPhotoProperties = new System.Windows.Forms.Button();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.tabPageDates = new System.Windows.Forms.TabPage();
            this.monthCalendarPhotoDate = new System.Windows.Forms.MonthCalendar();
            this.groupBoxAlbums.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tabControlPhotos.SuspendLayout();
            this.tabPagePhotos.SuspendLayout();
            this.tableLayoutPanelPhotoCtrl.SuspendLayout();
            this.tabPageDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlbums
            // 
            this.groupBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAlbums.Controls.Add(this.comboBoxAlbums);
            this.groupBoxAlbums.Controls.Add(this.buttonAlbumProperties);
            this.groupBoxAlbums.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAlbums.Name = "groupBoxAlbums";
            this.groupBoxAlbums.Size = new System.Drawing.Size(363, 61);
            this.groupBoxAlbums.TabIndex = 0;
            this.groupBoxAlbums.TabStop = false;
            this.groupBoxAlbums.Text = "&Albums";
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(6, 21);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(259, 21);
            this.comboBoxAlbums.TabIndex = 2;
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged);
            // 
            // buttonAlbumProperties
            // 
            this.buttonAlbumProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlbumProperties.Enabled = false;
            this.buttonAlbumProperties.Location = new System.Drawing.Point(274, 19);
            this.buttonAlbumProperties.Name = "buttonAlbumProperties";
            this.buttonAlbumProperties.Size = new System.Drawing.Size(80, 23);
            this.buttonAlbumProperties.TabIndex = 1;
            this.buttonAlbumProperties.Text = "Properti&es";
            this.buttonAlbumProperties.UseVisualStyleBackColor = true;
            this.buttonAlbumProperties.Click += new System.EventHandler(this.buttonAlbumProperties_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClose.Location = new System.Drawing.Point(156, 261);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(69, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThumbs,
            this.imagesToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(138, 48);
            // 
            // menuThumbs
            // 
            this.menuThumbs.Checked = true;
            this.menuThumbs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuThumbs.Name = "menuThumbs";
            this.menuThumbs.Size = new System.Drawing.Size(137, 22);
            this.menuThumbs.Text = "&Thumbnails";
            this.menuThumbs.Click += new System.EventHandler(this.menuThumbs_Click);
            // 
            // imagesToolStripMenuItem
            // 
            this.imagesToolStripMenuItem.Name = "imagesToolStripMenuItem";
            this.imagesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.imagesToolStripMenuItem.Text = "&Images...";
            this.imagesToolStripMenuItem.Click += new System.EventHandler(this.imagesToolStripMenuItem_Click);
            // 
            // tabControlPhotos
            // 
            this.tabControlPhotos.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPhotos.Controls.Add(this.tabPagePhotos);
            this.tabControlPhotos.Controls.Add(this.tabPageDates);
            this.tabControlPhotos.Location = new System.Drawing.Point(12, 79);
            this.tabControlPhotos.Multiline = true;
            this.tabControlPhotos.Name = "tabControlPhotos";
            this.tabControlPhotos.SelectedIndex = 0;
            this.tabControlPhotos.Size = new System.Drawing.Size(363, 176);
            this.tabControlPhotos.TabIndex = 2;
            this.tabControlPhotos.SelectedIndexChanged += new System.EventHandler(this.tabControlPhotos_SelectedIndexChanged);
            // 
            // tabPagePhotos
            // 
            this.tabPagePhotos.Controls.Add(this.tableLayoutPanelPhotoCtrl);
            this.tabPagePhotos.Controls.Add(this.listBoxPhotos);
            this.tabPagePhotos.Location = new System.Drawing.Point(23, 4);
            this.tabPagePhotos.Name = "tabPagePhotos";
            this.tabPagePhotos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhotos.Size = new System.Drawing.Size(336, 168);
            this.tabPagePhotos.TabIndex = 0;
            this.tabPagePhotos.Text = "Photos";
            this.tabPagePhotos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPhotoCtrl
            // 
            this.tableLayoutPanelPhotoCtrl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanelPhotoCtrl.ColumnCount = 1;
            this.tableLayoutPanelPhotoCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPhotoCtrl.Controls.Add(this.buttonRemove, 0, 2);
            this.tableLayoutPanelPhotoCtrl.Controls.Add(this.buttonMoveDown, 0, 1);
            this.tableLayoutPanelPhotoCtrl.Controls.Add(this.buttonMoveUp, 0, 0);
            this.tableLayoutPanelPhotoCtrl.Controls.Add(this.buttonPhotoProperties, 0, 3);
            this.tableLayoutPanelPhotoCtrl.Location = new System.Drawing.Point(253, 23);
            this.tableLayoutPanelPhotoCtrl.Name = "tableLayoutPanelPhotoCtrl";
            this.tableLayoutPanelPhotoCtrl.RowCount = 4;
            this.tableLayoutPanelPhotoCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPhotoCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPhotoCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPhotoCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPhotoCtrl.Size = new System.Drawing.Size(78, 122);
            this.tableLayoutPanelPhotoCtrl.TabIndex = 3;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(3, 63);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(72, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "&Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveDown.Enabled = false;
            this.buttonMoveDown.Location = new System.Drawing.Point(3, 33);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(72, 23);
            this.buttonMoveDown.TabIndex = 4;
            this.buttonMoveDown.Text = "Move &Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveUp.Enabled = false;
            this.buttonMoveUp.Location = new System.Drawing.Point(3, 3);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(72, 23);
            this.buttonMoveUp.TabIndex = 3;
            this.buttonMoveUp.Text = "Move &Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonPhotoProperties
            // 
            this.buttonPhotoProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPhotoProperties.Enabled = false;
            this.buttonPhotoProperties.Location = new System.Drawing.Point(3, 93);
            this.buttonPhotoProperties.Name = "buttonPhotoProperties";
            this.buttonPhotoProperties.Size = new System.Drawing.Size(72, 23);
            this.buttonPhotoProperties.TabIndex = 2;
            this.buttonPhotoProperties.Text = "Propertie&s";
            this.buttonPhotoProperties.UseVisualStyleBackColor = true;
            this.buttonPhotoProperties.Click += new System.EventHandler(this.buttonPhotoProperties_Click);
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPhotos.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxPhotos.ContextMenuStrip = this.contextMenu;
            this.listBoxPhotos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.Location = new System.Drawing.Point(6, 6);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPhotos.Size = new System.Drawing.Size(241, 157);
            this.listBoxPhotos.TabIndex = 2;
            this.listBoxPhotos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxPhotos_DrawItem);
            this.listBoxPhotos.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBoxPhotos_MeasureItem);
            this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotos_SelectedIndexChanged);
            this.listBoxPhotos.DoubleClick += new System.EventHandler(this.listBoxPhotos_DoubleClick);
            // 
            // tabPageDates
            // 
            this.tabPageDates.Controls.Add(this.monthCalendarPhotoDate);
            this.tabPageDates.Location = new System.Drawing.Point(23, 4);
            this.tabPageDates.Name = "tabPageDates";
            this.tabPageDates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDates.Size = new System.Drawing.Size(336, 168);
            this.tabPageDates.TabIndex = 1;
            this.tabPageDates.Text = "Dates";
            this.tabPageDates.UseVisualStyleBackColor = true;
            // 
            // monthCalendarPhotoDate
            // 
            this.monthCalendarPhotoDate.Location = new System.Drawing.Point(9, 5);
            this.monthCalendarPhotoDate.MaxSelectionCount = 1;
            this.monthCalendarPhotoDate.Name = "monthCalendarPhotoDate";
            this.monthCalendarPhotoDate.ShowToday = false;
            this.monthCalendarPhotoDate.TabIndex = 0;
            this.monthCalendarPhotoDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendarPhotoDate_MouseDown);
            // 
            // MyAlbumEditorForm
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 296);
            this.Controls.Add(this.tabControlPhotos);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxAlbums);
            this.Name = "MyAlbumEditorForm";
            this.Text = "MyAlbumEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyAlbumEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.MyAlbumEditorForm_Load);
            this.groupBoxAlbums.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.tabControlPhotos.ResumeLayout(false);
            this.tabPagePhotos.ResumeLayout(false);
            this.tableLayoutPanelPhotoCtrl.ResumeLayout(false);
            this.tabPageDates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlbums;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAlbumProperties;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuThumbs;
        private System.Windows.Forms.ToolStripMenuItem imagesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlPhotos;
        private System.Windows.Forms.TabPage tabPagePhotos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPhotoCtrl;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonPhotoProperties;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.TabPage tabPageDates;
        private System.Windows.Forms.MonthCalendar monthCalendarPhotoDate;
    }
}

