namespace StudentProgramCsharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nav = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.but_Programs = new System.Windows.Forms.Button();
            this.but_My_Library = new System.Windows.Forms.Button();
            this.but_Downloads = new System.Windows.Forms.Button();
            this.Programs_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.content = new System.Windows.Forms.Panel();
            this.My_Library_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Downloads_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.nav.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.button1);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(233, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(857, 44);
            this.header.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(790, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(65, 42);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nav
            // 
            this.nav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nav.Controls.Add(this.flowLayoutPanel2);
            this.nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.Margin = new System.Windows.Forms.Padding(0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(233, 632);
            this.nav.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.but_Programs);
            this.flowLayoutPanel2.Controls.Add(this.but_My_Library);
            this.flowLayoutPanel2.Controls.Add(this.but_Downloads);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(231, 630);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // but_Programs
            // 
            this.but_Programs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Programs.Location = new System.Drawing.Point(4, 3);
            this.but_Programs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_Programs.Name = "but_Programs";
            this.but_Programs.Size = new System.Drawing.Size(224, 112);
            this.but_Programs.TabIndex = 0;
            this.but_Programs.Text = "Programs";
            this.but_Programs.UseVisualStyleBackColor = true;
            this.but_Programs.Click += new System.EventHandler(this.but_Programs_Click);
            // 
            // but_My_Library
            // 
            this.but_My_Library.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_My_Library.Location = new System.Drawing.Point(4, 121);
            this.but_My_Library.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_My_Library.Name = "but_My_Library";
            this.but_My_Library.Size = new System.Drawing.Size(224, 112);
            this.but_My_Library.TabIndex = 0;
            this.but_My_Library.Text = "My Library";
            this.but_My_Library.UseVisualStyleBackColor = true;
            this.but_My_Library.Click += new System.EventHandler(this.but_My_Library_Click);
            // 
            // but_Downloads
            // 
            this.but_Downloads.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Downloads.Location = new System.Drawing.Point(4, 239);
            this.but_Downloads.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_Downloads.Name = "but_Downloads";
            this.but_Downloads.Size = new System.Drawing.Size(224, 112);
            this.but_Downloads.TabIndex = 0;
            this.but_Downloads.Text = "Downloads";
            this.but_Downloads.UseVisualStyleBackColor = true;
            this.but_Downloads.Click += new System.EventHandler(this.but_Downloads_Click);
            // 
            // Programs_flowLayoutPanel
            // 
            this.Programs_flowLayoutPanel.AutoScroll = true;
            this.Programs_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Programs_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Programs_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Programs_flowLayoutPanel.Name = "Programs_flowLayoutPanel";
            this.Programs_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Programs_flowLayoutPanel.Size = new System.Drawing.Size(855, 586);
            this.Programs_flowLayoutPanel.TabIndex = 1;
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content.Controls.Add(this.Programs_flowLayoutPanel);
            this.content.Controls.Add(this.My_Library_flowLayoutPanel);
            this.content.Controls.Add(this.Downloads_flowLayoutPanel);
            this.content.Location = new System.Drawing.Point(233, 44);
            this.content.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(857, 588);
            this.content.TabIndex = 5;
            // 
            // My_Library_flowLayoutPanel
            // 
            this.My_Library_flowLayoutPanel.AutoScroll = true;
            this.My_Library_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.My_Library_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.My_Library_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.My_Library_flowLayoutPanel.Name = "My_Library_flowLayoutPanel";
            this.My_Library_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.My_Library_flowLayoutPanel.Size = new System.Drawing.Size(855, 586);
            this.My_Library_flowLayoutPanel.TabIndex = 2;
            // 
            // Downloads_flowLayoutPanel
            // 
            this.Downloads_flowLayoutPanel.AutoScroll = true;
            this.Downloads_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Downloads_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Downloads_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Downloads_flowLayoutPanel.Name = "Downloads_flowLayoutPanel";
            this.Downloads_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Downloads_flowLayoutPanel.Size = new System.Drawing.Size(855, 586);
            this.Downloads_flowLayoutPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1090, 632);
            this.Controls.Add(this.header);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.content);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.nav.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel nav;
        private System.Windows.Forms.FlowLayoutPanel Programs_flowLayoutPanel;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_Downloads;
        private System.Windows.Forms.Button but_My_Library;
        private System.Windows.Forms.Button but_Programs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel My_Library_flowLayoutPanel;
        public System.Windows.Forms.FlowLayoutPanel Downloads_flowLayoutPanel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel header;
    }
}

