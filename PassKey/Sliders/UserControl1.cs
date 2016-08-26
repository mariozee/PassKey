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
    public partial class UserControl1 : AbstractSlider
    {


        public UserControl1(Form form, int width, int height, int xOpen, int yOpen, int xClosed, int yClosed, string transitionDirection, int tranAcceleration, int destinationOpen, int destinationClosed) : base(form, width, height, xOpen, yOpen, xClosed, yClosed, transitionDirection, tranAcceleration, destinationOpen, destinationClosed)
        {
            InitializeComponent();
        }
    }
}
