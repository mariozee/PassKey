using System.Windows.Forms;

namespace PassKey.Sliders.MenuSliders
{
    partial class BackupMenuSlider
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;       

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backupTextBox = new MetroFramework.Controls.MetroTextBox();
            this.restoreTextBox = new MetroFramework.Controls.MetroTextBox();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.browseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backupButton = new MetroFramework.Controls.MetroButton();
            this.restoreButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // backupTextBox
            // 
            // 
            // 
            // 
            this.backupTextBox.CustomButton.Image = null;
            this.backupTextBox.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.backupTextBox.CustomButton.Name = "";
            this.backupTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.backupTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.backupTextBox.CustomButton.TabIndex = 1;
            this.backupTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.backupTextBox.CustomButton.UseSelectable = true;
            this.backupTextBox.DisplayIcon = true;
            this.backupTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.backupTextBox.Lines = new string[0];
            this.backupTextBox.Location = new System.Drawing.Point(17, 149);
            this.backupTextBox.MaxLength = 32767;
            this.backupTextBox.Name = "backupTextBox";
            this.backupTextBox.PasswordChar = '\0';
            this.backupTextBox.PromptText = "Backup to...";
            this.backupTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.backupTextBox.SelectedText = "";
            this.backupTextBox.SelectionLength = 0;
            this.backupTextBox.SelectionStart = 0;
            this.backupTextBox.ShortcutsEnabled = true;
            this.backupTextBox.ShowButton = true;
            this.backupTextBox.Size = new System.Drawing.Size(188, 25);
            this.backupTextBox.TabIndex = 0;
            this.backupTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backupTextBox.UseSelectable = true;
            this.backupTextBox.WaterMark = "Backup to...";
            this.backupTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.backupTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // restoreTextBox
            // 
            // 
            // 
            // 
            this.restoreTextBox.CustomButton.Image = null;
            this.restoreTextBox.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.restoreTextBox.CustomButton.Name = "";
            this.restoreTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.restoreTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.restoreTextBox.CustomButton.TabIndex = 1;
            this.restoreTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.restoreTextBox.CustomButton.UseSelectable = true;
            this.restoreTextBox.DisplayIcon = true;
            this.restoreTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.restoreTextBox.Lines = new string[0];
            this.restoreTextBox.Location = new System.Drawing.Point(17, 262);
            this.restoreTextBox.MaxLength = 32767;
            this.restoreTextBox.Name = "restoreTextBox";
            this.restoreTextBox.PasswordChar = '\0';
            this.restoreTextBox.PromptText = "Restore from...";
            this.restoreTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.restoreTextBox.SelectedText = "";
            this.restoreTextBox.SelectionLength = 0;
            this.restoreTextBox.SelectionStart = 0;
            this.restoreTextBox.ShortcutsEnabled = true;
            this.restoreTextBox.ShowButton = true;
            this.restoreTextBox.Size = new System.Drawing.Size(188, 25);
            this.restoreTextBox.TabIndex = 1;
            this.restoreTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.restoreTextBox.UseSelectable = true;
            this.restoreTextBox.WaterMark = "Restore from...";
            this.restoreTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.restoreTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(78, 420);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(78, 180);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(75, 23);
            this.backupButton.TabIndex = 3;
            this.backupButton.Text = "Backup";
            this.backupButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backupButton.UseSelectable = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(78, 293);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 23);
            this.restoreButton.TabIndex = 4;
            this.restoreButton.Text = "Restore";
            this.restoreButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.restoreButton.UseSelectable = true;
            // 
            // BackupRestoreMenuSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.restoreTextBox);
            this.Controls.Add(this.backupTextBox);
            this.Name = "BackupRestoreMenuSlider";
            this.Size = new System.Drawing.Size(240, 500);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox backupTextBox;
        private MetroFramework.Controls.MetroTextBox restoreTextBox;
        private MetroFramework.Controls.MetroButton closeButton;
        private FolderBrowserDialog browseDialog;
        private MetroFramework.Controls.MetroButton backupButton;
        private MetroFramework.Controls.MetroButton restoreButton;
    }
}
