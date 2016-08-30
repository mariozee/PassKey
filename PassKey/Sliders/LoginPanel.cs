using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassKey.UsersInputValidators;
using PassKey.ActionHandlers;
using PassKey.Exceptions;
using PassKey.UserInfo;
using MetroFramework.Controls;

namespace PassKey.Sliders
{
    public partial class LoginPanel : BaseSliderPanel
    {
        private const int OpenXConst = 0;
        private const int OpenYConst = 80;
        private const int ClosedXConst = 900;
        private const int ClosedYConst = 80;
        private const string TransitionDirectionConst = "Left";
        private const int TransitionAccelerationConst = 250;
        private const int DestinationOpenConst = 0;
        private const int DestinationClosedConst = 900;

        private RestorePanel restorePanel;
        private UserPanel userPanel;
        private LoggedUser user;
        private LoginHandler loginHandler;
        private LoginValidator loginValidator;
        private RegistrationHandler regHandler;
        private RegistrationValidator regValidator;

        public LoginPanel(Form form)
            : base(form, OpenXConst, OpenYConst, ClosedXConst, ClosedYConst, TransitionDirectionConst, TransitionAccelerationConst, DestinationOpenConst, DestinationClosedConst)
        {
            InitializeComponent();
            this.loginHandler = new LoginHandler();
            this.loginValidator = new LoginValidator();
            this.regHandler = new RegistrationHandler();
            this.regValidator = new RegistrationValidator();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            this.userLabel.Visible = false;
            this.passLabel.Visible = false;

            try
            {
                this.loginValidator.ValidateInput(this.userNameTextBox.Text, this.passowrdTextBox.Text);
                this.LogUser();
            }
            catch (InvalidUsernameException iue)
            {
                this.userLabel.Text = iue.Message;
                this.userLabel.Visible = true;
            }
            catch (InvalidPasswordLenghtException ipe)
            {
                this.passLabel.Text = ipe.Message;
                this.passLabel.Visible = true;
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            this.userRegLabel.Visible = false;
            this.passRegLabel.Visible = false;

            try
            {
                this.regValidator.ValidateInput(this.userRegTextBox.Text, this.passRegTextBox.Text, this.confirmPassRegTextBox.Text);
                this.regHandler.Register(this.userRegTextBox.Text, this.passRegTextBox.Text);
                this.LogUser();
            }
            catch (UsernameAlreadyUsedException uaue)
            {
                this.userRegLabel.Text = uaue.Message;
                this.userRegLabel.Visible = true;
            }
            catch (InvalidNameLenghtException inle)
            {
                this.userRegLabel.Text = inle.Message;
                this.userRegLabel.Visible = true;
            }
            catch (InvalidUsernameException iue)
            {
                this.userRegLabel.Text = iue.Message;
                this.userRegLabel.Visible = true;
            }
            catch (PasswordMismatchException pme)
            {
                this.passRegLabel.Text = pme.Message;
                this.passRegLabel.Visible = true;
            }
            catch (InvalidPasswordLenghtException iple)
            {
                this.passRegLabel.Text = iple.Message;
                this.passRegLabel.Visible = true;
            }

        }

        private void restoreLink_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.restorePanel = new RestorePanel(this.MainForm);
            restorePanel.Swipe(true);
        }

        private void LogUser()
        {
            this.user = loginHandler.Login(this.userNameTextBox.Text, this.passowrdTextBox.Text);
            this.userPanel = new UserPanel(this.MainForm, user);
            this.Swipe(false);
            this.userPanel.Swipe(true);
        }
    }
}
