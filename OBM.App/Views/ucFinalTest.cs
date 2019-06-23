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
using OBM.App.Mappings;

namespace OBM.App.Views
{
    public interface IFinalTest
    {
        void PerformRefresh();
    }

    public partial class ucFinalTest : UserControl, IFinalTest
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

        public void PerformRefresh()
        {
            LoadForm();
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
            tvFinalTest.Nodes.Clear();
            tvFinalTest.AfterSelect += TvFinalTest_AfterSelect;
            var listFinalTest = FinalTestService.Ins.GetAll();
            var listFinalTestVM = Mapper.Map<List<FinalTestVM>>(listFinalTest);
            listFinalTestVM = listFinalTestVM.OrderByDescending(p => p.StartDate).ToList();
            int count = listFinalTestVM.Count();
            labTotalFinalTest.Text = string.Format("Tổng: {0}", count);

            foreach (var item in listFinalTestVM)
            {
                TreeNode root = new TreeNode();
                root.Text = string.Format("Kỳ thi KTNL CĐR {0}", item.StartDate.ToString("dd/MM/yyyy"));
                root.Tag = item.ID;
                root.Checked = true;

                TreeNode startDate = new TreeNode()
                {
                    Text = string.Format("Ngày bắt đầu: {0}", item.StartDate.ToString("dd/MM/yyyy"))
                };
                TreeNode endDate = new TreeNode()
                {
                    Text = string.Format("Ngày kết thúc: {0}", (item.EndDate.HasValue ? item.EndDate.Value.ToString("dd/MM/yyyy") : "..."))
                };
                TreeNode times = new TreeNode()
                {
                    Text = string.Format("Đợt: {0}", (item.Times.HasValue ? item.Times.ToString() : "..."))
                };
                TreeNode done = new TreeNode()
                {
                    Text = string.Format("Trạng thái: {0}", (item.Done ? "Đã hoàn thành" : "Chưa hoàn thành"))
                };
                root.Nodes.Add(startDate);
                root.Nodes.Add(endDate);
                root.Nodes.Add(times);
                root.Nodes.Add(done);
                tvFinalTest.Nodes.Add(root);
            }

            if(count != 0)
                tvFinalTest.SelectedNode = tvFinalTest.Nodes[0];
        }

        private void LoadSchedule(string finalTestID)
        {
            var listSchedule = ScheduleService.Ins.GetByFinalTestID(finalTestID, new string[] { "Subject", "Room" });
            var listScheduleVM = Mapper.Map<IEnumerable<ScheduleVM>>(listSchedule);
            listScheduleVM = listScheduleVM.OrderBy(p => p.Subject.Name);
            labTotalSchedule.Text = string.Format("Tổng: {0}", listScheduleVM.Count());

            foreach (var item in listScheduleVM)
            {
                ucRowSchedule uc = new ucRowSchedule();
                uc.Subject = string.Format("{0} ({1})", item.Subject.Name, item.GroupOf);
                uc.DateTime = string.Format("Thời gian: {0} - Ngày {1:dd/MM/yyyy}", item.TestTime, item.TestDate);
                uc.Room = string.Format("Phòng: {0}", item.Room.Name);
                uc.Width = flpSchedule.Width - 20;
                uc.BtnEdit.Tag = item.ID;
                uc.BtnEdit.Click += BtnEdit_Click;
                flpSchedule.Controls.Add(uc);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using(UpdateSchedule frm = new UpdateSchedule())
            {
                frm.ScheduleID = (sender as Button).Tag.ToString();
                frm.ucFinalTest = this;
                frm.ShowDialog();
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
            labScheduleTitle.Text = e.Node.Text;
            LoadSchedule(finalTestID);
        }

        private void BtnAddFinalTest_Click(object sender, EventArgs e)
        {
            // Kiểm tra các kỳ thi đã hoàn thành chưa?
            if (FinalTestService.Ins.GetStatus(out string startDate))
            {
                string mess = string.Format("Vui lòng đóng kỳ thi KTNL CĐR {0} trước khi mở kỳ thi mới.", startDate);
                MessageBox.Show(mess, "Thêm kỳ thi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            using (AddFinalTest frm = new AddFinalTest())
            {
                frm.ucFinalTest = this;
                frm.ShowDialog();
            }
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            // UserControl chưa từng được mở thì thêm mới vào
            if (!Dashboard.Instance.PnlContainer.Controls.ContainsKey("ucSchedules"))
            {
                ucSchedules uc = new ucSchedules();
                uc.FinalTestName = labScheduleTitle.Text;
                uc.Dock = DockStyle.Fill;
                Dashboard.Instance.PnlContainer.Controls.Add(uc);
            }

            // Hiển thị UserControl
            Dashboard.Instance.PnlContainer.Controls["ucSchedules"].BringToFront();
            Dashboard.Instance.BackButton.Visible = true;
            Dashboard.Instance.PnlMenu.Enabled = false;
        }
    }
}
