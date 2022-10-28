namespace StudentProgramCsharp.user_control
{
    partial class DownloadList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab_Program_name = new System.Windows.Forms.Label();
            this.lab_processing = new System.Windows.Forms.Label();
            this.but_stop = new System.Windows.Forms.Button();
            this.but_Install = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbspeed = new System.Windows.Forms.Label();
            this.lbUrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lab_Program_name
            // 
            this.lab_Program_name.AutoSize = true;
            this.lab_Program_name.Location = new System.Drawing.Point(76, 16);
            this.lab_Program_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Program_name.Name = "lab_Program_name";
            this.lab_Program_name.Size = new System.Drawing.Size(91, 13);
            this.lab_Program_name.TabIndex = 1;
            this.lab_Program_name.Text = "Program name";
            // 
            // lab_processing
            // 
            this.lab_processing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_processing.AutoSize = true;
            this.lab_processing.Location = new System.Drawing.Point(420, 16);
            this.lab_processing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_processing.Name = "lab_processing";
            this.lab_processing.Size = new System.Drawing.Size(47, 13);
            this.lab_processing.TabIndex = 2;
            this.lab_processing.Text = "speed: ";
            // 
            // but_stop
            // 
            this.but_stop.Location = new System.Drawing.Point(12, 3);
            this.but_stop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_stop.Name = "but_stop";
            this.but_stop.Size = new System.Drawing.Size(88, 42);
            this.but_stop.TabIndex = 3;
            this.but_stop.Text = "&Stop";
            this.but_stop.UseVisualStyleBackColor = true;
            this.but_stop.Click += new System.EventHandler(this.but_stop_Click);
            // 
            // but_Install
            // 
            this.but_Install.Location = new System.Drawing.Point(108, 3);
            this.but_Install.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_Install.Name = "but_Install";
            this.but_Install.Size = new System.Drawing.Size(88, 42);
            this.but_Install.TabIndex = 4;
            this.but_Install.Text = "Install";
            this.but_Install.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but_stop);
            this.panel1.Controls.Add(this.but_Install);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(614, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 47);
            this.panel1.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 17);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 13);
            this.progressBar1.TabIndex = 6;
            // 
            // lbspeed
            // 
            this.lbspeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbspeed.AutoSize = true;
            this.lbspeed.Location = new System.Drawing.Point(546, 17);
            this.lbspeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbspeed.Name = "lbspeed";
            this.lbspeed.Size = new System.Drawing.Size(63, 13);
            this.lbspeed.TabIndex = 2;
            this.lbspeed.Text = "0.00 MB/s";
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(76, 32);
            this.lbUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(26, 13);
            this.lbUrl.TabIndex = 1;
            this.lbUrl.Text = "Url:";
            // 
            // DownloadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbspeed);
            this.Controls.Add(this.lab_processing);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.lab_Program_name);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DownloadList";
            this.Size = new System.Drawing.Size(814, 47);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lab_Program_name;
        private System.Windows.Forms.Label lab_processing;
        private System.Windows.Forms.Button but_stop;
        private System.Windows.Forms.Button but_Install;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbspeed;
        private System.Windows.Forms.Label lbUrl;
    }
}
