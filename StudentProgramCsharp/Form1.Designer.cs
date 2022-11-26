using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Panel();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.User_Name = new System.Windows.Forms.Label();
            this.but_Settings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.Panel();
            this.lab_NumberOfDownloads = new System.Windows.Forms.Label();
            this.lab_NumberOFLibrary = new System.Windows.Forms.Label();
            this.lab_numOFprograms = new System.Windows.Forms.Label();
            this.nav = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.but_Programs = new Guna.UI2.WinForms.Guna2Button();
            this.but_My_Library = new Guna.UI2.WinForms.Guna2Button();
            this.but_Downloads = new Guna.UI2.WinForms.Guna2Button();
            this.Programs_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.content = new System.Windows.Forms.Panel();
            this.Programs = new System.Windows.Forms.Panel();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.MyLibrary_panel = new System.Windows.Forms.Panel();
            this.Downloads_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.settingsMenuForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.profileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.but_Max_Min_Form = new System.Windows.Forms.Button();
            this.but_ُExite = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Info.SuspendLayout();
            this.nav.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.content.SuspendLayout();
            this.Programs.SuspendLayout();
            this.settingsMenuForm.SuspendLayout();
            this.Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.tb_Search);
            this.header.Controls.Add(this.User_Name);
            this.header.Controls.Add(this.but_Settings);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 22);
            this.header.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1090, 39);
            this.header.TabIndex = 2;
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Location = new System.Drawing.Point(786, 8);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(233, 24);
            this.tb_Search.TabIndex = 4;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Font = new System.Drawing.Font("Rockwell", 11F);
            this.User_Name.Location = new System.Drawing.Point(55, 12);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(85, 17);
            this.User_Name.TabIndex = 3;
            this.User_Name.Text = "User Name";
            // 
            // but_Settings
            // 
            this.but_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_Settings.BackgroundImage")));
            this.but_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_Settings.FlatAppearance.BorderSize = 0;
            this.but_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Settings.ForeColor = System.Drawing.SystemColors.Control;
            this.but_Settings.Location = new System.Drawing.Point(1023, 0);
            this.but_Settings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_Settings.Name = "but_Settings";
            this.but_Settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.but_Settings.Size = new System.Drawing.Size(65, 37);
            this.but_Settings.TabIndex = 2;
            this.but_Settings.UseVisualStyleBackColor = true;
            this.but_Settings.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Info
            // 
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Info.Controls.Add(this.lab_NumberOfDownloads);
            this.Info.Controls.Add(this.lab_NumberOFLibrary);
            this.Info.Controls.Add(this.lab_numOFprograms);
            this.Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Info.Location = new System.Drawing.Point(233, 608);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(857, 24);
            this.Info.TabIndex = 6;
            // 
            // lab_NumberOfDownloads
            // 
            this.lab_NumberOfDownloads.Dock = System.Windows.Forms.DockStyle.Left;
            this.lab_NumberOfDownloads.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lab_NumberOfDownloads.Location = new System.Drawing.Point(220, 0);
            this.lab_NumberOfDownloads.Name = "lab_NumberOfDownloads";
            this.lab_NumberOfDownloads.Size = new System.Drawing.Size(110, 22);
            this.lab_NumberOfDownloads.TabIndex = 5;
            this.lab_NumberOfDownloads.Text = "Downloads:  0 |";
            // 
            // lab_NumberOFLibrary
            // 
            this.lab_NumberOFLibrary.Dock = System.Windows.Forms.DockStyle.Left;
            this.lab_NumberOFLibrary.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lab_NumberOFLibrary.Location = new System.Drawing.Point(110, 0);
            this.lab_NumberOFLibrary.Name = "lab_NumberOFLibrary";
            this.lab_NumberOFLibrary.Size = new System.Drawing.Size(110, 22);
            this.lab_NumberOFLibrary.TabIndex = 6;
            this.lab_NumberOFLibrary.Text = "My Library: 0 |";
            // 
            // lab_numOFprograms
            // 
            this.lab_numOFprograms.Dock = System.Windows.Forms.DockStyle.Left;
            this.lab_numOFprograms.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lab_numOFprograms.Location = new System.Drawing.Point(0, 0);
            this.lab_numOFprograms.Name = "lab_numOFprograms";
            this.lab_numOFprograms.Size = new System.Drawing.Size(110, 22);
            this.lab_numOFprograms.TabIndex = 7;
            this.lab_numOFprograms.Text = "Programs: 0 |";
            // 
            // nav
            // 
            this.nav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nav.Controls.Add(this.flowLayoutPanel2);
            this.nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav.Location = new System.Drawing.Point(0, 61);
            this.nav.Margin = new System.Windows.Forms.Padding(0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(233, 571);
            this.nav.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.but_Programs);
            this.flowLayoutPanel2.Controls.Add(this.but_My_Library);
            this.flowLayoutPanel2.Controls.Add(this.but_Downloads);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(231, 569);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // but_Programs
            // 
            this.but_Programs.AutoRoundedCorners = true;
            this.but_Programs.BackColor = System.Drawing.Color.Transparent;
            this.but_Programs.BorderRadius = 55;
            this.but_Programs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.but_Programs.Checked = true;
            this.but_Programs.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.but_Programs.CustomizableEdges.BottomLeft = false;
            this.but_Programs.CustomizableEdges.TopRight = false;
            this.but_Programs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_Programs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_Programs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_Programs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_Programs.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.but_Programs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.but_Programs.ForeColor = System.Drawing.Color.Black;
            this.but_Programs.Location = new System.Drawing.Point(3, 3);
            this.but_Programs.Name = "but_Programs";
            this.but_Programs.PressedColor = System.Drawing.SystemColors.ActiveBorder;
            this.but_Programs.Size = new System.Drawing.Size(224, 112);
            this.but_Programs.TabIndex = 1;
            this.but_Programs.Text = "Programs";
            this.but_Programs.Click += new System.EventHandler(this.but_Programs_Click);
            // 
            // but_My_Library
            // 
            this.but_My_Library.AutoRoundedCorners = true;
            this.but_My_Library.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but_My_Library.BorderRadius = 55;
            this.but_My_Library.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.but_My_Library.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.but_My_Library.CustomizableEdges.BottomLeft = false;
            this.but_My_Library.CustomizableEdges.TopRight = false;
            this.but_My_Library.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_My_Library.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_My_Library.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_My_Library.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_My_Library.Enabled = false;
            this.but_My_Library.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.but_My_Library.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.but_My_Library.ForeColor = System.Drawing.Color.Black;
            this.but_My_Library.Location = new System.Drawing.Point(3, 121);
            this.but_My_Library.Name = "but_My_Library";
            this.but_My_Library.PressedColor = System.Drawing.SystemColors.ActiveBorder;
            this.but_My_Library.Size = new System.Drawing.Size(224, 112);
            this.but_My_Library.TabIndex = 2;
            this.but_My_Library.Text = "*My Library";
            this.but_My_Library.Click += new System.EventHandler(this.but_My_Library_Click);
            // 
            // but_Downloads
            // 
            this.but_Downloads.AutoRoundedCorners = true;
            this.but_Downloads.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but_Downloads.BorderRadius = 55;
            this.but_Downloads.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.but_Downloads.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.but_Downloads.CustomizableEdges.BottomLeft = false;
            this.but_Downloads.CustomizableEdges.TopRight = false;
            this.but_Downloads.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_Downloads.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_Downloads.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_Downloads.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_Downloads.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.but_Downloads.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.but_Downloads.ForeColor = System.Drawing.Color.Black;
            this.but_Downloads.Location = new System.Drawing.Point(3, 239);
            this.but_Downloads.Name = "but_Downloads";
            this.but_Downloads.PressedColor = System.Drawing.SystemColors.ActiveBorder;
            this.but_Downloads.Size = new System.Drawing.Size(224, 112);
            this.but_Downloads.TabIndex = 3;
            this.but_Downloads.Text = "Downloads";
            this.but_Downloads.Click += new System.EventHandler(this.but_Downloads_Click);
            // 
            // Programs_flowLayoutPanel
            // 
            this.Programs_flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Programs_flowLayoutPanel.AutoScroll = true;
            this.Programs_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Programs_flowLayoutPanel.Location = new System.Drawing.Point(1, 33);
            this.Programs_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Programs_flowLayoutPanel.Name = "Programs_flowLayoutPanel";
            this.Programs_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Programs_flowLayoutPanel.Size = new System.Drawing.Size(855, 515);
            this.Programs_flowLayoutPanel.TabIndex = 1;
            this.Programs_flowLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Programs_flowLayoutPanel_ControlAdded);
            this.Programs_flowLayoutPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Programs_flowLayoutPanel_ControlRemoved);
            // 
            // content
            // 
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content.Controls.Add(this.Programs);
            this.content.Controls.Add(this.MyLibrary_panel);
            this.content.Controls.Add(this.Downloads_flowLayoutPanel);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(233, 61);
            this.content.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(857, 571);
            this.content.TabIndex = 5;
            // 
            // Programs
            // 
            this.Programs.Controls.Add(this.guna2Button8);
            this.Programs.Controls.Add(this.guna2Button7);
            this.Programs.Controls.Add(this.guna2Button6);
            this.Programs.Controls.Add(this.guna2Button5);
            this.Programs.Controls.Add(this.guna2Button4);
            this.Programs.Controls.Add(this.guna2Button3);
            this.Programs.Controls.Add(this.guna2Button2);
            this.Programs.Controls.Add(this.guna2Button1);
            this.Programs.Controls.Add(this.Programs_flowLayoutPanel);
            this.Programs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Programs.Location = new System.Drawing.Point(0, 0);
            this.Programs.Name = "Programs";
            this.Programs.Size = new System.Drawing.Size(855, 569);
            this.Programs.TabIndex = 1;
            // 
            // guna2Button8
            // 
            this.guna2Button8.AutoRoundedCorners = true;
            this.guna2Button8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button8.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button8.BorderRadius = 14;
            this.guna2Button8.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button8.CustomizableEdges.BottomLeft = false;
            this.guna2Button8.CustomizableEdges.BottomRight = false;
            this.guna2Button8.CustomizableEdges.TopLeft = false;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2Button8.Font = new System.Drawing.Font("Rockwell", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.Black;
            this.guna2Button8.Location = new System.Drawing.Point(743, 3);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(104, 30);
            this.guna2Button8.TabIndex = 0;
            this.guna2Button8.Text = "7";
            // 
            // guna2Button7
            // 
            this.guna2Button7.AutoRoundedCorners = true;
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button7.BorderRadius = 14;
            this.guna2Button7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button7.CustomizableEdges.BottomLeft = false;
            this.guna2Button7.CustomizableEdges.BottomRight = false;
            this.guna2Button7.CustomizableEdges.TopLeft = false;
            this.guna2Button7.CustomizableEdges.TopRight = false;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2Button7.Font = new System.Drawing.Font("Rockwell", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.Location = new System.Drawing.Point(637, 3);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(104, 30);
            this.guna2Button7.TabIndex = 0;
            this.guna2Button7.Text = "6";
            // 
            // guna2Button6
            // 
            this.guna2Button6.AutoRoundedCorners = true;
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button6.BorderRadius = 14;
            this.guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button6.CustomizableEdges.BottomLeft = false;
            this.guna2Button6.CustomizableEdges.BottomRight = false;
            this.guna2Button6.CustomizableEdges.TopLeft = false;
            this.guna2Button6.CustomizableEdges.TopRight = false;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2Button6.Font = new System.Drawing.Font("Rockwell", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.Location = new System.Drawing.Point(531, 3);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(104, 30);
            this.guna2Button6.TabIndex = 0;
            this.guna2Button6.Text = "5";
            // 
            // guna2Button5
            // 
            this.guna2Button5.AutoRoundedCorners = true;
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button5.BorderRadius = 14;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CustomizableEdges.BottomLeft = false;
            this.guna2Button5.CustomizableEdges.BottomRight = false;
            this.guna2Button5.CustomizableEdges.TopLeft = false;
            this.guna2Button5.CustomizableEdges.TopRight = false;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2Button5.Font = new System.Drawing.Font("Rockwell", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Location = new System.Drawing.Point(425, 3);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(104, 30);
            this.guna2Button5.TabIndex = 0;
            this.guna2Button5.Text = "4";
            // 
            // guna2Button4
            // 
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button4.BorderRadius = 14;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CustomizableEdges.BottomLeft = false;
            this.guna2Button4.CustomizableEdges.BottomRight = false;
            this.guna2Button4.CustomizableEdges.TopLeft = false;
            this.guna2Button4.CustomizableEdges.TopRight = false;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2Button4.Font = new System.Drawing.Font("Rockwell", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.Location = new System.Drawing.Point(319, 3);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(104, 30);
            this.guna2Button4.TabIndex = 0;
            this.guna2Button4.Text = "3";
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button3.BorderRadius = 14;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CustomizableEdges.BottomLeft = false;
            this.guna2Button3.CustomizableEdges.BottomRight = false;
            this.guna2Button3.CustomizableEdges.TopLeft = false;
            this.guna2Button3.CustomizableEdges.TopRight = false;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2Button3.Font = new System.Drawing.Font("Rockwell", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(213, 3);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(104, 30);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "Engineering";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button2.BorderRadius = 14;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CustomizableEdges.BottomLeft = false;
            this.guna2Button2.CustomizableEdges.BottomRight = false;
            this.guna2Button2.CustomizableEdges.TopLeft = false;
            this.guna2Button2.CustomizableEdges.TopRight = false;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2Button2.Font = new System.Drawing.Font("Rockwell", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(107, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(104, 30);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "Coding";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.Checked = true;
            this.guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button1.CustomizableEdges.BottomLeft = false;
            this.guna2Button1.CustomizableEdges.BottomRight = false;
            this.guna2Button1.CustomizableEdges.TopRight = false;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2Button1.Font = new System.Drawing.Font("Rockwell", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(1, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(104, 30);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "All";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MyLibrary_panel
            // 
            this.MyLibrary_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyLibrary_panel.Location = new System.Drawing.Point(0, 0);
            this.MyLibrary_panel.Name = "MyLibrary_panel";
            this.MyLibrary_panel.Size = new System.Drawing.Size(855, 569);
            this.MyLibrary_panel.TabIndex = 0;
            // 
            // Downloads_flowLayoutPanel
            // 
            this.Downloads_flowLayoutPanel.AutoScroll = true;
            this.Downloads_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Downloads_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Downloads_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Downloads_flowLayoutPanel.Name = "Downloads_flowLayoutPanel";
            this.Downloads_flowLayoutPanel.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Downloads_flowLayoutPanel.Size = new System.Drawing.Size(855, 569);
            this.Downloads_flowLayoutPanel.TabIndex = 2;
            this.Downloads_flowLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Downloads_flowLayoutPanel_ControlAdded);
            this.Downloads_flowLayoutPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Downloads_flowLayoutPanel_ControlRemoved);
            // 
            // settingsMenuForm
            // 
            this.settingsMenuForm.BackColor = System.Drawing.SystemColors.Control;
            this.settingsMenuForm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator3,
            this.profileSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkForUpdateToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.settingsMenuForm.Name = "contextMenuStrip1";
            this.settingsMenuForm.Size = new System.Drawing.Size(188, 132);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.importFileToolStripMenuItem,
            this.exportFileToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem2.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.importFileToolStripMenuItem.Text = "Import File";
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exportFileToolStripMenuItem.Text = "Export File";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // profileSettingsToolStripMenuItem
            // 
            this.profileSettingsToolStripMenuItem.Name = "profileSettingsToolStripMenuItem";
            this.profileSettingsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.profileSettingsToolStripMenuItem.Text = "Profile settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check updates...";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.LightSlateGray;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Controls.Add(this.label2);
            this.Title.Controls.Add(this.button3);
            this.Title.Controls.Add(this.but_Max_Min_Form);
            this.Title.Controls.Add(this.but_ُExite);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1090, 22);
            this.Title.TabIndex = 5;
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Programs";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1001, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 20);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // but_Max_Min_Form
            // 
            this.but_Max_Min_Form.BackgroundImage = global::StudentProgramCsharp.Properties.Resources.resize;
            this.but_Max_Min_Form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_Max_Min_Form.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_Max_Min_Form.FlatAppearance.BorderSize = 0;
            this.but_Max_Min_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Max_Min_Form.Location = new System.Drawing.Point(1030, 0);
            this.but_Max_Min_Form.Name = "but_Max_Min_Form";
            this.but_Max_Min_Form.Size = new System.Drawing.Size(29, 20);
            this.but_Max_Min_Form.TabIndex = 0;
            this.but_Max_Min_Form.UseVisualStyleBackColor = true;
            this.but_Max_Min_Form.Click += new System.EventHandler(this.button2_Click);
            // 
            // but_ُExite
            // 
            this.but_ُExite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_ُExite.BackgroundImage")));
            this.but_ُExite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_ُExite.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_ُExite.FlatAppearance.BorderSize = 0;
            this.but_ُExite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ُExite.Location = new System.Drawing.Point(1059, 0);
            this.but_ُExite.Name = "but_ُExite";
            this.but_ُExite.Size = new System.Drawing.Size(29, 20);
            this.but_ُExite.TabIndex = 0;
            this.but_ُExite.UseVisualStyleBackColor = true;
            this.but_ُExite.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1090, 632);
            this.ControlBox = false;
            this.Controls.Add(this.Info);
            this.Controls.Add(this.content);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Info.ResumeLayout(false);
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.Programs.ResumeLayout(false);
            this.settingsMenuForm.ResumeLayout(false);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel nav;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button but_Settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.FlowLayoutPanel Downloads_flowLayoutPanel;
        public System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label User_Name;
        private ContextMenuStrip settingsMenuForm;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem importFileToolStripMenuItem;
        private ToolStripMenuItem exportFileToolStripMenuItem;
        private ToolStripMenuItem profileSettingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox tb_Search;
        private ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private Label lab_NumberOfDownloads;
        private Panel Info;
        private Label lab_NumberOFLibrary;
        private Label lab_numOFprograms;
        private Panel MyLibrary_panel;
        private Panel Title;
        private Button button3;
        private Button but_Max_Min_Form;
        private Button but_ُExite;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button but_Programs;
        private Guna.UI2.WinForms.Guna2Button but_My_Library;
        private Guna.UI2.WinForms.Guna2Button but_Downloads;
        public FlowLayoutPanel Programs_flowLayoutPanel;
        private Panel Programs;
    }
}

