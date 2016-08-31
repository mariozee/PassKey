using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PassKey.SecurityUtilities;
using MetroFramework;
using PassKey.Data;
using MetroFramework.Controls;

namespace PassKey.Sliders
{
    public partial class RestorePanel : BaseSliderPanel
    {
        private const int OpenXConst = 435;
        private const int OpenYConst = 500;
        private const int ClosedXConst = 435;
        private const int ClosedYConst = 600;
        private const string TransitionDirectionConst = "Top";
        private const int TransitionAccelerationConst = 500;
        private const int DestinationOpenConst = 500;
        private const int DestinationClosedConst = 600;

        private LoginPanel loginPanel;

        public RestorePanel(Form form, LoginPanel loginPanel)
            : base(form, OpenXConst, OpenYConst, ClosedXConst, ClosedYConst, TransitionDirectionConst
                  , TransitionAccelerationConst, DestinationOpenConst, DestinationClosedConst)
        {
            InitializeComponent();
            this.restoreTextBox.ButtonClick += RestoreTextBox_ButtonClick;
            this.loginPanel = loginPanel;
            this.restoreButton.UseSelectable = false;
        }

        private void RestoreTextBox_ButtonClick(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "All Files(*.dat) | *.dat";
            this.openFileDialog.ShowDialog();
            this.restoreTextBox.Text = this.openFileDialog.FileName;
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.restoreTextBox.Text))
            {
                string[] enryptedData = File.ReadAllLines(this.restoreTextBox.Text);
                string backupMark = CryptographicUtilities.Decrypt(enryptedData[0], Constants.backUpKey);
                if (backupMark == Constants.BackupMark)
                {
                    RegistryData.SetRestoredData(enryptedData);

                    MetroMessageBox.Show(this.MainForm, string.Empty, "Restore completed!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information, 80);

                    this.loginPanel.Enabled = true;
                    this.loginPanel.Refresh();
                    this.Swipe(false);
                }
                else
                {
                    MetroMessageBox.Show(this.MainForm, string.Empty, "Wrong or corrupted data file!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error, 80);
                }               
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.loginPanel.Enabled = true;
            this.loginPanel.Refresh();
            this.Swipe(false);
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.loginPanel.Enabled = true;
            this.loginPanel.Refresh();
            this.Swipe(false);
        }
    }
}
