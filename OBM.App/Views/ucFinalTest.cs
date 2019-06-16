using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBM.Service;
using AutoMapper;
using OBM.App.ViewModels;

namespace OBM.App.Views
{
    public partial class ucFinalTest : UserControl
    {
        public ucFinalTest()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            LoadTreeViewFinalTest();
            ResizeVerticalScrollBar(pnlFinalTest, flpFinalTest);
            ResizeVerticalScrollBar(pnlSchedule, flpSchedule);
        }

        /// <summary>
        /// Hàm thu nhỏ Scroll bar
        /// </summary>
        /// <param name="pnl">Panel cha</param>
        /// <param name="fpnl">FlowLayoutPanel con</param>
        private void ResizeVerticalScrollBar(Control pnl, Control fpnl)
        {
            fpnl.Parent = pnl;
            fpnl.Location = new Point(0, 0);
            fpnl.Width = pnl.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
            fpnl.Height = pnl.ClientRectangle.Height;
        }

        private void LoadTreeViewFinalTest()
        {
            tvFinalTest.AfterSelect += TvFinalTest_AfterSelect;
            var listFinalTest = FinalTestService.Ins.GetAll();
            var listFinalTestVM = Mapper.Map<List<FinalTestVM>>(listFinalTest);
            labTotalFinalTest.Text = "Tổng: " + listFinalTestVM.Count();

            foreach (var item in listFinalTestVM)
            {
                TreeNode root = new TreeNode();
                root.Text = "Kỳ thi KTNL CĐR " + item.StartDate.ToString("dd/MM/yyyy");
                root.Tag = item.ID;
                root.Checked = true;

                TreeNode startDate = new TreeNode() { Text = "Ngày bắt đầu: " + item.StartDate.ToString("dd/MM/yyyy") };
                TreeNode endDate = new TreeNode() { Text = "Ngày kết thúc: " + (item.EndDate.HasValue ? item.EndDate.Value.ToString("dd/MM/yyyy") : "...") };
                TreeNode times = new TreeNode() { Text = "Đợt: " + (item.Times.HasValue ? item.Times.ToString() : "...") };
                TreeNode done = new TreeNode() { Text = "Trạng thái: " + (item.Done ? "Đã hoàn thành" : "Chưa hoàn thành") };
                root.Nodes.Add(startDate);
                root.Nodes.Add(endDate);
                root.Nodes.Add(times);
                root.Nodes.Add(done);
                tvFinalTest.Nodes.Add(root);
            }
            tvFinalTest.SelectedNode = tvFinalTest.Nodes[0];
        }

        private void LoadSchedule(string finalTestID)
        {
            var listSchedule = ScheduleService.Ins.GetByFinalTestID(finalTestID);
            var listScheduleVM = Mapper.Map<List<ScheduleVM>>(listSchedule);
            labTotalSchedule.Text = "Tổng: " + listScheduleVM.Count();

            foreach (var item in listScheduleVM)
            {
                ucSchedule uc = new ucSchedule();
                uc.Date = item.TestDate;
                uc.Time = item.TestTime;
                uc.Subject = item.Subject.Name;
                uc.Room = item.Room.Name;
                flpSchedule.Controls.Add(uc);
            }
        }

        private void TvFinalTest_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Nếu không phải nút cha thì return
            if (e.Node.Tag == null)
                return;

            // Xoá tất cả controls đang có trong flp
            if (flpSchedule.Controls.Count > 0)
                flpSchedule.Controls.Clear();

            // Load lại các controls mới vào flp theo finalTestID
            string finalTestID = e.Node.Tag.ToString();
            labScheduleTitle.Text = "Lịch thi " + e.Node.Text;
            LoadSchedule(finalTestID);
        }

        private void BtnAddFinalTest_Click(object sender, EventArgs e)
        {

        }

        private void BtnScheduleDetails_Click(object sender, EventArgs e)
        {
            // UserControl chưa từng được mở thì thêm mới vào
            if (!Dashboard.Instance.PnlContainer.Controls.ContainsKey("ucScheduleDetails"))
            {
                ucScheduleDetails uc = new ucScheduleDetails();
                uc.Dock = DockStyle.Fill;
                Dashboard.Instance.PnlContainer.Controls.Add(uc);
            }

            // Hiển thị UserControl
            Dashboard.Instance.PnlContainer.Controls["ucScheduleDetails"].BringToFront();
            Dashboard.Instance.BackButton.Visible = true;
            Dashboard.Instance.PnlMenu.Enabled = false;
        }
    }
}
