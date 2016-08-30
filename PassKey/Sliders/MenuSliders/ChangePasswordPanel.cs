using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassKey.UserInfo;
using PassKey.Data;
using PassKey.SecurityUtilities;
using PassKey.Exceptions;
using MetroFramework;

namespace PassKey.Sliders.MenuSliders
{
    public partial class ChangePasswordPanel : AbstractMenuSlider
    {
        public ChangePasswordPanel(Form form, LoggedUser user)
            : base(form, user)
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.oldPassLabel.Visible = false;
            this.newPassLabel1.Visible = false;
            this.newPassLabel2.Visible = false;

            string currentPassword = this.oldPasswordTextBox.Text;
            string currentPasswordHash = HashUtilities.HashPassword(currentPassword);
            string hashedPassword = RegistryData.GetUserPassword(this.User.Username);
            if (currentPasswordHash == hashedPassword)
            {
                try
                {
                    ValidateNewPassword(this.newPassTextBox.Text, this.confirmNewPassTextBox.Text);
                    string oldEncryptedData = RegistryData.GetUserData(this.User.Username);
                    string oldDecryptedData = CryptographicUtilities.Decrypt(oldEncryptedData, this.User.Key);
                    string newPassword = HashUtilities.HashPassword(this.newPassTextBox.Text);
                    byte[] newKey = HashUtilities.HashKey(this.newPassTextBox.Text);
                    string newData = CryptographicUtilities.Encrypt(oldDecryptedData, newKey);
                    RegistryData.SetNewPassword(this.User.Username, newPassword);
                    RegistryData.SetUserData(this.User.Username, newData);
                    this.User.Key = newKey;

                    MetroMessageBox.Show(this.MainForm, "", "Password changed successfully!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information, 80);

                    this.Swipe(true);
                }
                catch (InvalidPasswordException ipe)
                {
                    this.newPassLabel2.Text = ipe.Message;
                    this.newPassLabel2.Visible = true;
                }
                catch (PasswordMismatchException pme)
                {
                    this.newPassLabel1.Text = pme.Message;
                    this.newPassLabel1.Visible = true;
                }
            }
            else
            {
                this.oldPassLabel.Visible = true;
            }
        }

        private void ValidateNewPassword(string password, string confirmedPassword)
        {
            if (password != confirmedPassword)
            {
                throw new PasswordMismatchException(GlobalMessages.PasswordsMismatch);
            }

            if (string.IsNullOrWhiteSpace(password) ||
                password.Length < Constants.MinPasswordLenght)
            {
                throw new InvalidPasswordException(string.Format(GlobalMessages.InvalidPasswordLenght
                    , Constants.MinPasswordLenght
                    , Constants.MaxPasswordLenght));

            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Swipe();
        }
    }
}