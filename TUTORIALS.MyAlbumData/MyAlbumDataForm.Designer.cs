namespace TUTORIALS.MyAlbumData
{
    partial class MyAlbumDataForm
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
            this.labelAlbum = new System.Windows.Forms.Label();
            this.comboBoxAlbum = new System.Windows.Forms.ComboBox();
            this.dataGridViewPhotoAlbum = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAlbum = new System.Windows.Forms.TabPage();
            this.tabPagePhoto = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPhoto = new System.Windows.Forms.TableLayoutPanel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelCaption = new System.Windows.Forms.Label();
            this.labelPhotographer = new System.Windows.Forms.Label();
            this.labelDateTaken = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxCaption = new System.Windows.Forms.TextBox();
            this.textBoxPhotographer = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateTaken = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhotoAlbum)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageAlbum.SuspendLayout();
            this.tabPagePhoto.SuspendLayout();
            this.tableLayoutPanelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(12, 9);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(39, 13);
            this.labelAlbum.TabIndex = 0;
            this.labelAlbum.Text = "&Album:";
            // 
            // comboBoxAlbum
            // 
            this.comboBoxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlbum.FormattingEnabled = true;
            this.comboBoxAlbum.Location = new System.Drawing.Point(57, 6);
            this.comboBoxAlbum.Name = "comboBoxAlbum";
            this.comboBoxAlbum.Size = new System.Drawing.Size(469, 21);
            this.comboBoxAlbum.TabIndex = 1;
            this.comboBoxAlbum.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbum_SelectedIndexChanged);
            // 
            // dataGridViewPhotoAlbum
            // 
            this.dataGridViewPhotoAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhotoAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPhotoAlbum.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPhotoAlbum.Name = "dataGridViewPhotoAlbum";
            this.dataGridViewPhotoAlbum.Size = new System.Drawing.Size(396, 206);
            this.dataGridViewPhotoAlbum.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(537, 407);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageAlbum);
            this.tabControlMain.Controls.Add(this.tabPagePhoto);
            this.tabControlMain.Location = new System.Drawing.Point(12, 33);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(600, 368);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageAlbum
            // 
            this.tabPageAlbum.Controls.Add(this.dataGridViewPhotoAlbum);
            this.tabPageAlbum.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlbum.Name = "tabPageAlbum";
            this.tabPageAlbum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbum.Size = new System.Drawing.Size(402, 212);
            this.tabPageAlbum.TabIndex = 0;
            this.tabPageAlbum.Text = "Album";
            this.tabPageAlbum.UseVisualStyleBackColor = true;
            // 
            // tabPagePhoto
            // 
            this.tabPagePhoto.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePhoto.Controls.Add(this.tableLayoutPanelPhoto);
            this.tabPagePhoto.Location = new System.Drawing.Point(4, 22);
            this.tabPagePhoto.Name = "tabPagePhoto";
            this.tabPagePhoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhoto.Size = new System.Drawing.Size(592, 342);
            this.tabPagePhoto.TabIndex = 1;
            this.tabPagePhoto.Text = "Photo";
            // 
            // tableLayoutPanelPhoto
            // 
            this.tableLayoutPanelPhoto.ColumnCount = 4;
            this.tableLayoutPanelPhoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelPhoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelPhoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelPhoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelPhoto.Controls.Add(this.textBoxPhotographer, 3, 2);
            this.tableLayoutPanelPhoto.Controls.Add(this.textBoxNotes, 2, 5);
            this.tableLayoutPanelPhoto.Controls.Add(this.labelCaption, 2, 1);
            this.tableLayoutPanelPhoto.Controls.Add(this.labelFileName, 0, 0);
            this.tableLayoutPanelPhoto.Controls.Add(this.textBoxFileName, 1, 0);
            this.tableLayoutPanelPhoto.Controls.Add(this.pictureBoxPhoto, 0, 1);
            this.tableLayoutPanelPhoto.Controls.Add(this.labelPhotographer, 2, 2);
            this.tableLayoutPanelPhoto.Controls.Add(this.labelDateTaken, 2, 3);
            this.tableLayoutPanelPhoto.Controls.Add(this.textBoxCaption, 3, 1);
            this.tableLayoutPanelPhoto.Controls.Add(this.dateTimePickerDateTaken, 3, 3);
            this.tableLayoutPanelPhoto.Controls.Add(this.buttonPrevious, 0, 6);
            this.tableLayoutPanelPhoto.Controls.Add(this.buttonNext, 1, 6);
            this.tableLayoutPanelPhoto.Controls.Add(this.labelNotes, 2, 4);
            this.tableLayoutPanelPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPhoto.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPhoto.Name = "tableLayoutPanelPhoto";
            this.tableLayoutPanelPhoto.RowCount = 7;
            this.tableLayoutPanelPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPhoto.Size = new System.Drawing.Size(586, 336);
            this.tableLayoutPanelPhoto.TabIndex = 0;
            // 
            // labelFileName
            // 
            this.labelFileName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(3, 8);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(57, 13);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "File Name:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPhoto.SetColumnSpan(this.textBoxFileName, 3);
            this.textBoxFileName.Location = new System.Drawing.Point(73, 5);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(510, 20);
            this.textBoxFileName.TabIndex = 1;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanelPhoto.SetColumnSpan(this.pictureBoxPhoto, 2);
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(3, 33);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.tableLayoutPanelPhoto.SetRowSpan(this.pictureBoxPhoto, 5);
            this.pictureBoxPhoto.Size = new System.Drawing.Size(369, 270);
            this.pictureBoxPhoto.TabIndex = 2;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPhoto_Paint);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPrevious.Location = new System.Drawing.Point(3, 309);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(64, 23);
            this.buttonPrevious.TabIndex = 10;
            this.buttonPrevious.Text = "Pre&v";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNext.Location = new System.Drawing.Point(73, 309);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "Nex&t";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(378, 38);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(46, 13);
            this.labelCaption.TabIndex = 2;
            this.labelCaption.Text = "Captio&n:";
            // 
            // labelPhotographer
            // 
            this.labelPhotographer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPhotographer.AutoSize = true;
            this.labelPhotographer.Location = new System.Drawing.Point(378, 68);
            this.labelPhotographer.Name = "labelPhotographer";
            this.labelPhotographer.Size = new System.Drawing.Size(74, 13);
            this.labelPhotographer.TabIndex = 4;
            this.labelPhotographer.Text = "&Photographer:";
            // 
            // labelDateTaken
            // 
            this.labelDateTaken.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDateTaken.AutoSize = true;
            this.labelDateTaken.Location = new System.Drawing.Point(378, 98);
            this.labelDateTaken.Name = "labelDateTaken";
            this.labelDateTaken.Size = new System.Drawing.Size(67, 13);
            this.labelDateTaken.TabIndex = 6;
            this.labelDateTaken.Text = "&Date Taken:";
            // 
            // labelNotes
            // 
            this.labelNotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(378, 128);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 8;
            this.labelNotes.Text = "Note&s:";
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCaption.Location = new System.Drawing.Point(458, 35);
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(125, 20);
            this.textBoxCaption.TabIndex = 3;
            // 
            // textBoxPhotographer
            // 
            this.textBoxPhotographer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhotographer.Location = new System.Drawing.Point(458, 65);
            this.textBoxPhotographer.Name = "textBoxPhotographer";
            this.textBoxPhotographer.Size = new System.Drawing.Size(125, 20);
            this.textBoxPhotographer.TabIndex = 5;
            // 
            // textBoxNotes
            // 
            this.tableLayoutPanelPhoto.SetColumnSpan(this.textBoxNotes, 2);
            this.textBoxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNotes.Location = new System.Drawing.Point(378, 153);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.tableLayoutPanelPhoto.SetRowSpan(this.textBoxNotes, 2);
            this.textBoxNotes.Size = new System.Drawing.Size(205, 180);
            this.textBoxNotes.TabIndex = 9;
            // 
            // dateTimePickerDateTaken
            // 
            this.dateTimePickerDateTaken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTaken.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateTaken.Location = new System.Drawing.Point(458, 95);
            this.dateTimePickerDateTaken.Name = "dateTimePickerDateTaken";
            this.dateTimePickerDateTaken.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerDateTaken.TabIndex = 7;
            // 
            // MyAlbumDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.comboBoxAlbum);
            this.Controls.Add(this.labelAlbum);
            this.Name = "MyAlbumDataForm";
            this.Text = "MyAlbumData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyAlbumDataForm_FormClosing);
            this.Load += new System.EventHandler(this.MyAlbumDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhotoAlbum)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageAlbum.ResumeLayout(false);
            this.tabPagePhoto.ResumeLayout(false);
            this.tableLayoutPanelPhoto.ResumeLayout(false);
            this.tableLayoutPanelPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.ComboBox comboBoxAlbum;
        private System.Windows.Forms.DataGridView dataGridViewPhotoAlbum;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAlbum;
        private System.Windows.Forms.TabPage tabPagePhoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPhoto;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Label labelPhotographer;
        private System.Windows.Forms.Label labelDateTaken;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxCaption;
        private System.Windows.Forms.TextBox textBoxPhotographer;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTaken;
    }
}

