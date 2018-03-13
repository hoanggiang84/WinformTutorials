namespace WinformTutorials.SideForms
{
    partial class SlideShowForm
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
            this.tableLayoutPanelSlide = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxSlide = new System.Windows.Forms.PictureBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.trackBarSlide = new System.Windows.Forms.TrackBar();
            this.timerSlide = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSlide
            // 
            this.tableLayoutPanelSlide.ColumnCount = 4;
            this.tableLayoutPanelSlide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSlide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSlide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelSlide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelSlide.Controls.Add(this.buttonClose, 3, 2);
            this.tableLayoutPanelSlide.Controls.Add(this.pictureBoxSlide, 0, 0);
            this.tableLayoutPanelSlide.Controls.Add(this.labelInterval, 0, 2);
            this.tableLayoutPanelSlide.Controls.Add(this.textBoxInterval, 1, 2);
            this.tableLayoutPanelSlide.Controls.Add(this.buttonStop, 2, 2);
            this.tableLayoutPanelSlide.Controls.Add(this.trackBarSlide, 0, 3);
            this.tableLayoutPanelSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSlide.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSlide.Name = "tableLayoutPanelSlide";
            this.tableLayoutPanelSlide.RowCount = 4;
            this.tableLayoutPanelSlide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelSlide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelSlide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelSlide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelSlide.Size = new System.Drawing.Size(284, 312);
            this.tableLayoutPanelSlide.TabIndex = 0;
            // 
            // pictureBoxSlide
            // 
            this.pictureBoxSlide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanelSlide.SetColumnSpan(this.pictureBoxSlide, 4);
            this.pictureBoxSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSlide.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSlide.Name = "pictureBoxSlide";
            this.tableLayoutPanelSlide.SetRowSpan(this.pictureBoxSlide, 2);
            this.pictureBoxSlide.Size = new System.Drawing.Size(278, 211);
            this.pictureBoxSlide.TabIndex = 0;
            this.pictureBoxSlide.TabStop = false;
            this.pictureBoxSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSlide_Paint);
            this.pictureBoxSlide.Resize += new System.EventHandler(this.pictureBoxSlide_Resize);
            // 
            // labelInterval
            // 
            this.labelInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(3, 233);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(45, 13);
            this.labelInterval.TabIndex = 1;
            this.labelInterval.Text = "&Interval:";
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInterval.Location = new System.Drawing.Point(59, 230);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(50, 20);
            this.textBoxInterval.TabIndex = 2;
            this.textBoxInterval.Text = "1";
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStop.Location = new System.Drawing.Point(119, 228);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "&Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.Location = new System.Drawing.Point(205, 228);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // trackBarSlide
            // 
            this.trackBarSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSlide.SetColumnSpan(this.trackBarSlide, 4);
            this.trackBarSlide.Location = new System.Drawing.Point(3, 266);
            this.trackBarSlide.Name = "trackBarSlide";
            this.trackBarSlide.Size = new System.Drawing.Size(278, 43);
            this.trackBarSlide.TabIndex = 5;
            this.trackBarSlide.Scroll += new System.EventHandler(this.trackBarSlide_Scroll);
            // 
            // timerSlide
            // 
            this.timerSlide.Tick += new System.EventHandler(this.timerSlide_Tick);
            // 
            // SlideShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanelSlide);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SlideShowForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Slide Show";
            this.Load += new System.EventHandler(this.SlideShowForm_Load);
            this.tableLayoutPanelSlide.ResumeLayout(false);
            this.tableLayoutPanelSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSlide;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxSlide;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TrackBar trackBarSlide;
        private System.Windows.Forms.Timer timerSlide;
    }
}