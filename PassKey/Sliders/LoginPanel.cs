using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKey.Sliders
{
    public partial class LoginPanel : AbstractSlider
    {


        public LoginPanel(Form form, int xOpen, int yOpen, int xClosed, int yClosed
            , string transitionDirection, int tranAcceleration, int destinationOpen, int destinationClosed) 
            : base(form, xOpen, yOpen, xClosed, yClosed, transitionDirection, tranAcceleration, destinationOpen, destinationClosed)
        {
            InitializeComponent();
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
