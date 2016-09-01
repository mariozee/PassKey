namespace PassKey
{
    using System;
    using System.Windows.Forms;
    using MetroFramework.Forms;
    using System.Diagnostics;

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