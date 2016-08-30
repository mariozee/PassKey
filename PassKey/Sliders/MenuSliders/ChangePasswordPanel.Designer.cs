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
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.oldPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newPassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.confirmNewPassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.oldPassLabel = new MetroFramework.Controls.MetroLabel();
            this.newPassLabel1 = new MetroFramework.Controls.MetroLabel();
            this.newPassLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(13, 423);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 0;
            this.changeButton.Text = "Change";
            this.changeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.changeButton.UseSelectable = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(119, 423);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.oldPasswordTextBox.Location = new System.Drawing.Point(25, 113);
            this.oldPasswordTextBox.MaxLength = 32767;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '\0';
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
            this.newPassTextBox.Location = new System.Drawing.Point(25, 192);
            this.newPassTextBox.MaxLength = 32767;
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.PasswordChar = '\0';
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
            this.confirmNewPassTextBox.Location = new System.Drawing.Point(25, 271);
            this.confirmNewPassTextBox.MaxLength = 32767;
            this.confirmNewPassTextBox.Name = "confirmNewPassTextBox";
            this.confirmNewPassTextBox.PasswordChar = '\0';
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
            this.confirmNewPassTextBox.WaterMark = "Confirm new password";
            this.confirmNewPassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmNewPassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.AutoSize = true;
            this.oldPassLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.oldPassLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.oldPassLabel.Location = new System.Drawing.Point(59, 95);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(94, 15);
            this.oldPassLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.oldPassLabel.TabIndex = 5;
            this.oldPassLabel.Text = "wrong password";
            this.oldPassLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.oldPassLabel.UseStyleColors = true;
            this.oldPassLabel.Visible = false;
            // 
            // newPassLabel1
            // 
            this.newPassLabel1.AutoSize = true;
            this.newPassLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.newPassLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.newPassLabel1.Location = new System.Drawing.Point(59, 174);
            this.newPassLabel1.Name = "newPassLabel1";
            this.newPassLabel1.Size = new System.Drawing.Size(118, 15);
            this.newPassLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.newPassLabel1.TabIndex = 6;
            this.newPassLabel1.Text = "passwords mismatch";
            this.newPassLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.newPassLabel1.UseStyleColors = true;
            this.newPassLabel1.Visible = false;
            // 
            // newPassLabel2
            // 
            this.newPassLabel2.AutoSize = true;
            this.newPassLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.newPassLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.newPassLabel2.Location = new System.Drawing.Point(13, 174);
            this.newPassLabel2.Name = "newPassLabel2";
            this.newPassLabel2.Size = new System.Drawing.Size(194, 15);
            this.newPassLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.newPassLabel2.TabIndex = 7;
            this.newPassLabel2.Text = "lenght must be atleast 8 chararcters";
            this.newPassLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.newPassLabel2.UseStyleColors = true;
            this.newPassLabel2.Visible = false;
            // 
            // ChangePasswordPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newPassLabel2);
            this.Controls.Add(this.newPassLabel1);
            this.Controls.Add(this.oldPassLabel);
            this.Controls.Add(this.confirmNewPassTextBox);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.changeButton);
            this.Name = "ChangePasswordPanel";
            this.Size = new System.Drawing.Size(240, 500);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton changeButton;
        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroTextBox oldPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox newPassTextBox;
        private MetroFramework.Controls.MetroTextBox confirmNewPassTextBox;
        private MetroFramework.Controls.MetroLabel oldPassLabel;
        private MetroFramework.Controls.MetroLabel newPassLabel1;
        private MetroFramework.Controls.MetroLabel newPassLabel2;
    }
}
