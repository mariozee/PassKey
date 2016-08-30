using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassKey.UserInfo;
using PassKey.Data;
using System.IO;
using MetroFramework;

namespace PassKey.Sliders.MenuSliders
{
    public partial class BackupMenuSlider : AbstractMenuSlider
    {
        public BackupMenuSlider(Form form, LoggedUser user)
            : base(form, user)
        {
            InitializeComponent();
            this.restoreTextBox.ButtonClick += RestoreTextBox_ButtonClick;
            this.backupTextBox.ButtonClick += BackupTextBox_ButtonClick;
        }


        private void BackupTextBox_ButtonClick(object sender, EventArgs e)
        {
            this.browseDialog.ShowDialog();
            this.backupTextBox.Text = this.browseDialog.SelectedPath;
        }

        private void RestoreTextBox_ButtonClick(object sender, EventArgs e)
        {
            this.browseDialog.ShowDialog();
            this.restoreTextBox.Text = this.browseDialog.SelectedPath;
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.backupTextBox.Text))
            {
                string[] data = RegistryData.GetDataForBackup(this.User.Username);
                string path = this.backupTextBox.Text + "\\" + "backup.dat";
                File.WriteAllLines(path, data);
                MetroMessageBox.Show(this
                    , string.Empty
                    , "Backup complete!"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    , 80);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Swipe(false);
        }
    }
}
