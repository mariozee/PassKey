using System.Windows.Forms;

namespace PassKey.Sliders
{
    partial class LoginPanel
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
            this.passRegLabel = new MetroFramework.Controls.MetroLabel();
            this.userRegLabel = new MetroFramework.Controls.MetroLabel();
            this.passLabel = new MetroFramework.Controls.MetroLabel();
            this.userLabel = new MetroFramework.Controls.MetroLabel();
            this.restoreLink = new MetroFramework.Controls.MetroLink();
            this.logButton = new MetroFramework.Controls.MetroButton();
            this.regButton = new MetroFramework.Controls.MetroButton();
            this.logingLabel = new MetroFramework.Controls.MetroLabel();
            this.registerLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.passowrdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.confirmPassRegTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passRegTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userRegTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // passRegLabel
            // 
            this.passRegLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.passRegLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.passRegLabel.Location = new System.Drawing.Point(3, 197);
            this.passRegLabel.Name = "passRegLabel";
            this.passRegLabel.Size = new System.Drawing.Size(255, 15);
            this.passRegLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.passRegLabel.TabIndex = 12;
            this.passRegLabel.Text = "error here";
            this.passRegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passRegLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passRegLabel.UseStyleColors = true;
            this.passRegLabel.Visible = false;
            // 
            // userRegLabel
            // 
            this.userRegLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.userRegLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.userRegLabel.Location = new System.Drawing.Point(0, 132);
            this.userRegLabel.Name = "userRegLabel";
            this.userRegLabel.Size = new System.Drawing.Size(264, 15);
            this.userRegLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.userRegLabel.TabIndex = 11;
            this.userRegLabel.Text = "error here";
            this.userRegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userRegLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userRegLabel.UseStyleColors = true;
            this.userRegLabel.Visible = false;
            // 
            // passLabel
            // 
            this.passLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.passLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.passLabel.Location = new System.Drawing.Point(493, 232);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(180, 15);
            this.passLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.passLabel.TabIndex = 10;
            this.passLabel.Text = "error here";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passLabel.UseStyleColors = true;
            this.passLabel.Visible = false;
            // 
            // userLabel
            // 
            this.userLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.userLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.userLabel.Location = new System.Drawing.Point(493, 167);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(180, 15);
            this.userLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.userLabel.TabIndex = 9;
            this.userLabel.Text = "error here";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userLabel.UseStyleColors = true;
            this.userLabel.Visible = false;
            // 
            // restoreLink
            // 
            this.restoreLink.BackColor = System.Drawing.Color.Transparent;
            this.restoreLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.restoreLink.Location = new System.Drawing.Point(531, 330);
            this.restoreLink.Name = "restoreLink";
            this.restoreLink.Size = new System.Drawing.Size(111, 23);
            this.restoreLink.TabIndex = 8;
            this.restoreLink.Text = "Restore account";
            this.restoreLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.restoreLink.UseCustomBackColor = true;
            this.restoreLink.UseSelectable = true;
            this.restoreLink.Click += new System.EventHandler(this.restoreLink_Click);
            this.restoreLink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.restoreLink_MouseDown);
            this.restoreLink.MouseEnter += new System.EventHandler(this.restoreLink_MouseEnter);
            this.restoreLink.MouseLeave += new System.EventHandler(this.restoreLink_MouseLeave);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(547, 300);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 23);
            this.logButton.TabIndex = 3;
            this.logButton.Text = "Login";
            this.logButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.logButton.UseSelectable = true;
            this.logButton.UseStyleColors = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(93, 330);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 7;
            this.regButton.Text = "Register";
            this.regButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.regButton.UseSelectable = true;
            this.regButton.UseStyleColors = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // logingLabel
            // 
            this.logingLabel.AutoSize = true;
            this.logingLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.logingLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.logingLabel.Location = new System.Drawing.Point(556, 132);
            this.logingLabel.Name = "logingLabel";
            this.logingLabel.Size = new System.Drawing.Size(56, 25);
            this.logingLabel.TabIndex = 5;
            this.logingLabel.Text = "Login";
            this.logingLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.logingLabel.UseStyleColors = true;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.registerLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.registerLabel.Location = new System.Drawing.Point(92, 94);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(76, 25);
            this.registerLabel.TabIndex = 4;
            this.registerLabel.Text = "Register";
            this.registerLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.registerLabel.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(264, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1, 450);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLink2
            // 
            this.metroLink2.BackColor = System.Drawing.Color.Transparent;
            this.metroLink2.Image = global::PassKey.Properties.Resources.login;
            this.metroLink2.ImageSize = 46;
            this.metroLink2.Location = new System.Drawing.Point(493, 118);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.NoFocusImage = global::PassKey.Properties.Resources.login;
            this.metroLink2.Size = new System.Drawing.Size(46, 46);
            this.metroLink2.TabIndex = 15;
            this.metroLink2.UseCustomBackColor = true;
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.Image = global::PassKey.Properties.Resources.register;
            this.metroLink1.ImageSize = 46;
            this.metroLink1.Location = new System.Drawing.Point(37, 83);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.NoFocusImage = global::PassKey.Properties.Resources.register;
            this.metroLink1.Size = new System.Drawing.Size(46, 46);
            this.metroLink1.TabIndex = 14;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // passowrdTextBox
            // 
            // 
            // 
            // 
            this.passowrdTextBox.CustomButton.Image = null;
            this.passowrdTextBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.passowrdTextBox.CustomButton.Name = "";
            this.passowrdTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.passowrdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passowrdTextBox.CustomButton.TabIndex = 1;
            this.passowrdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passowrdTextBox.CustomButton.UseSelectable = true;
            this.passowrdTextBox.CustomButton.Visible = false;
            this.passowrdTextBox.DisplayIcon = true;
            this.passowrdTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passowrdTextBox.Icon = global::PassKey.Properties.Resources.password;
            this.passowrdTextBox.Lines = new string[0];
            this.passowrdTextBox.Location = new System.Drawing.Point(495, 250);
            this.passowrdTextBox.MaxLength = 32767;
            this.passowrdTextBox.Name = "passowrdTextBox";
            this.passowrdTextBox.PasswordChar = '●';
            this.passowrdTextBox.PromptText = "Password";
            this.passowrdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passowrdTextBox.SelectedText = "";
            this.passowrdTextBox.SelectionLength = 0;
            this.passowrdTextBox.SelectionStart = 0;
            this.passowrdTextBox.ShortcutsEnabled = true;
            this.passowrdTextBox.Size = new System.Drawing.Size(178, 25);
            this.passowrdTextBox.TabIndex = 2;
            this.passowrdTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passowrdTextBox.UseSelectable = true;
            this.passowrdTextBox.UseSystemPasswordChar = true;
            this.passowrdTextBox.WaterMark = "Password";
            this.passowrdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passowrdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userNameTextBox
            // 
            // 
            // 
            // 
            this.userNameTextBox.CustomButton.Image = null;
            this.userNameTextBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.userNameTextBox.CustomButton.Name = "";
            this.userNameTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.userNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameTextBox.CustomButton.TabIndex = 1;
            this.userNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameTextBox.CustomButton.UseSelectable = true;
            this.userNameTextBox.CustomButton.Visible = false;
            this.userNameTextBox.DisplayIcon = true;
            this.userNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userNameTextBox.Icon = global::PassKey.Properties.Resources.username;
            this.userNameTextBox.Lines = new string[0];
            this.userNameTextBox.Location = new System.Drawing.Point(495, 185);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.PromptText = "Username";
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.ShortcutsEnabled = true;
            this.userNameTextBox.Size = new System.Drawing.Size(178, 25);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userNameTextBox.UseSelectable = true;
            this.userNameTextBox.WaterMark = "Username";
            this.userNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confirmPassRegTextBox
            // 
            // 
            // 
            // 
            this.confirmPassRegTextBox.CustomButton.Image = null;
            this.confirmPassRegTextBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.confirmPassRegTextBox.CustomButton.Name = "";
            this.confirmPassRegTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.confirmPassRegTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmPassRegTextBox.CustomButton.TabIndex = 1;
            this.confirmPassRegTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmPassRegTextBox.CustomButton.UseSelectable = true;
            this.confirmPassRegTextBox.CustomButton.Visible = false;
            this.confirmPassRegTextBox.DisplayIcon = true;
            this.confirmPassRegTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.confirmPassRegTextBox.Icon = global::PassKey.Properties.Resources.password;
            this.confirmPassRegTextBox.Lines = new string[0];
            this.confirmPassRegTextBox.Location = new System.Drawing.Point(43, 280);
            this.confirmPassRegTextBox.MaxLength = 32767;
            this.confirmPassRegTextBox.Name = "confirmPassRegTextBox";
            this.confirmPassRegTextBox.PasswordChar = '●';
            this.confirmPassRegTextBox.PromptText = "Confirm password";
            this.confirmPassRegTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmPassRegTextBox.SelectedText = "";
            this.confirmPassRegTextBox.SelectionLength = 0;
            this.confirmPassRegTextBox.SelectionStart = 0;
            this.confirmPassRegTextBox.ShortcutsEnabled = true;
            this.confirmPassRegTextBox.Size = new System.Drawing.Size(178, 25);
            this.confirmPassRegTextBox.TabIndex = 6;
            this.confirmPassRegTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.confirmPassRegTextBox.UseSelectable = true;
            this.confirmPassRegTextBox.UseSystemPasswordChar = true;
            this.confirmPassRegTextBox.WaterMark = "Confirm password";
            this.confirmPassRegTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmPassRegTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passRegTextBox
            // 
            // 
            // 
            // 
            this.passRegTextBox.CustomButton.Image = null;
            this.passRegTextBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.passRegTextBox.CustomButton.Name = "";
            this.passRegTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.passRegTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passRegTextBox.CustomButton.TabIndex = 1;
            this.passRegTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passRegTextBox.CustomButton.UseSelectable = true;
            this.passRegTextBox.CustomButton.Visible = false;
            this.passRegTextBox.DisplayIcon = true;
            this.passRegTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passRegTextBox.Icon = global::PassKey.Properties.Resources.password;
            this.passRegTextBox.Lines = new string[0];
            this.passRegTextBox.Location = new System.Drawing.Point(43, 215);
            this.passRegTextBox.MaxLength = 32767;
            this.passRegTextBox.Name = "passRegTextBox";
            this.passRegTextBox.PasswordChar = '●';
            this.passRegTextBox.PromptText = "Password";
            this.passRegTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passRegTextBox.SelectedText = "";
            this.passRegTextBox.SelectionLength = 0;
            this.passRegTextBox.SelectionStart = 0;
            this.passRegTextBox.ShortcutsEnabled = true;
            this.passRegTextBox.Size = new System.Drawing.Size(178, 25);
            this.passRegTextBox.TabIndex = 5;
            this.passRegTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passRegTextBox.UseSelectable = true;
            this.passRegTextBox.UseSystemPasswordChar = true;
            this.passRegTextBox.WaterMark = "Password";
            this.passRegTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passRegTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userRegTextBox
            // 
            // 
            // 
            // 
            this.userRegTextBox.CustomButton.Image = null;
            this.userRegTextBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.userRegTextBox.CustomButton.Name = "";
            this.userRegTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.userRegTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userRegTextBox.CustomButton.TabIndex = 1;
            this.userRegTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userRegTextBox.CustomButton.UseSelectable = true;
            this.userRegTextBox.CustomButton.Visible = false;
            this.userRegTextBox.DisplayIcon = true;
            this.userRegTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userRegTextBox.Icon = global::PassKey.Properties.Resources.username;
            this.userRegTextBox.Lines = new string[0];
            this.userRegTextBox.Location = new System.Drawing.Point(43, 150);
            this.userRegTextBox.MaxLength = 32767;
            this.userRegTextBox.Name = "userRegTextBox";
            this.userRegTextBox.PasswordChar = '\0';
            this.userRegTextBox.PromptText = "Username";
            this.userRegTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userRegTextBox.SelectedText = "";
            this.userRegTextBox.SelectionLength = 0;
            this.userRegTextBox.SelectionStart = 0;
            this.userRegTextBox.ShortcutsEnabled = true;
            this.userRegTextBox.Size = new System.Drawing.Size(178, 25);
            this.userRegTextBox.TabIndex = 4;
            this.userRegTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userRegTextBox.UseSelectable = true;
            this.userRegTextBox.WaterMark = "Username";
            this.userRegTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userRegTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.passRegLabel);
            this.Controls.Add(this.userRegLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.restoreLink);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.passowrdTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.logingLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.confirmPassRegTextBox);
            this.Controls.Add(this.passRegTextBox);
            this.Controls.Add(this.userRegTextBox);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(900, 500);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox userRegTextBox;
        private MetroFramework.Controls.MetroTextBox passRegTextBox;
        private MetroFramework.Controls.MetroTextBox confirmPassRegTextBox;
        private MetroFramework.Controls.MetroLabel registerLabel;
        private MetroFramework.Controls.MetroTextBox userNameTextBox;
        private MetroFramework.Controls.MetroTextBox passowrdTextBox;
        private MetroFramework.Controls.MetroLabel logingLabel;
        private MetroFramework.Controls.MetroButton regButton;
        private MetroFramework.Controls.MetroButton logButton;
        private MetroFramework.Controls.MetroLink restoreLink;
        private MetroFramework.Controls.MetroLabel userLabel;
        private MetroFramework.Controls.MetroLabel passLabel;
        private MetroFramework.Controls.MetroLabel userRegLabel;
        private MetroFramework.Controls.MetroLabel passRegLabel;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
    }
}
