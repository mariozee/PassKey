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

namespace PassKey
{
    public partial class MainForm : MetroForm
    {
        private LoginPanel a;

        public MainForm()
        {
           InitializeComponent();
                      
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            a = new LoginPanel(this, 0, 80, -this.Width, 80, "Left", 1000, 0, -this.Width);   
            a.Swipe(true);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            a.Swipe(false);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            a = new LoginPanel(this, 0, 80, -this.Width, 80, "Left", 500, 0, -this.Width);
            a.Swipe(true);
        }
    }
}
