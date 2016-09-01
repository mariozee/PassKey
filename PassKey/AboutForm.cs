using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;

namespace PassKey
{
    public partial class AboutForm : MetroForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void closeLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gmailLink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Constants.MyEmail);
        }

        private void githubLink_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.GitHubPage);
        }
    }
}
