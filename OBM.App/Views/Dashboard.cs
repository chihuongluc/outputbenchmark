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
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }

        public Panel PnlMenu
        {
            get { return pnlMenu; }
            set { pnlMenu = value; }
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
        /// Hàm set style border 3D cho Form
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
            // Xoá tất cả UserControls đang có trong panel chính
            if (pnlContainer.Controls.Count > 0)
                pnlContainer.Controls.Clear();

            // Thêm UserControl được gọi vào panel chính
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);

            // Ẩn button Back và enable pnlMenu
            btnBack.Visible = false;
            pnlMenu.Enabled = true;
        }

        /// <summary>
        /// Hàm di chuyển panel đánh dấu khi click vào một chức năng trên pnlMenu
        /// </summary>
        /// <param name="btn"></param>
        private void MoveSidePanel(Control btn)
        {
            pnlSide.Top = btn.Top;
            pnlSide.Height = btn.Height;
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
            // Xoá các UserControls con nhưng giữ lại UserControl cha
            if (pnlContainer.Controls.Count > 0)
                for (int i = 0; i < pnlContainer.Controls.Count - 1; i++)
                    pnlContainer.Controls.RemoveAt(i);

            // Hiển thị lại UserControl cha và giữ nguyên trạng thái trước đó
            pnlContainer.Controls[0].BringToFront();
            btnBack.Visible = false;
            pnlMenu.Enabled = true;
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

        private void BtnScore_Click(object sender, EventArgs e)
        {
            MoveSidePanel(sender as Button);
            //LoadNewForm(new ucSchedule());
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            MoveSidePanel(sender as Button);
            //LoadNewForm(new ucSchedule());
        }
    }
}
