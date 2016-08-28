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
    public partial class UserPanel : AbstractSlider
    {
        private const int OpenX = 0;
        private const int OpenY = 80;
        private const int ClosedX = -800;
        private const int ClosedY = 80;
        private const string TransitionDirection = "Left";
        private const int TransitionAcceleration = 250;
        private const int DestinationOpen = 0;
        private const int DestinationClosed = -800;

        public UserPanel(Form form) 
            : base(form, OpenX, OpenY, ClosedX, ClosedY, TransitionDirection, TransitionAcceleration, DestinationOpen, DestinationClosed)
        {
            InitializeComponent();
        }
    }
}
