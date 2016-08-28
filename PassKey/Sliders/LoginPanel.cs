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

namespace PassKey.Sliders
{
    public partial class LoginPanel : AbstractSlider
    {
        //this, 0, 80, this.Width, 80, "Left", 500, 0, this.Width);
        private const int OpenX = 0;
        private const int OpenY = 80;
        private const int ClosedX = 800;
        private const int ClosedY = 80;
        private const string TransitionDirection = "Left";
        private const int TransitionAcceleration = 250;
        private const int DestinationOpen = 0;
        private const int DestinationClosed = 800;

        public LoginPanel(Form form) 
            : base(form, OpenX, OpenY, ClosedX, ClosedY, TransitionDirection, TransitionAcceleration, DestinationOpen, DestinationClosed)
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            RegistrationValidator regV = new RegistrationValidator();
            RegistrationHandler regH = new RegistrationHandler();

            regV.ValidateInput(this.userRegTextBox.Text, this.passRegTextBox.Text, this.confirmPassRegTextBox.Text);
            regH.Register(this.userRegTextBox.Text, this.passRegTextBox.Text);
        }
    }
}
