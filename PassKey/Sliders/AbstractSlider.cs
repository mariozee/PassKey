using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using MetroFramework.Controls;

namespace PassKey.Sliders
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<AbstractSlider, MetroUserControl>))]
    public abstract class AbstractSlider : MetroUserControl
    {
        private bool loaded;
        private Form mainForm;
        private int yOpen;
        private int xOpen;
        private int xClosed;
        private int yClosed;
        private string transitionDirection;
        private int tranAcceleration;
        private int destinationOpen;
        private int destinationClosed;

        protected AbstractSlider(Form form
            , int xOpen, int yOpen, int xClosed
            , int yClosed, string transitionDirection, int tranAcceleration
            , int destinationOpen, int destinationClosed)
        {

            this.Visible = false;
            this.loaded = false;

            this.mainForm = form;
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

            LocalizePanel();
        }

        protected void LocalizePanel()
        {
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
                this.LocalizePanel();
            }
        }
    }
}