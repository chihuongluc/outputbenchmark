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
        public Dashboard()
        {
            InitializeComponent();
            Extentions.AddFormIntoPanel(new Students(), panelControl);
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
            Extentions.AddFormIntoPanel(new Students(), panelControl);
        }
    }
}
