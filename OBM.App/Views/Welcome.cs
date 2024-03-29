﻿using OBM.App.Common;
using System;
using System.Windows.Forms;

namespace OBM.App.Views
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            Extentions.AddFormIntoPanel(new Login(this), panelControl);
        }

        /// <summary>
        /// Set Border style 3D cho Form
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = 0x00020000;
                return cp;
            }
        }

        public void OpenFormLoginAfterCloseThisForm(object sender, FormClosedEventArgs e)
        {
            Extentions.AddFormIntoPanel(new Login(this), panelControl);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}