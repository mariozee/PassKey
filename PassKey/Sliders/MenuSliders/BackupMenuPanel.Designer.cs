using System.Windows.Forms;

namespace PassKey.Sliders.MenuSliders
{
    partial class BackupMenuPanel
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
            this.browseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backupButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeLink = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backupTextBox
            // 
            // 
            // 
            // 
            this.backupTextBox.CustomButton.Image = global::PassKey.Properties.Resources.magnifierB;
            this.backupTextBox.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.backupTextBox.CustomButton.Name = "";
            this.backupTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.backupTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.backupTextBox.CustomButton.TabIndex = 1;
            this.backupTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.backupTextBox.CustomButton.UseSelectable = true;
            this.backupTextBox.DisplayIcon = true;
            this.backupTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.backupTextBox.Icon = global::PassKey.Properties.Resources.magnifier;
            this.backupTextBox.Lines = new string[0];
            this.backupTextBox.Location = new System.Drawing.Point(26, 80);
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
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(83, 140);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(75, 23);
            this.backupButton.TabIndex = 3;
            this.backupButton.Text = "Backup";
            this.backupButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backupButton.UseSelectable = true;
            this.backupButton.UseStyleColors = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PassKey.Properties.Resources.backup;
            this.pictureBox1.Location = new System.Drawing.Point(19, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // closeLink
            // 
            this.closeLink.BackColor = System.Drawing.Color.Transparent;
            this.closeLink.Image = global::PassKey.Properties.Resources.back_Enabled;
            this.closeLink.ImageSize = 36;
            this.closeLink.Location = new System.Drawing.Point(193, 14);
            this.closeLink.Name = "closeLink";
            this.closeLink.NoFocusImage = global::PassKey.Properties.Resources.back_Disabled;
            this.closeLink.Size = new System.Drawing.Size(44, 36);
            this.closeLink.TabIndex = 8;
            this.closeLink.UseCustomBackColor = true;
            this.closeLink.UseSelectable = true;
            this.closeLink.Click += new System.EventHandler(this.closeLink_Click);
            // 
            // BackupMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeLink);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.backupTextBox);
            this.Name = "BackupMenuPanel";
            this.Size = new System.Drawing.Size(240, 400);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox backupTextBox;
        private FolderBrowserDialog browseDialog;
        private MetroFramework.Controls.MetroButton backupButton;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink closeLink;
    }
}
