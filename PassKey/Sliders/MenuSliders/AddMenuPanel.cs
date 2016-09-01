namespace PassKey.Sliders.MenuSliders
{
    using System;
    using System.Windows.Forms;
    using UserInfo;
    using Data;

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

            this.User.AddData(dataInfo);
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
