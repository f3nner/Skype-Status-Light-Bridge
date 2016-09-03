using System;
using System.Windows.Forms;

namespace LyncPresenceBridge
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void buttonAboutOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.hackster.io/matheus-fenner/skype-status-light-c2df6c");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/f3nner/Skype-Status-Light-Bridge");
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
