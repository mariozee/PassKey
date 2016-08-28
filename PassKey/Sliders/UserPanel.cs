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
using PassKey.Sliders.MenuSliders;

namespace PassKey.Sliders
{
    public partial class UserPanel : AbstractSlider
    {
        private const int OpenX = 0;
        private const int OpenY = 80;
        private const int ClosedX = -900;
        private const int ClosedY = 80;
        private const string TransitionDirection = "Left";
        private const int TransitionAcceleration = 250;
        private const int DestinationOpen = 0;
        private const int DestinationClosed = -900;

        private Form mainForm;
        private LoggedUser user;

        public UserPanel(Form form, LoggedUser user) 
            : base(form, OpenX, OpenY, ClosedX, ClosedY, TransitionDirection, TransitionAcceleration, DestinationOpen, DestinationClosed)
        {
            InitializeComponent();
            this.user = user;
            this.dataGrid.DataSource = user.Data;
            this.dataGrid.Refresh();
            this.mainForm = form;
        }        

        private void addButton_Click(object sender, EventArgs e)
        {
            AddMenuPanel addPanel = new AddMenuPanel(this.mainForm, this.user);
            addPanel.Swipe(true);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditMenuPanel editPanel = new EditMenuPanel(this.mainForm, this.user, this.dataGrid);
            editPanel.Swipe(true);
        }
    }
}
