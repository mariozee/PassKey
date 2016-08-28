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
using MetroFramework.Controls;
using PassKey.Data;

namespace PassKey.Sliders.MenuSliders
{
    public partial class EditMenuPanel : AbstractMenuSlider
    {
        private LoggedUser user { get; set; }
        private int selectedRowIndex;
        private MetroGrid dataGrid;

        public EditMenuPanel(Form form, LoggedUser user, MetroGrid dataGrid)
            : base(form)
        {
            InitializeComponent();
            this.user = user;
            this.dataGrid = dataGrid;
            GetItemToEdit(dataGrid);    
        }        

        private void GetItemToEdit(MetroGrid dataGrid)
        {
            selectedRowIndex = dataGrid.CurrentCell.RowIndex;
            string hostName = dataGrid.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string email = dataGrid.Rows[selectedRowIndex].Cells[1].Value.ToString();
            string username = dataGrid.Rows[selectedRowIndex].Cells[2].Value.ToString();
            string password = dataGrid.Rows[selectedRowIndex].Cells[3].Value.ToString();

            this.hostNameTextBox.Text = hostName;
            this.emailTextBox.Text = email;
            this.usernameTextBox.Text = username;
            this.passwordTextBox.Text = password;

            this.dataGrid.Enabled = false;      
        }       

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.user.Data.RemoveAt(selectedRowIndex);
            UserDataInfo dataInfo = new UserDataInfo(this.hostNameTextBox.Text
                , this.emailTextBox.Text, this.usernameTextBox.Text, this.passwordTextBox.Text);
            this.user.Data.Insert(selectedRowIndex, dataInfo);

            DataTranslator.Compose(this.user.Data, this.user.Username, this.user.Key);

            this.dataGrid.Enabled = true;
            this.Swipe(false);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.dataGrid.Enabled = true;
            this.Swipe(false);
        }
    }
}
