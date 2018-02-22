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
            this.components = new System.ComponentModel.Container();
            this.groupBoxAlbums = new System.Windows.Forms.GroupBox();
            this.buttonAlbumProperties = new System.Windows.Forms.Button();
            this.groupBoxPhotographs = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPhotoCtrl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonPhotoProperties = new System.Windows.Forms.Button();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thumbnailsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAlbums.SuspendLayout();
            this.groupBoxPhotographs.SuspendLayout();
            this.tableLayoutPanelPhotoCtrl.SuspendLayout();
            this.contextMenu.SuspendLayout();
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
            this.groupBoxAlbums.Size = new System.Drawing.Size(360, 61);
            this.groupBoxAlbums.TabIndex = 0;
            this.groupBoxAlbums.TabStop = false;
            this.groupBoxAlbums.Text = "&Albums";
            // 
            // buttonAlbumProperties
            // 
            this.buttonAlbumProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlbumProperties.Enabled = false;
            this.buttonAlbumProperties.Location = new System.Drawing.Point(271, 19);
            this.buttonAlbumProperties.Name = "buttonAlbumProperties";
            this.buttonAlbumProperties.Size = new System.Drawing.Size(80, 23);
            this.buttonAlbumProperties.TabIndex = 1;
            this.buttonAlbumProperties.Text = "Properti&es";
            this.buttonAlbumProperties.UseVisualStyleBackColor = true;
            this.buttonAlbumProperties.Click += new System.EventHandler(this.buttonAlbumProperties_Click);
            // 
            // groupBoxPhotographs
            // 
            this.groupBoxPhotographs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPhotographs.Controls.Add(this.tableLayoutPanelPhotoCtrl);
            this.groupBoxPhotographs.Controls.Add(this.listBoxPhotos);
            this.groupBoxPhotographs.Location = new System.Drawing.Point(12, 79);
            this.groupBoxPhotographs.Name = "groupBoxPhotographs";
            this.groupBoxPhotographs.Size = new System.Drawing.Size(360, 137);
            this.groupBoxPhotographs.TabIndex = 1;
            this.groupBoxPhotographs.TabStop = false;
            this.groupBoxPhotographs.Text = "&Photographs";
            // 
            // tableLayoutPanelPhotoCtrl
            // 
            this.tableLayoutPanelPhotoCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPhotoCtrl.ColumnCount = 1;
            this.tableLayoutPanelPhotoCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPhotoCtrl.Controls.Add(this.buttonRemove, 0, 2);
            this.tableLayoutPanelPhotoCtrl.Controls.Add(this.buttonMoveDown, 0, 1);
            this.tableLayoutPanelPhotoCtrl.Controls.Add(this.buttonMoveUp, 0, 0);
            this.tableLayoutPanelPhotoCtrl.Controls.Add(this.buttonPhotoProperties, 0, 3);
            this.tableLayoutPanelPhotoCtrl.Location = new System.Drawing.Point(268, 13);
            this.tableLayoutPanelPhotoCtrl.Name = "tableLayoutPanelPhotoCtrl";
            this.tableLayoutPanelPhotoCtrl.RowCount = 4;
            this.tableLayoutPanelPhotoCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPhotoCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPhotoCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPhotoCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPhotoCtrl.Size = new System.Drawing.Size(86, 118);
            this.tableLayoutPanelPhotoCtrl.TabIndex = 1;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(3, 61);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(80, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "&Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveDown.Enabled = false;
            this.buttonMoveDown.Location = new System.Drawing.Point(3, 32);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(80, 23);
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
            this.buttonMoveUp.Size = new System.Drawing.Size(80, 23);
            this.buttonMoveUp.TabIndex = 3;
            this.buttonMoveUp.Text = "Move &Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonPhotoProperties
            // 
            this.buttonPhotoProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPhotoProperties.Enabled = false;
            this.buttonPhotoProperties.Location = new System.Drawing.Point(3, 90);
            this.buttonPhotoProperties.Name = "buttonPhotoProperties";
            this.buttonPhotoProperties.Size = new System.Drawing.Size(80, 23);
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
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.Location = new System.Drawing.Point(6, 19);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPhotos.Size = new System.Drawing.Size(256, 108);
            this.listBoxPhotos.TabIndex = 0;
            this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotos_SelectedIndexChanged);
            this.listBoxPhotos.DoubleClick += new System.EventHandler(this.listBoxPhotos_DoubleClick);
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
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(6, 21);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(256, 21);
            this.comboBoxAlbums.Sorted = true;
            this.comboBoxAlbums.TabIndex = 2;
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thumbnailsMenu});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // thumbnailsMenu
            // 
            this.thumbnailsMenu.Name = "thumbnailsMenu";
            this.thumbnailsMenu.Size = new System.Drawing.Size(152, 22);
            this.thumbnailsMenu.Text = "&Thumbnails";
            this.thumbnailsMenu.Click += new System.EventHandler(this.thumbnailsMenu_Click);
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
            this.tableLayoutPanelPhotoCtrl.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlbums;
        private System.Windows.Forms.GroupBox groupBoxPhotographs;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAlbumProperties;
        private System.Windows.Forms.Button buttonPhotoProperties;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPhotoCtrl;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem thumbnailsMenu;
    }
}

