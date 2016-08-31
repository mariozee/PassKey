namespace PassKey
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeLink = new MetroFramework.Controls.MetroLink();
            this.minimizeLink = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // closeLink
            // 
            this.closeLink.BackColor = System.Drawing.Color.Transparent;
            this.closeLink.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.closeLink.Image = global::PassKey.Properties.Resources.close_Enabled;
            this.closeLink.ImageSize = 36;
            this.closeLink.Location = new System.Drawing.Point(823, 22);
            this.closeLink.Name = "closeLink";
            this.closeLink.NoFocusImage = global::PassKey.Properties.Resources.close_Disabled;
            this.closeLink.Size = new System.Drawing.Size(39, 39);
            this.closeLink.TabIndex = 1;
            this.closeLink.UseCustomBackColor = true;
            this.closeLink.UseSelectable = true;
            this.closeLink.Click += new System.EventHandler(this.closeLink_Click);
            // 
            // minimizeLink
            // 
            this.minimizeLink.BackColor = System.Drawing.Color.Transparent;
            this.minimizeLink.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.minimizeLink.Image = global::PassKey.Properties.Resources.minimize_Enabled;
            this.minimizeLink.ImageSize = 36;
            this.minimizeLink.Location = new System.Drawing.Point(778, 22);
            this.minimizeLink.Name = "minimizeLink";
            this.minimizeLink.NoFocusImage = global::PassKey.Properties.Resources.minimize_Disabled;
            this.minimizeLink.Size = new System.Drawing.Size(39, 39);
            this.minimizeLink.TabIndex = 0;
            this.minimizeLink.UseCustomBackColor = true;
            this.minimizeLink.UseSelectable = true;
            this.minimizeLink.Click += new System.EventHandler(this.minimizeLink_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.closeLink);
            this.Controls.Add(this.minimizeLink);
            this.DisplayHeader = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "PassKey";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink minimizeLink;
        private MetroFramework.Controls.MetroLink closeLink;
    }
}

