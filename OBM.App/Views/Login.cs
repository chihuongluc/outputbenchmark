﻿using OBM.App.Common;
using System;
using System.Windows.Forms;

namespace OBM.App.Views
{
    public partial class Login : Form
    {
        private Welcome _fWelcome;

        public Login(Welcome fWelcome)
        {
            InitializeComponent();
            this._fWelcome = fWelcome;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard fDashboard = new Dashboard();
            fDashboard.ShowDialog();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            Extentions.ShowPassword(sender as CheckBox, txbPassword);
        }
    }
}