using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using PassKey.UserInfo;
using PassKey.Data;

namespace PassKey.Sliders.MenuSliders
{
    public partial class AddMenuPanel : AbstractMenuSlider
    {
        private LoggedUser user;

        public AddMenuPanel(Form form, LoggedUser user)
            : base(form)
        {
            InitializeComponent();
            this.user = user;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            UserDataInfo dataInfo = new UserDataInfo(this.hostTextBox.Text
                , this.emailTextBox.Text, this.usernameTextBox.Text, this.passwordTextBox.Text);

            this.user.Data.Add(dataInfo);
            DataTranslator.Compose(this.user.Data, this.user.Username, this.user.Key);

            this.hostTextBox.Clear();
            this.emailTextBox.Clear();
            this.usernameTextBox.Clear();
            this.passwordTextBox.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Swipe(false);
        }
    }
}
