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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhotoAlbum)).BeginInit();
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
            this.comboBoxAlbum.FormattingEnabled = true;
            this.comboBoxAlbum.Location = new System.Drawing.Point(57, 6);
            this.comboBoxAlbum.Name = "comboBoxAlbum";
            this.comboBoxAlbum.Size = new System.Drawing.Size(279, 21);
            this.comboBoxAlbum.TabIndex = 1;
            // 
            // dataGridViewPhotoAlbum
            // 
            this.dataGridViewPhotoAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPhotoAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhotoAlbum.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewPhotoAlbum.Name = "dataGridViewPhotoAlbum";
            this.dataGridViewPhotoAlbum.Size = new System.Drawing.Size(410, 188);
            this.dataGridViewPhotoAlbum.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 227);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MyAlbumDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewPhotoAlbum);
            this.Controls.Add(this.comboBoxAlbum);
            this.Controls.Add(this.labelAlbum);
            this.Name = "MyAlbumDataForm";
            this.Text = "MyAlbumData";
            this.Load += new System.EventHandler(this.MyAlbumDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhotoAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.ComboBox comboBoxAlbum;
        private System.Windows.Forms.DataGridView dataGridViewPhotoAlbum;
        private System.Windows.Forms.Button buttonClose;
    }
}

