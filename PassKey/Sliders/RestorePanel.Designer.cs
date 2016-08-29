using System.Windows.Forms;

namespace PassKey.Sliders
{
    partial class RestorePanel
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
            this.restoreButton = new MetroFramework.Controls.MetroButton();
            this.restoreTextBox = new MetroFramework.Controls.MetroTextBox();
            this.browseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(145, 56);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 23);
            this.restoreButton.TabIndex = 0;
            this.restoreButton.Text = "Restore";
            this.restoreButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.restoreButton.UseSelectable = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // restoreTextBox
            // 
            // 
            // 
            // 
            this.restoreTextBox.CustomButton.Image = null;
            this.restoreTextBox.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.restoreTextBox.CustomButton.Name = "";
            this.restoreTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.restoreTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.restoreTextBox.CustomButton.TabIndex = 1;
            this.restoreTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.restoreTextBox.CustomButton.UseSelectable = true;
            this.restoreTextBox.DisplayIcon = true;
            this.restoreTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.restoreTextBox.Lines = new string[0];
            this.restoreTextBox.Location = new System.Drawing.Point(20, 15);
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
            this.restoreTextBox.Size = new System.Drawing.Size(262, 25);
            this.restoreTextBox.TabIndex = 1;
            this.restoreTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.restoreTextBox.UseSelectable = true;
            this.restoreTextBox.WaterMark = "Restore from...";
            this.restoreTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.restoreTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(64, 56);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // RestorePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.restoreTextBox);
            this.Controls.Add(this.restoreButton);
            this.Name = "RestorePanel";
            this.Size = new System.Drawing.Size(300, 100);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton restoreButton;
        private MetroFramework.Controls.MetroTextBox restoreTextBox;
        private FolderBrowserDialog browseDialog;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroButton closeButton;
    }
}
