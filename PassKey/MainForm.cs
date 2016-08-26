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
        private UserControl1 a;

        public MainForm()
        {
            InitializeComponent();
            a = new UserControl1(this, this.Width, this.Height - 100, 0, 100, -this.Width, 100, "Left", 1000, 0, -this.Width);
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            a = new UserControl1(this, this.Width, this.Height - 100, 0, 100, -this.Width, 100, "Left", 1000, 0, -this.Width);   
            a.Swipe(true);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            a.Swipe(false);
        }
    }
}
