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
using Transitions;

namespace PassKey.Sliders
{
    public partial class BaseSliderPanel : MetroUserControl
    {
        public BaseSliderPanel()
        {
            InitializeComponent();
        }

        public BaseSliderPanel(Form form
            , int xOpen, int yOpen, int xClosed
            , int yClosed, string transitionDirection, int tranAcceleration
            , int destinationOpen, int destinationClosed) : base()
        {
            this.Visible = false;
            this.IsLoaded = false;

            this.MainForm = form;
            this.OpenX = xOpen;
            this.OpenY = yOpen;
            this.ClosedX = xClosed;
            this.ClosedY = yClosed;
            this.TransitionDirection = transitionDirection;
            this.TransitionAcceleration = tranAcceleration;
            this.DestinationOpen = destinationOpen;
            this.DestinatioClosed = destinationClosed;

            this.MainForm.Controls.Add(this);
            this.BringToFront();

            LocalizePanel();
        }

        protected bool IsLoaded { get; set; }

        protected Form MainForm { get; set; }

        protected int OpenY { get; set; }

        protected int OpenX { get; set; }

        protected int ClosedY { get; set; }

        protected int ClosedX { get; set; }

        protected string TransitionDirection { get; set; }

        protected int TransitionAcceleration { get; set; }

        protected int DestinationOpen { get; set; }

        protected int DestinatioClosed { get; set; }

        protected void LocalizePanel()
        {
            int x = this.IsLoaded ? this.OpenX : this.ClosedX;
            int y = this.IsLoaded ? this.OpenY : this.ClosedY;
            this.Location = new Point(x, y);
        }

        public void Swipe(bool shown = true)
        {
            this.Visible = true;

            var transitionType = new TransitionType_Acceleration(this.TransitionAcceleration);
            Transition transition = new Transition(transitionType);
            int destination = shown ? this.DestinationOpen : this.DestinatioClosed;

            transition.add(this, this.TransitionDirection, destination);
            transition.run();

            while (this.Left != destination)
            {
                Application.DoEvents();
            }

            if (!shown)
            {
                this.MainForm.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                this.IsLoaded = true;
                this.LocalizePanel();
            }
        }
    }
}