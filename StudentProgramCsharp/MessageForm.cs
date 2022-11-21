using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProgramCsharp
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }


        public bool _status = false;


        //change status to true
        public void status_change()
        {
            _status = true;
        }

        //title name
        public void title(String title)
        { 
            this.Text = title;
        }
        //message
        public void message(String message)
        {
            label1.Text= message;
        }

        //checkBox Checked Changed
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DontShow = this.checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        //Ok
        private void Ok_Click(object sender, EventArgs e)
        {
            status_change();
            this.Close();
        }

        //Cancel
        private void Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
