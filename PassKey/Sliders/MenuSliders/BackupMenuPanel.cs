namespace PassKey.Sliders.MenuSliders
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using MetroFramework;
    using UserInfo;
    using Data;

    public partial class BackupMenuPanel : BaseMenuSliderPanel
    {
        public BackupMenuPanel(Form form, LoggedUser user)
            : base(form, user)
        {
            InitializeComponent();
            this.backupButton.UseSelectable = false;
            this.backupTextBox.ButtonClick += BackupTextBox_ButtonClick;
        }


        private void BackupTextBox_ButtonClick(object sender, EventArgs e)
        {
            this.browseDialog.ShowDialog();
            this.backupTextBox.Text = this.browseDialog.SelectedPath;
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.backupTextBox.Text))
            {
                string[] data = RegistryData.GetDataForBackup(this.User.Username);
                string path = this.backupTextBox.Text + "\\" + 
                    string.Format(Constants.BackupFileName, this.User.Username);

                File.WriteAllLines(path, data);
                MetroMessageBox.Show(this
                    , string.Empty
                    , GlobalMessages.BackupComplete
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    , 80);

                this.Swipe(false);
            }
        }

        private void closeLink_Click(object sender, EventArgs e)
        {
            this.Swipe(false);
        }
    }
}
