namespace WinformTutorials.SideForms
{
    partial class AlbumEditDlg
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
            this.tableLayoutPanelAlbumInfo = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelAlbumFile = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxAlbumFile = new System.Windows.Forms.TextBox();
            this.groupBoxPhotoDisplayOption = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelDisplayOption = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.radioButtonCaption = new System.Windows.Forms.RadioButton();
            this.radioButtonFilename = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelPassword = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxRequiredPassword = new System.Windows.Forms.CheckBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfrimPassword = new System.Windows.Forms.TextBox();
            this.panelInfo.SuspendLayout();
            this.tableLayoutPanelAlbumInfo.SuspendLayout();
            this.groupBoxPhotoDisplayOption.SuspendLayout();
            this.tableLayoutPanelDisplayOption.SuspendLayout();
            this.tableLayoutPanelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.tableLayoutPanelAlbumInfo);
            this.panelInfo.Size = new System.Drawing.Size(284, 79);
            // 
            // tableLayoutPanelAlbumInfo
            // 
            this.tableLayoutPanelAlbumInfo.ColumnCount = 2;
            this.tableLayoutPanelAlbumInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.49645F));
            this.tableLayoutPanelAlbumInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.50355F));
            this.tableLayoutPanelAlbumInfo.Controls.Add(this.textBoxTitle, 1, 1);
            this.tableLayoutPanelAlbumInfo.Controls.Add(this.labelAlbumFile, 0, 0);
            this.tableLayoutPanelAlbumInfo.Controls.Add(this.labelTitle, 0, 1);
            this.tableLayoutPanelAlbumInfo.Controls.Add(this.textBoxAlbumFile, 1, 0);
            this.tableLayoutPanelAlbumInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAlbumInfo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAlbumInfo.Name = "tableLayoutPanelAlbumInfo";
            this.tableLayoutPanelAlbumInfo.RowCount = 2;
            this.tableLayoutPanelAlbumInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAlbumInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAlbumInfo.Size = new System.Drawing.Size(282, 77);
            this.tableLayoutPanelAlbumInfo.TabIndex = 0;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxTitle.Location = new System.Drawing.Point(102, 47);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(177, 20);
            this.textBoxTitle.TabIndex = 3;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelAlbumFile
            // 
            this.labelAlbumFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAlbumFile.AutoSize = true;
            this.labelAlbumFile.Location = new System.Drawing.Point(24, 12);
            this.labelAlbumFile.Name = "labelAlbumFile";
            this.labelAlbumFile.Size = new System.Drawing.Size(58, 13);
            this.labelAlbumFile.TabIndex = 0;
            this.labelAlbumFile.Text = "Album &File:";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(52, 51);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "&Title:";
            // 
            // textBoxAlbumFile
            // 
            this.textBoxAlbumFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxAlbumFile.Location = new System.Drawing.Point(102, 9);
            this.textBoxAlbumFile.Name = "textBoxAlbumFile";
            this.textBoxAlbumFile.ReadOnly = true;
            this.textBoxAlbumFile.Size = new System.Drawing.Size(177, 20);
            this.textBoxAlbumFile.TabIndex = 1;
            // 
            // groupBoxPhotoDisplayOption
            // 
            this.groupBoxPhotoDisplayOption.Controls.Add(this.tableLayoutPanelDisplayOption);
            this.groupBoxPhotoDisplayOption.Location = new System.Drawing.Point(1, 85);
            this.groupBoxPhotoDisplayOption.Name = "groupBoxPhotoDisplayOption";
            this.groupBoxPhotoDisplayOption.Size = new System.Drawing.Size(283, 61);
            this.groupBoxPhotoDisplayOption.TabIndex = 4;
            this.groupBoxPhotoDisplayOption.TabStop = false;
            this.groupBoxPhotoDisplayOption.Text = "Phot&o Display Text";
            // 
            // tableLayoutPanelDisplayOption
            // 
            this.tableLayoutPanelDisplayOption.ColumnCount = 3;
            this.tableLayoutPanelDisplayOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDisplayOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDisplayOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDisplayOption.Controls.Add(this.radioButtonDate, 2, 0);
            this.tableLayoutPanelDisplayOption.Controls.Add(this.radioButtonCaption, 1, 0);
            this.tableLayoutPanelDisplayOption.Controls.Add(this.radioButtonFilename, 0, 0);
            this.tableLayoutPanelDisplayOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDisplayOption.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelDisplayOption.Name = "tableLayoutPanelDisplayOption";
            this.tableLayoutPanelDisplayOption.RowCount = 1;
            this.tableLayoutPanelDisplayOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDisplayOption.Size = new System.Drawing.Size(277, 42);
            this.tableLayoutPanelDisplayOption.TabIndex = 0;
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(206, 12);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDate.TabIndex = 2;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "&Date";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.Click += new System.EventHandler(this.displayOption_Click);
            // 
            // radioButtonCaption
            // 
            this.radioButtonCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCaption.AutoSize = true;
            this.radioButtonCaption.Location = new System.Drawing.Point(107, 12);
            this.radioButtonCaption.Name = "radioButtonCaption";
            this.radioButtonCaption.Size = new System.Drawing.Size(61, 17);
            this.radioButtonCaption.TabIndex = 1;
            this.radioButtonCaption.TabStop = true;
            this.radioButtonCaption.Text = "&Caption";
            this.radioButtonCaption.UseVisualStyleBackColor = true;
            this.radioButtonCaption.Click += new System.EventHandler(this.displayOption_Click);
            // 
            // radioButtonFilename
            // 
            this.radioButtonFilename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonFilename.AutoSize = true;
            this.radioButtonFilename.Location = new System.Drawing.Point(11, 12);
            this.radioButtonFilename.Name = "radioButtonFilename";
            this.radioButtonFilename.Size = new System.Drawing.Size(70, 17);
            this.radioButtonFilename.TabIndex = 0;
            this.radioButtonFilename.TabStop = true;
            this.radioButtonFilename.Text = "&File name";
            this.radioButtonFilename.UseVisualStyleBackColor = true;
            this.radioButtonFilename.Click += new System.EventHandler(this.displayOption_Click);
            // 
            // tableLayoutPanelPassword
            // 
            this.tableLayoutPanelPassword.ColumnCount = 2;
            this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPassword.Controls.Add(this.textBoxConfrimPassword, 1, 1);
            this.tableLayoutPanelPassword.Controls.Add(this.checkBoxRequiredPassword, 0, 0);
            this.tableLayoutPanelPassword.Controls.Add(this.labelConfirmPassword, 0, 1);
            this.tableLayoutPanelPassword.Controls.Add(this.textBoxPassword, 1, 0);
            this.tableLayoutPanelPassword.Location = new System.Drawing.Point(1, 149);
            this.tableLayoutPanelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelPassword.Name = "tableLayoutPanelPassword";
            this.tableLayoutPanelPassword.RowCount = 2;
            this.tableLayoutPanelPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPassword.Size = new System.Drawing.Size(283, 84);
            this.tableLayoutPanelPassword.TabIndex = 5;
            // 
            // checkBoxRequiredPassword
            // 
            this.checkBoxRequiredPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxRequiredPassword.AutoSize = true;
            this.checkBoxRequiredPassword.Location = new System.Drawing.Point(13, 12);
            this.checkBoxRequiredPassword.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxRequiredPassword.Name = "checkBoxRequiredPassword";
            this.checkBoxRequiredPassword.Size = new System.Drawing.Size(115, 17);
            this.checkBoxRequiredPassword.TabIndex = 0;
            this.checkBoxRequiredPassword.Text = "Require &Password:";
            this.checkBoxRequiredPassword.UseVisualStyleBackColor = true;
            this.checkBoxRequiredPassword.CheckedChanged += new System.EventHandler(this.checkBoxRequiredPassword_CheckedChanged);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(31, 56);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.labelConfirmPassword.TabIndex = 2;
            this.labelConfirmPassword.Text = "Confir&m Password:";
            this.labelConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(144, 11);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = 'x';
            this.textBoxPassword.Size = new System.Drawing.Size(136, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            // 
            // textBoxConfrimPassword
            // 
            this.textBoxConfrimPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxConfrimPassword.Enabled = false;
            this.textBoxConfrimPassword.Location = new System.Drawing.Point(144, 53);
            this.textBoxConfrimPassword.Name = "textBoxConfrimPassword";
            this.textBoxConfrimPassword.PasswordChar = 'x';
            this.textBoxConfrimPassword.Size = new System.Drawing.Size(136, 20);
            this.textBoxConfrimPassword.TabIndex = 3;
            // 
            // AlbumEditDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.tableLayoutPanelPassword);
            this.Controls.Add(this.groupBoxPhotoDisplayOption);
            this.Name = "AlbumEditDlg";
            this.Controls.SetChildIndex(this.panelInfo, 0);
            this.Controls.SetChildIndex(this.groupBoxPhotoDisplayOption, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanelPassword, 0);
            this.panelInfo.ResumeLayout(false);
            this.tableLayoutPanelAlbumInfo.ResumeLayout(false);
            this.tableLayoutPanelAlbumInfo.PerformLayout();
            this.groupBoxPhotoDisplayOption.ResumeLayout(false);
            this.tableLayoutPanelDisplayOption.ResumeLayout(false);
            this.tableLayoutPanelDisplayOption.PerformLayout();
            this.tableLayoutPanelPassword.ResumeLayout(false);
            this.tableLayoutPanelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAlbumInfo;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelAlbumFile;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxAlbumFile;
        private System.Windows.Forms.GroupBox groupBoxPhotoDisplayOption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDisplayOption;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.RadioButton radioButtonCaption;
        private System.Windows.Forms.RadioButton radioButtonFilename;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPassword;
        private System.Windows.Forms.TextBox textBoxConfrimPassword;
        private System.Windows.Forms.CheckBox checkBoxRequiredPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}
