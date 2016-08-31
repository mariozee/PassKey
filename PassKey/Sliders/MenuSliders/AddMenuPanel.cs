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
    public partial class AddMenuPanel : BaseMenuSliderPanel
    {
        public AddMenuPanel(Form form, LoggedUser user)
            : base(form, user)
        {
            InitializeComponent();
            this.addButton.UseSelectable = false;        
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            UserDataInfo dataInfo = new UserDataInfo(this.hostTextBox.Text
                , this.emailTextBox.Text, this.usernameTextBox.Text, this.passwordTextBox.Text);

            this.User.Data.Add(dataInfo);
            DataTranslator.Compose(this.User.Data, this.User.Username, this.User.Key);

            this.hostTextBox.Clear();
            this.emailTextBox.Clear();
            this.usernameTextBox.Clear();
            this.passwordTextBox.Clear();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Swipe(false);
        }
    }
}
