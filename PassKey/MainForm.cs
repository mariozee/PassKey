using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PassKey.Sliders;
using System.Threading;

namespace PassKey
{
    public partial class MainForm : MetroForm
    {
        private LoginPanel a;
        private UserPanel b;

        public MainForm()
        {
           InitializeComponent();
            //b = new UserPanel(this);
                      
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //b = new UserPanel(this);
            a.Swipe(false);
            //b.Swipe(true); 
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            a = new LoginPanel(this);
            //b.Swipe(false);
            a.Swipe(true);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            a = new LoginPanel(this);
            a.Swipe(true);          
        }
    }
}
