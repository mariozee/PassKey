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
using MetroFramework.Controls;

namespace PassKey.Sliders.MenuSliders
{
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

        private void RestoreTextBox_ButtonClick(object sender, EventArgs e)
        {
            this.browseDialog.ShowDialog();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.backupTextBox.Text))
            {
                string[] data = RegistryData.GetDataForBackup(this.User.Username);
                string path = this.backupTextBox.Text + "\\" + $"{this.User.Username}_backup.dat";
                File.WriteAllLines(path, data);
                MetroMessageBox.Show(this
                    , string.Empty
                    , "Backup complete!"
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
