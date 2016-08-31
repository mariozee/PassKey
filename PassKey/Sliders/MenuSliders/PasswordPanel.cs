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

namespace PassKey.Sliders.MenuSliders
{
    public partial class PasswordPanel : BaseSliderPanel
    {
        private const int OpenXConst = 200;
        private const int OpenYConst = 575;
        private const int ClosedXConst = 200;
        private const int ClosedYConst = 600;
        private const string TransitionDirectionConst = "Top";
        private const int TransitionAccelerationConst = 250;
        private const int DestinationOpenConst = 575;
        private const int DestinationClosedConst = 600;

        private MetroGrid dataGrid;

        public PasswordPanel(Form form, MetroGrid dataGrid)
            : base(form, OpenXConst, OpenYConst, ClosedXConst, ClosedYConst, TransitionDirectionConst
                  , TransitionAccelerationConst, DestinationOpenConst, DestinationClosedConst)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
            GetCurrentPassword();
            this.passwordShowTimer.Enabled = true;
        }

        private void GetCurrentPassword()
        {
            int rowIndex = this.dataGrid.CurrentCell.RowIndex;
            string password = this.dataGrid.Rows[rowIndex].Cells[3].Value.ToString();
            this.passwordLabel.Text = password;
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
            this.passwordShowTimer.Enabled = false;
            this.Swipe(false);
        }

        private void passwordShowTimer_Tick(object sender, EventArgs e)
        {
            this.passwordShowTimer.Enabled = false;
            this.Swipe(false);
        }
    }
}
