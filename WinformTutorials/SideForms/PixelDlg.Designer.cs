namespace WinformTutorials
{
    partial class PixelDlg
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.77612F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.22388F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxBlue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGreen, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRed, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxY, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelX, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelY, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGreen, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelBlue, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxX, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(134, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBlue.Location = new System.Drawing.Point(62, 115);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.ReadOnly = true;
            this.textBoxBlue.Size = new System.Drawing.Size(69, 21);
            this.textBoxBlue.TabIndex = 9;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGreen.Location = new System.Drawing.Point(62, 87);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.ReadOnly = true;
            this.textBoxGreen.Size = new System.Drawing.Size(69, 21);
            this.textBoxGreen.TabIndex = 8;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRed.Location = new System.Drawing.Point(62, 59);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.ReadOnly = true;
            this.textBoxRed.Size = new System.Drawing.Size(69, 21);
            this.textBoxRed.TabIndex = 7;
            // 
            // textBoxY
            // 
            this.textBoxY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxY.Location = new System.Drawing.Point(62, 31);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(69, 21);
            this.textBoxY.TabIndex = 6;
            // 
            // labelX
            // 
            this.labelX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(36, 6);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 15);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(37, 34);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(19, 15);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y:";
            // 
            // labelRed
            // 
            this.labelRed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRed.Location = new System.Drawing.Point(19, 62);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(37, 15);
            this.labelRed.TabIndex = 2;
            this.labelRed.Text = "Red:";
            // 
            // labelGreen
            // 
            this.labelGreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreen.Location = new System.Drawing.Point(6, 90);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(50, 15);
            this.labelGreen.TabIndex = 3;
            this.labelGreen.Text = "Green:";
            // 
            // labelBlue
            // 
            this.labelBlue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlue.Location = new System.Drawing.Point(16, 118);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(40, 15);
            this.labelBlue.TabIndex = 4;
            this.labelBlue.Text = "Blue:";
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxX.Location = new System.Drawing.Point(62, 3);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(69, 21);
            this.textBoxX.TabIndex = 5;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(29, 146);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // PixelDlg
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(134, 192);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PixelDlg";
            this.Text = "Pixel Values";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
    }
}