using OBM.App.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBM.App.Views
{
    public partial class Dashboard : Form
    {
        #region Properties
        static Dashboard _obj;

        public static Dashboard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Dashboard();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Panel PnlMenu
        {
            get { return panelMenu; }
            set { panelMenu = value; }
        }

        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        #endregion
        public Dashboard()
        {
            _obj = this;
            InitializeComponent();
            LoadNewForm(new ucStudents());
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

        private void LoadNewForm(UserControl uc)
        {
            if (panelContainer.Controls.Count > 0)
                for (int i = 0; i < panelContainer.Controls.Count; i++)
                    panelContainer.Controls.RemoveAt(i);

            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            btnBack.Enabled = false;
            panelMenu.Enabled = true;
        }

        private void MoveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Phần mềm Quản lý Điểm Chuẩn Đầu Ra BDU.CM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (panelContainer.Controls.Count > 0)
                for (int i = 0; i < panelContainer.Controls.Count - 1; i++)
                    panelContainer.Controls.RemoveAt(i);

            panelContainer.Controls[0].BringToFront();
            btnBack.Enabled = false;
            panelMenu.Enabled = true;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(sender as Button);
            LoadNewForm(new ucStudents());
        }

        private void btnFinalTest_Click(object sender, EventArgs e)
        {
            MoveSidePanel(sender as Button);
            LoadNewForm(new ucFinalTest());
        }
    }
}
