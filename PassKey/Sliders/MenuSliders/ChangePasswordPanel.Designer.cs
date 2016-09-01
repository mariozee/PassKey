using System.Windows.Forms;

namespace PassKey.Sliders.MenuSliders
{
    partial class ChangePasswordPanel
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
            this.changeButton = new MetroFramework.Controls.MetroButton();
            this.oldPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newPassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.confirmNewPassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.oldPassLabel = new MetroFramework.Controls.MetroLabel();
            this.newPassLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backLink = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(83, 260);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 0;
            this.changeButton.Text = "Change";
            this.changeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.changeButton.UseSelectable = true;
            this.changeButton.UseStyleColors = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // oldPasswordTextBox
            // 
            // 
            // 
            // 
            this.oldPasswordTextBox.CustomButton.Image = null;
            this.oldPasswordTextBox.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.oldPasswordTextBox.CustomButton.Name = "";
            this.oldPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.oldPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.oldPasswordTextBox.CustomButton.TabIndex = 1;
            this.oldPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.oldPasswordTextBox.CustomButton.UseSelectable = true;
            this.oldPasswordTextBox.CustomButton.Visible = false;
            this.oldPasswordTextBox.Lines = new string[0];
            this.oldPasswordTextBox.Location = new System.Drawing.Point(36, 80);
            this.oldPasswordTextBox.MaxLength = 32767;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '●';
            this.oldPasswordTextBox.PromptText = "Old password";
            this.oldPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oldPasswordTextBox.SelectedText = "";
            this.oldPasswordTextBox.SelectionLength = 0;
            this.oldPasswordTextBox.SelectionStart = 0;
            this.oldPasswordTextBox.ShortcutsEnabled = true;
            this.oldPasswordTextBox.Size = new System.Drawing.Size(169, 23);
            this.oldPasswordTextBox.TabIndex = 2;
            this.oldPasswordTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.oldPasswordTextBox.UseSelectable = true;
            this.oldPasswordTextBox.UseSystemPasswordChar = true;
            this.oldPasswordTextBox.WaterMark = "Old password";
            this.oldPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oldPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newPassTextBox
            // 
            // 
            // 
            // 
            this.newPassTextBox.CustomButton.Image = null;
            this.newPassTextBox.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.newPassTextBox.CustomButton.Name = "";
            this.newPassTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newPassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newPassTextBox.CustomButton.TabIndex = 1;
            this.newPassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newPassTextBox.CustomButton.UseSelectable = true;
            this.newPassTextBox.CustomButton.Visible = false;
            this.newPassTextBox.Lines = new string[0];
            this.newPassTextBox.Location = new System.Drawing.Point(36, 140);
            this.newPassTextBox.MaxLength = 32767;
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.PasswordChar = '●';
            this.newPassTextBox.PromptText = "New password";
            this.newPassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newPassTextBox.SelectedText = "";
            this.newPassTextBox.SelectionLength = 0;
            this.newPassTextBox.SelectionStart = 0;
            this.newPassTextBox.ShortcutsEnabled = true;
            this.newPassTextBox.Size = new System.Drawing.Size(169, 23);
            this.newPassTextBox.TabIndex = 3;
            this.newPassTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.newPassTextBox.UseSelectable = true;
            this.newPassTextBox.UseSystemPasswordChar = true;
            this.newPassTextBox.WaterMark = "New password";
            this.newPassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newPassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confirmNewPassTextBox
            // 
            // 
            // 
            // 
            this.confirmNewPassTextBox.CustomButton.Image = null;
            this.confirmNewPassTextBox.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.confirmNewPassTextBox.CustomButton.Name = "";
            this.confirmNewPassTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirmNewPassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmNewPassTextBox.CustomButton.TabIndex = 1;
            this.confirmNewPassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmNewPassTextBox.CustomButton.UseSelectable = true;
            this.confirmNewPassTextBox.CustomButton.Visible = false;
            this.confirmNewPassTextBox.Lines = new string[0];
            this.confirmNewPassTextBox.Location = new System.Drawing.Point(36, 200);
            this.confirmNewPassTextBox.MaxLength = 32767;
            this.confirmNewPassTextBox.Name = "confirmNewPassTextBox";
            this.confirmNewPassTextBox.PasswordChar = '●';
            this.confirmNewPassTextBox.PromptText = "Confirm new password";
            this.confirmNewPassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmNewPassTextBox.SelectedText = "";
            this.confirmNewPassTextBox.SelectionLength = 0;
            this.confirmNewPassTextBox.SelectionStart = 0;
            this.confirmNewPassTextBox.ShortcutsEnabled = true;
            this.confirmNewPassTextBox.Size = new System.Drawing.Size(169, 23);
            this.confirmNewPassTextBox.TabIndex = 4;
            this.confirmNewPassTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.confirmNewPassTextBox.UseSelectable = true;
            this.confirmNewPassTextBox.UseSystemPasswordChar = true;
            this.confirmNewPassTextBox.WaterMark = "Confirm new password";
            this.confirmNewPassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmNewPassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.oldPassLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.oldPassLabel.Location = new System.Drawing.Point(0, 62);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(237, 15);
            this.oldPassLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.oldPassLabel.TabIndex = 5;
            this.oldPassLabel.Text = "error here";
            this.oldPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.oldPassLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.oldPassLabel.UseStyleColors = true;
            this.oldPassLabel.Visible = false;
            // 
            // newPassLabel
            // 
            this.newPassLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.newPassLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.newPassLabel.Location = new System.Drawing.Point(0, 122);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(237, 15);
            this.newPassLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.newPassLabel.TabIndex = 7;
            this.newPassLabel.Text = "erorr here";
            this.newPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newPassLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.newPassLabel.UseStyleColors = true;
            this.newPassLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PassKey.Properties.Resources.changePass;
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // backLink
            // 
            this.backLink.BackColor = System.Drawing.Color.Transparent;
            this.backLink.Image = global::PassKey.Properties.Resources.back_Enabled;
            this.backLink.ImageSize = 36;
            this.backLink.Location = new System.Drawing.Point(193, 14);
            this.backLink.Name = "backLink";
            this.backLink.NoFocusImage = global::PassKey.Properties.Resources.back_Disabled;
            this.backLink.Size = new System.Drawing.Size(44, 36);
            this.backLink.TabIndex = 8;
            this.backLink.UseCustomBackColor = true;
            this.backLink.UseSelectable = true;
            this.backLink.Click += new System.EventHandler(this.backLink_Click);
            // 
            // ChangePasswordPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.newPassLabel);
            this.Controls.Add(this.oldPassLabel);
            this.Controls.Add(this.confirmNewPassTextBox);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.changeButton);
            this.Name = "ChangePasswordPanel";
            this.Size = new System.Drawing.Size(240, 400);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton changeButton;
        private MetroFramework.Controls.MetroTextBox oldPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox newPassTextBox;
        private MetroFramework.Controls.MetroTextBox confirmNewPassTextBox;
        private MetroFramework.Controls.MetroLabel oldPassLabel;
        private MetroFramework.Controls.MetroLabel newPassLabel;
        private MetroFramework.Controls.MetroLink backLink;
        private PictureBox pictureBox1;
    }
}
