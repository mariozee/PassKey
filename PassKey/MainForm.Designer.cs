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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoLink = new MetroFramework.Controls.MetroLink();
            this.closeLink = new MetroFramework.Controls.MetroLink();
            this.minimizeLink = new MetroFramework.Controls.MetroLink();
            this.mainToolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "PassKey";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PassKey.Properties.Resources.iconSmall;
            this.pictureBox1.Location = new System.Drawing.Point(170, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 52);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // infoLink
            // 
            this.infoLink.BackColor = System.Drawing.Color.Transparent;
            this.infoLink.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.infoLink.Image = global::PassKey.Properties.Resources.infoEn;
            this.infoLink.ImageSize = 34;
            this.infoLink.Location = new System.Drawing.Point(733, 30);
            this.infoLink.Name = "infoLink";
            this.infoLink.NoFocusImage = global::PassKey.Properties.Resources.infoDis;
            this.infoLink.Size = new System.Drawing.Size(39, 39);
            this.infoLink.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.infoLink, "Software info.");
            this.infoLink.UseCustomBackColor = true;
            this.infoLink.UseSelectable = true;
            this.infoLink.Click += new System.EventHandler(this.infoLink_Click);
            // 
            // closeLink
            // 
            this.closeLink.BackColor = System.Drawing.Color.Transparent;
            this.closeLink.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.closeLink.Image = global::PassKey.Properties.Resources.close_Enabled;
            this.closeLink.ImageSize = 36;
            this.closeLink.Location = new System.Drawing.Point(823, 30);
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
            this.minimizeLink.Location = new System.Drawing.Point(778, 30);
            this.minimizeLink.Name = "minimizeLink";
            this.minimizeLink.NoFocusImage = global::PassKey.Properties.Resources.minimize_Disabled;
            this.minimizeLink.Size = new System.Drawing.Size(39, 39);
            this.minimizeLink.TabIndex = 0;
            this.minimizeLink.UseCustomBackColor = true;
            this.minimizeLink.UseSelectable = true;
            this.minimizeLink.Click += new System.EventHandler(this.minimizeLink_Click);
            // 
            // mainToolTip
            // 
            this.mainToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.mainToolTip.StyleManager = null;
            this.mainToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoLink);
            this.Controls.Add(this.closeLink);
            this.Controls.Add(this.minimizeLink);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink minimizeLink;
        private MetroFramework.Controls.MetroLink closeLink;
        private MetroFramework.Controls.MetroLink infoLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroToolTip mainToolTip;
    }
}

