using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using Transitions;

namespace PassKey.Sliders
{
    public partial class AbstractSlider : MetroUserControl
    {
        protected bool loaded;
        protected Form mainForm;
        protected int width;
        protected int height;
        protected int yOpen;
        protected int xOpen;
        protected int xClosed;
        protected int yClosed;
        protected string transitionDirection;
        protected int tranAcceleration;
        protected int destinationOpen;
        protected int destinationClosed;

        public AbstractSlider()
        {
            //this.InitializeComponent();
        }

        public AbstractSlider(Form form
            , int width, int height, int xOpen, int yOpen, int xClosed
            , int yClosed, string transitionDirection, int tranAcceleration
            , int destinationOpen, int destinationClosed)
        {

            this.Visible = false;
            this.loaded = false;

            this.mainForm = form;
            this.width = width;
            this.height = height;
            this.xOpen = xOpen;
            this.yOpen = yOpen;
            this.xClosed = xClosed;
            this.yClosed = yClosed;
            this.transitionDirection = transitionDirection;
            this.tranAcceleration = tranAcceleration;
            this.destinationOpen = destinationOpen;
            this.destinationClosed = destinationClosed;

            this.mainForm.Controls.Add(this);
            this.BringToFront();

            ResizePanel();
        }

        protected void ResizePanel()
        {
            this.Width = this.width;
            this.Height = this.height;

            int x = this.loaded ? xOpen : xClosed;
            int y = this.loaded ? yOpen : yClosed;
            this.Location = new Point(x, y);
        }

        public void Swipe(bool shown = true)
        {
            this.Visible = true;

            var transitionType = new TransitionType_Acceleration(this.tranAcceleration);
            Transition transition = new Transition(transitionType);
            int destination = shown ? destinationOpen : destinationClosed;

            transition.add(this, transitionDirection, destination);
            transition.run();

            while (this.Left != destination)
            {
                Application.DoEvents();
            }

            if (!shown)
            {
                this.mainForm.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                this.loaded = true;
                this.ResizePanel();
            }
        }
    }
}