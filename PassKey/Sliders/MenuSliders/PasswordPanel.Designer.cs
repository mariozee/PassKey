namespace PassKey.Sliders.MenuSliders
{
    partial class PasswordPanel
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
            this.components = new System.ComponentModel.Container();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordShowTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Location = new System.Drawing.Point(0, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(250, 25);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLabel.UseCustomBackColor = true;
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // passwordShowTimer
            // 
            this.passwordShowTimer.Interval = 3000;
            this.passwordShowTimer.Tick += new System.EventHandler(this.passwordShowTimer_Tick);
            // 
            // PasswordPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.passwordLabel);
            this.Name = "PasswordPanel";
            this.Size = new System.Drawing.Size(250, 25);
            this.UseCustomBackColor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel passwordLabel;
        private System.Windows.Forms.Timer passwordShowTimer;
    }
}
