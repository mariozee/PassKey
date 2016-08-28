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

namespace PassKey.Sliders
{
    public partial class LoginPanel : AbstractSlider
    {
        private const int OpenXConst = 0;
        private const int OpenYConst = 80;
        private const int ClosedXConst = 900;
        private const int ClosedYConst = 80;
        private const string TransitionDirectionConst = "Left";
        private const int TransitionAccelerationConst = 250;
        private const int DestinationOpenConst = 0;
        private const int DestinationClosedConst = 900;

        private Form mainForm;

        public LoginPanel(Form form)
            : base(form, OpenXConst, OpenYConst, ClosedXConst, ClosedYConst, TransitionDirectionConst, TransitionAccelerationConst, DestinationOpenConst, DestinationClosedConst)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            LoginHandler logH = new LoginHandler();
            LoginValidator logV = new LoginValidator();

            try
            {
                logV.ValidateInput(this.userNameTextBox.Text, this.passowrdTextBox.Text);
                LoggedUser user = logH.Login(this.userNameTextBox.Text, this.passowrdTextBox.Text);
                UserPanel userPanel = new UserPanel(this.MainForm, user);
                this.Swipe(false);
                userPanel.Swipe(true);
            }
            catch (PassKeyException pke)
            {
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            RegistrationValidator regV = new RegistrationValidator();
            RegistrationHandler regH = new RegistrationHandler();

            try
            {
                regV.ValidateInput(this.userRegTextBox.Text, this.passRegTextBox.Text, this.confirmPassRegTextBox.Text);
                regH.Register(this.userRegTextBox.Text, this.passRegTextBox.Text);
            }
            catch (PassKeyException pke)
            {
            }

        }
    }
}
