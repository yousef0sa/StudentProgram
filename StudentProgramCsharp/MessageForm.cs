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



        private bool _status = false;

        //get set
        public bool Status 
        {
            get { return _status; }
            set { _status = value; } 
        }


        //title name
        public void title(String title)
        { 
            Text = title;
        }
        //message
        public void message(String message)
        {
            label1.Text= message;
        }

        //checkBox Checked Changed
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DontShow = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        //OK Button
        private void Ok_Click(object sender, EventArgs e)
        {
            Status = true ;
            Close();
        }

        //Cancel
        private void Cancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
