﻿using System;
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
using System.Threading;

namespace PassKey
{
    public partial class MainForm : MetroForm
    {
        private LoginPanel loginPanel;

        public MainForm()
        {
           InitializeComponent();
            loginPanel = new LoginPanel(this);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.loginPanel.Swipe(true);          
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void closeLink_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void minimizeLink_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
