namespace WinformTutorials.SideForms
{
    partial class PhotoEditDlg
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
            this.tableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPhotographer = new System.Windows.Forms.TextBox();
            this.textBoxDateTaken = new System.Windows.Forms.TextBox();
            this.textBoxCaption = new System.Windows.Forms.TextBox();
            this.labelPhotoFile = new System.Windows.Forms.Label();
            this.labelCaption = new System.Windows.Forms.Label();
            this.labelDateTaken = new System.Windows.Forms.Label();
            this.labelPhotographer = new System.Windows.Forms.Label();
            this.textBoxPhotoFile = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.panelInfo.SuspendLayout();
            this.tableLayoutPanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.tableLayoutPanelInfo);
            // 
            // tableLayoutPanelInfo
            // 
            this.tableLayoutPanelInfo.ColumnCount = 2;
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.39716F));
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.60284F));
            this.tableLayoutPanelInfo.Controls.Add(this.textBoxPhotographer, 1, 3);
            this.tableLayoutPanelInfo.Controls.Add(this.textBoxDateTaken, 1, 2);
            this.tableLayoutPanelInfo.Controls.Add(this.textBoxCaption, 1, 1);
            this.tableLayoutPanelInfo.Controls.Add(this.labelPhotoFile, 0, 0);
            this.tableLayoutPanelInfo.Controls.Add(this.labelCaption, 0, 1);
            this.tableLayoutPanelInfo.Controls.Add(this.labelDateTaken, 0, 2);
            this.tableLayoutPanelInfo.Controls.Add(this.labelPhotographer, 0, 3);
            this.tableLayoutPanelInfo.Controls.Add(this.textBoxPhotoFile, 1, 0);
            this.tableLayoutPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInfo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            this.tableLayoutPanelInfo.RowCount = 4;
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.Size = new System.Drawing.Size(282, 115);
            this.tableLayoutPanelInfo.TabIndex = 0;
            // 
            // textBoxPhotographer
            // 
            this.textBoxPhotographer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPhotographer.Location = new System.Drawing.Point(135, 89);
            this.textBoxPhotographer.Name = "textBoxPhotographer";
            this.textBoxPhotographer.Size = new System.Drawing.Size(144, 20);
            this.textBoxPhotographer.TabIndex = 7;
            // 
            // textBoxDateTaken
            // 
            this.textBoxDateTaken.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxDateTaken.Location = new System.Drawing.Point(135, 60);
            this.textBoxDateTaken.Name = "textBoxDateTaken";
            this.textBoxDateTaken.Size = new System.Drawing.Size(144, 20);
            this.textBoxDateTaken.TabIndex = 5;
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxCaption.Location = new System.Drawing.Point(135, 32);
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(144, 20);
            this.textBoxCaption.TabIndex = 3;
            this.textBoxCaption.TextChanged += new System.EventHandler(this.textBoxCaption_TextChanged);
            this.textBoxCaption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCaption_KeyPress);
            // 
            // labelPhotoFile
            // 
            this.labelPhotoFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPhotoFile.AutoSize = true;
            this.labelPhotoFile.Location = new System.Drawing.Point(36, 7);
            this.labelPhotoFile.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelPhotoFile.Name = "labelPhotoFile";
            this.labelPhotoFile.Size = new System.Drawing.Size(57, 13);
            this.labelPhotoFile.TabIndex = 0;
            this.labelPhotoFile.Text = "Photo &File:";
            // 
            // labelCaption
            // 
            this.labelCaption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(47, 35);
            this.labelCaption.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(46, 13);
            this.labelCaption.TabIndex = 2;
            this.labelCaption.Text = "Cap&tion:";
            // 
            // labelDateTaken
            // 
            this.labelDateTaken.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDateTaken.AutoSize = true;
            this.labelDateTaken.Location = new System.Drawing.Point(26, 63);
            this.labelDateTaken.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelDateTaken.Name = "labelDateTaken";
            this.labelDateTaken.Size = new System.Drawing.Size(67, 13);
            this.labelDateTaken.TabIndex = 4;
            this.labelDateTaken.Text = "&Date Taken:";
            // 
            // labelPhotographer
            // 
            this.labelPhotographer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPhotographer.AutoSize = true;
            this.labelPhotographer.Location = new System.Drawing.Point(19, 93);
            this.labelPhotographer.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelPhotographer.Name = "labelPhotographer";
            this.labelPhotographer.Size = new System.Drawing.Size(74, 13);
            this.labelPhotographer.TabIndex = 6;
            this.labelPhotographer.Text = "&Photographer:";
            // 
            // textBoxPhotoFile
            // 
            this.textBoxPhotoFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPhotoFile.Location = new System.Drawing.Point(135, 4);
            this.textBoxPhotoFile.Name = "textBoxPhotoFile";
            this.textBoxPhotoFile.ReadOnly = true;
            this.textBoxPhotoFile.Size = new System.Drawing.Size(144, 20);
            this.textBoxPhotoFile.TabIndex = 1;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(6, 133);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 4;
            this.labelNotes.Text = "&Notes:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.AcceptsReturn = true;
            this.textBoxNotes.Location = new System.Drawing.Point(9, 149);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(263, 84);
            this.textBoxNotes.TabIndex = 5;
            // 
            // PhotoEditDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelNotes);
            this.Name = "PhotoEditDlg";
            this.Text = "PhotoEditDlg";
            this.Controls.SetChildIndex(this.panelInfo, 0);
            this.Controls.SetChildIndex(this.labelNotes, 0);
            this.Controls.SetChildIndex(this.textBoxNotes, 0);
            this.panelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfo;
        private System.Windows.Forms.TextBox textBoxPhotographer;
        private System.Windows.Forms.TextBox textBoxDateTaken;
        private System.Windows.Forms.TextBox textBoxCaption;
        private System.Windows.Forms.Label labelPhotoFile;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Label labelDateTaken;
        private System.Windows.Forms.Label labelPhotographer;
        private System.Windows.Forms.TextBox textBoxPhotoFile;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxNotes;
    }
}
