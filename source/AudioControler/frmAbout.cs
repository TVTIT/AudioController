using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AudioController
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("trungtran200656@gmail.com");
            MessageBox.Show("Email của mình là: trungtran200656@gmail.com\nĐã copy email này vào clipboard", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFb_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/trung.thethis");
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/TVTIT");
        }
    }
}
