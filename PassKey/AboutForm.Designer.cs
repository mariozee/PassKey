namespace PassKey
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.githubLink = new MetroFramework.Controls.MetroLink();
            this.gmailLink = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeLink = new MetroFramework.Controls.MetroLink();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(161, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 426);
            this.panel1.TabIndex = 8;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(18, 208);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(478, 200);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = resources.GetString("metroLabel5.Text");
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(18, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(259, 125);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Product Name: PassKey\r\n\r\nVersion: 1.0.0\r\n\r\nCopyright: © Mario Zisov 2016";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // githubLink
            // 
            this.githubLink.BackColor = System.Drawing.Color.Transparent;
            this.githubLink.Image = global::PassKey.Properties.Resources.githubFocus;
            this.githubLink.ImageSize = 55;
            this.githubLink.Location = new System.Drawing.Point(43, 260);
            this.githubLink.Name = "githubLink";
            this.githubLink.NoFocusImage = global::PassKey.Properties.Resources.githubNoFocus;
            this.githubLink.Size = new System.Drawing.Size(77, 78);
            this.githubLink.TabIndex = 10;
            this.githubLink.UseCustomBackColor = true;
            this.githubLink.UseSelectable = true;
            this.githubLink.Click += new System.EventHandler(this.githubLink_Click);
            // 
            // gmailLink
            // 
            this.gmailLink.BackColor = System.Drawing.Color.Transparent;
            this.gmailLink.Image = global::PassKey.Properties.Resources.gmailFocus;
            this.gmailLink.ImageSize = 40;
            this.gmailLink.Location = new System.Drawing.Point(43, 190);
            this.gmailLink.Name = "gmailLink";
            this.gmailLink.NoFocusImage = global::PassKey.Properties.Resources.gmailNoFocus;
            this.gmailLink.Size = new System.Drawing.Size(75, 64);
            this.gmailLink.TabIndex = 9;
            this.gmailLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gmailLink.UseCustomBackColor = true;
            this.gmailLink.UseSelectable = true;
            this.gmailLink.Click += new System.EventHandler(this.gmailLink_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PassKey.Properties.Resources.iconLarge;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(28, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 104);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // closeLink
            // 
            this.closeLink.BackColor = System.Drawing.Color.Transparent;
            this.closeLink.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.closeLink.Image = global::PassKey.Properties.Resources.close_Enabled;
            this.closeLink.ImageSize = 36;
            this.closeLink.Location = new System.Drawing.Point(654, 9);
            this.closeLink.Name = "closeLink";
            this.closeLink.NoFocusImage = global::PassKey.Properties.Resources.close_Disabled;
            this.closeLink.Size = new System.Drawing.Size(39, 39);
            this.closeLink.TabIndex = 11;
            this.closeLink.UseCustomBackColor = true;
            this.closeLink.UseSelectable = true;
            this.closeLink.Click += new System.EventHandler(this.closeLink_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 531);
            this.ControlBox = false;
            this.Controls.Add(this.closeLink);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.gmailLink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AboutForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLink gmailLink;
        private MetroFramework.Controls.MetroLink githubLink;
        private MetroFramework.Controls.MetroLink closeLink;
    }
}