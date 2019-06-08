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
        static Dashboard _obj;
        static string _formOpening = "";

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

        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        public Dashboard()
        {
            InitializeComponent();
            //Extentions.AddFormIntoPanel(new Students(), panelContainer);
            LoadNewForm(new Students(), "Students");
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

        private void LoadNewForm(object frm, string formName)
        {
            btnBack.Enabled = false;
            _obj = this;

            if (panelContainer.Controls.Count > 0)
                panelContainer.Controls.RemoveAt(0);
            Form f = frm as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(f);
            panelContainer.Tag = f;
            _formOpening = formName;
            f.Show();
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

        private void btnStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(sender as Button);
            //Extentions.AddFormIntoPanel(new Students(), panelContainer);
            LoadNewForm(new Students(), "Students");
        }

        private void btnFinalTest_Click(object sender, EventArgs e)
        {
            MoveSidePanel(sender as Button);
            //Extentions.AddFormIntoPanel(new FinalTest(), panelContainer);
            LoadNewForm(new FinalTest(), "FinalTest");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            panelContainer.Controls[_formOpening].BringToFront();
            btnBack.Visible = false;
        }
    }
}
