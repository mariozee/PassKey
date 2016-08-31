using System.Windows.Forms;

namespace PassKey.Sliders
{
    partial class UserPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new MetroFramework.Controls.MetroGrid();
            this.hostNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.backupLink = new MetroFramework.Controls.MetroLink();
            this.showPassLink = new MetroFramework.Controls.MetroLink();
            this.deleteAccountLink = new MetroFramework.Controls.MetroLink();
            this.logoutLink = new MetroFramework.Controls.MetroLink();
            this.changePassLink = new MetroFramework.Controls.MetroLink();
            this.removeLink = new MetroFramework.Controls.MetroLink();
            this.editLink = new MetroFramework.Controls.MetroLink();
            this.addLink = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataInfoBindingSource)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hostNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.userDataInfoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGrid.Location = new System.Drawing.Point(3, 19);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(625, 431);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dataGrid.UseCustomBackColor = true;
            this.dataGrid.UseStyleColors = true;
            // 
            // hostNameDataGridViewTextBoxColumn
            // 
            this.hostNameDataGridViewTextBoxColumn.DataPropertyName = "HostName";
            this.hostNameDataGridViewTextBoxColumn.HeaderText = "HostName";
            this.hostNameDataGridViewTextBoxColumn.Name = "hostNameDataGridViewTextBoxColumn";
            this.hostNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.hostNameDataGridViewTextBoxColumn.Width = 193;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 193;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 193;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // userDataInfoBindingSource
            // 
            this.userDataInfoBindingSource.DataSource = typeof(PassKey.UserInfo.UserDataInfo);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(653, 100);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1, 350);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // backupLink
            // 
            this.backupLink.BackColor = System.Drawing.Color.Transparent;
            this.backupLink.Image = global::PassKey.Properties.Resources.backupMenuDis;
            this.backupLink.ImageSize = 169;
            this.backupLink.Location = new System.Drawing.Point(16, 245);
            this.backupLink.Name = "backupLink";
            this.backupLink.NoFocusImage = global::PassKey.Properties.Resources.backupMenuEn;
            this.backupLink.Size = new System.Drawing.Size(178, 33);
            this.backupLink.TabIndex = 14;
            this.backupLink.UseCustomBackColor = true;
            this.backupLink.UseSelectable = true;
            this.backupLink.Click += new System.EventHandler(this.backupLink_Click);
            // 
            // showPassLink
            // 
            this.showPassLink.BackColor = System.Drawing.Color.Transparent;
            this.showPassLink.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.showPassLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.showPassLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.showPassLink.Image = global::PassKey.Properties.Resources.showPassMenuEn;
            this.showPassLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showPassLink.ImageSize = 165;
            this.showPassLink.Location = new System.Drawing.Point(17, 320);
            this.showPassLink.Name = "showPassLink";
            this.showPassLink.NoFocusImage = global::PassKey.Properties.Resources.showPassMenuDis;
            this.showPassLink.Size = new System.Drawing.Size(169, 43);
            this.showPassLink.Style = MetroFramework.MetroColorStyle.Red;
            this.showPassLink.TabIndex = 13;
            this.showPassLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showPassLink.UseCustomBackColor = true;
            this.showPassLink.UseSelectable = true;
            this.showPassLink.Click += new System.EventHandler(this.showPassLink_Click);
            // 
            // deleteAccountLink
            // 
            this.deleteAccountLink.BackColor = System.Drawing.Color.Transparent;
            this.deleteAccountLink.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.deleteAccountLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.deleteAccountLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.deleteAccountLink.Image = global::PassKey.Properties.Resources.delAccMenuEn;
            this.deleteAccountLink.ImageSize = 165;
            this.deleteAccountLink.Location = new System.Drawing.Point(11, 321);
            this.deleteAccountLink.Name = "deleteAccountLink";
            this.deleteAccountLink.NoFocusImage = global::PassKey.Properties.Resources.delAccMenuDis;
            this.deleteAccountLink.Size = new System.Drawing.Size(180, 38);
            this.deleteAccountLink.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteAccountLink.TabIndex = 12;
            this.deleteAccountLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteAccountLink.UseCustomBackColor = true;
            this.deleteAccountLink.UseSelectable = true;
            this.deleteAccountLink.Click += new System.EventHandler(this.deleteAccountLink_Click);
            // 
            // logoutLink
            // 
            this.logoutLink.BackColor = System.Drawing.Color.Transparent;
            this.logoutLink.Image = global::PassKey.Properties.Resources.logMenuEn;
            this.logoutLink.ImageSize = 96;
            this.logoutLink.Location = new System.Drawing.Point(16, 87);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.NoFocusImage = global::PassKey.Properties.Resources.logMenuDis;
            this.logoutLink.Size = new System.Drawing.Size(107, 40);
            this.logoutLink.TabIndex = 15;
            this.logoutLink.UseCustomBackColor = true;
            this.logoutLink.UseSelectable = true;
            this.logoutLink.Click += new System.EventHandler(this.logoutLink_Click);
            // 
            // changePassLink
            // 
            this.changePassLink.BackColor = System.Drawing.Color.Transparent;
            this.changePassLink.Image = global::PassKey.Properties.Resources.changePassMenuEn;
            this.changePassLink.ImageSize = 185;
            this.changePassLink.Location = new System.Drawing.Point(14, 166);
            this.changePassLink.Name = "changePassLink";
            this.changePassLink.NoFocusImage = global::PassKey.Properties.Resources.changePassMenuDis;
            this.changePassLink.Size = new System.Drawing.Size(191, 40);
            this.changePassLink.TabIndex = 16;
            this.changePassLink.UseCustomBackColor = true;
            this.changePassLink.UseSelectable = true;
            this.changePassLink.Click += new System.EventHandler(this.changePassLink_Click);
            // 
            // removeLink
            // 
            this.removeLink.BackColor = System.Drawing.Color.Transparent;
            this.removeLink.Image = global::PassKey.Properties.Resources.removeMenuEn;
            this.removeLink.ImageSize = 106;
            this.removeLink.Location = new System.Drawing.Point(14, 245);
            this.removeLink.Name = "removeLink";
            this.removeLink.NoFocusImage = global::PassKey.Properties.Resources.removeMenuDis;
            this.removeLink.Size = new System.Drawing.Size(116, 37);
            this.removeLink.TabIndex = 17;
            this.removeLink.UseCustomBackColor = true;
            this.removeLink.UseSelectable = true;
            this.removeLink.Click += new System.EventHandler(this.removeLink_Click);
            // 
            // editLink
            // 
            this.editLink.BackColor = System.Drawing.Color.Transparent;
            this.editLink.Image = global::PassKey.Properties.Resources.editMenuEn;
            this.editLink.ImageSize = 72;
            this.editLink.Location = new System.Drawing.Point(14, 168);
            this.editLink.Name = "editLink";
            this.editLink.NoFocusImage = global::PassKey.Properties.Resources.editMenuDis;
            this.editLink.Size = new System.Drawing.Size(83, 40);
            this.editLink.TabIndex = 18;
            this.editLink.UseCustomBackColor = true;
            this.editLink.UseSelectable = true;
            this.editLink.Click += new System.EventHandler(this.editLink_Click);
            // 
            // addLink
            // 
            this.addLink.BackColor = System.Drawing.Color.Transparent;
            this.addLink.Image = global::PassKey.Properties.Resources.addMenuEn;
            this.addLink.ImageSize = 74;
            this.addLink.Location = new System.Drawing.Point(16, 90);
            this.addLink.Name = "addLink";
            this.addLink.NoFocusImage = global::PassKey.Properties.Resources.addMenuDis;
            this.addLink.Size = new System.Drawing.Size(81, 40);
            this.addLink.TabIndex = 19;
            this.addLink.UseCustomBackColor = true;
            this.addLink.UseSelectable = true;
            this.addLink.Click += new System.EventHandler(this.addLink_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(660, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(222, 475);
            this.metroTabControl1.TabIndex = 20;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.addLink);
            this.metroTabPage1.Controls.Add(this.editLink);
            this.metroTabPage1.Controls.Add(this.showPassLink);
            this.metroTabPage1.Controls.Add(this.removeLink);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(214, 427);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Management";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.changePassLink);
            this.metroTabPage2.Controls.Add(this.logoutLink);
            this.metroTabPage2.Controls.Add(this.deleteAccountLink);
            this.metroTabPage2.Controls.Add(this.backupLink);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(214, 427);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Account";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(900, 500);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataInfoBindingSource)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dataGrid;
        private BindingSource userDataInfoBindingSource;
        private MetroFramework.Controls.MetroLink showPassLink;
        private DataGridViewTextBoxColumn hostNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLink deleteAccountLink;
        private MetroFramework.Controls.MetroLink backupLink;
        private MetroFramework.Controls.MetroLink logoutLink;
        private MetroFramework.Controls.MetroLink changePassLink;
        private MetroFramework.Controls.MetroLink removeLink;
        private MetroFramework.Controls.MetroLink editLink;
        private MetroFramework.Controls.MetroLink addLink;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}
