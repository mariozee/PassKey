using System.Windows.Forms;
using PassKey.UserInfo;

namespace PassKey.Sliders.MenuSliders
{
    public partial class BaseMenuSliderPanel : BaseSliderPanel
    {
        public BaseMenuSliderPanel()
        {
            InitializeComponent();
        }

        private const int OpenXConst = 660;
        private const int OpenYConst = 180;
        private const int ClosedXConst = 900;
        private const int ClosedYConst = 180;
        private const string TransitionDirectionConst = "Left";
        private const int TransitionAccelerationConst = 500;
        private const int DestinationOpenConst = 660;
        private const int DestinationClosedConst = 900;

        public BaseMenuSliderPanel(Form form, LoggedUser user)
            : base(form, OpenXConst, OpenYConst, ClosedXConst, ClosedYConst, TransitionDirectionConst
                  , TransitionAccelerationConst, DestinationOpenConst, DestinationClosedConst)
        {
            this.User = user;
        }

        public LoggedUser User { get; private set; }
    }
}