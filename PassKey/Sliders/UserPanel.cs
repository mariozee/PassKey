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
using MetroFramework;
using PassKey.Data;

namespace PassKey.Sliders
{
    public partial class UserPanel : AbstractSlider
    {
        private const int OpenXConst = 0;
        private const int OpenYConst = 80;
        private const int ClosedXConst = -900;
        private const int ClosedYConst = 80;
        private const string TransitionDirectionConst = "Left";
        private const int TransitionAccelerationConst = 250;
        private const int DestinationOpenConst = 0;
        private const int DestinationClosedConst = -900;

        private Form mainForm;
        private LoggedUser user;

        public UserPanel(Form form, LoggedUser user) 
            : base(form, OpenXConst, OpenYConst, ClosedXConst, ClosedYConst, TransitionDirectionConst, TransitionAccelerationConst, DestinationOpenConst, DestinationClosedConst)
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

        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(
                this
                , string.Empty
                , "Are you sure you want to delete selected host?"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , 80);

            if (result == DialogResult.Yes)
            {
                int indexToDelete = this.dataGrid.CurrentCell.RowIndex;
                this.user.Data.RemoveAt(indexToDelete);
                DataTranslator.Compose(this.user.Data, this.user.Username, user.Key);
            }
        }

        private void backupRestoreButton_Click(object sender, EventArgs e)
        {
            BackupRestoreMenuSlider backupSlider = new BackupRestoreMenuSlider(this.mainForm, this.user);
            backupSlider.Swipe(true);
        }
    }
}
