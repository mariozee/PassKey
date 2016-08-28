using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKey.Sliders.MenuSliders
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<AbstractMenuSlider, MetroUserControl>))]
    public abstract class AbstractMenuSlider : AbstractSlider
    {
        private const int OpenXConst = 660;
        private const int OpenYConst = 80;
        private const int ClosedXConst = 900;
        private const int ClosedYConst = 80;
        private const string TransitionDirectionConst = "Left";
        private const int TransitionAccelerationConst = 500;
        private const int DestinationOpenConst = 660;
        private const int DestinationClosedConst = 900;

        protected AbstractMenuSlider(Form form)
            : base(form, OpenXConst, OpenYConst, ClosedXConst, ClosedYConst, TransitionDirectionConst
                  , TransitionAccelerationConst, DestinationOpenConst, DestinationClosedConst)
        {
        }
    }
}
