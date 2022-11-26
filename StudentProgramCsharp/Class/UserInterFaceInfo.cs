using System;
using System.Windows.Forms;

namespace StudentProgramCsharp.Class
{
    internal class UserInterFaceInfo
    {
        private string userName { get; set; }

        //return user name [default commuter name]
        public void UserName(Label Into)
        {
            Into.Text = Environment.MachineName;
        }

        //cunt Programs page items from FlowLayoutPanel to Label
        public void ProgramsItemsCunter(FlowLayoutPanel From, Label Into)
        {
            Into.Text = "Programs: " + From.Controls.Count + " |";
        }

        //cunt Download page items from FlowLayoutPanel to Label
        public void DownloadsItemsCunter(FlowLayoutPanel From, Label Into)
        {
            Into.Text = "Downloads: " + From.Controls.Count + " |";
        }

    }
}
