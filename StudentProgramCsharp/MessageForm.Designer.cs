namespace StudentProgramCsharp
{
    partial class MessageForm
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
            this.Ok = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ok.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.Ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ok.ForeColor = System.Drawing.Color.Black;
            this.Ok.Location = new System.Drawing.Point(24, 81);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(89, 35);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancel.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(160, 81);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(89, 35);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Don\'t show this message again";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(281, 122);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Programs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Ok;
        private Guna.UI2.WinForms.Guna2Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}