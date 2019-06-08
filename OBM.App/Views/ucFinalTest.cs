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
            LoadTreeViewSubject();
            ResizeVerticalScrollBarOnFlowLayoutPanel(panelFinalTest, fpanelFinalTest);
        }

        private void ResizeVerticalScrollBarOnFlowLayoutPanel(Control pnl, Control fpnl)
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
            labTotal.Text = "Tổng: " + listFinalTestVM.Count();

            foreach (var item in listFinalTestVM)
            {
                TreeNode node = new TreeNode();
                node.Text = "Kỳ thi KTNL chuẩn đầu ra " + item.StartDate.ToString("dd/MM/yyyy");
                node.Tag = item.ID;
                node.Checked = true;
                tvFinalTest.Nodes.Add(node);
            }
            tvFinalTest.SelectedNode = tvFinalTest.Nodes[0];
        }

        private void LoadTreeViewSubject()
        {
            tvSubject.CheckBoxes = true;
            tvSubject.NodeMouseClick += TvSubject_NodeMouseClick;
            var listSubject = SubjectService.Ins.GetAll();
            var listSubjectVM = Mapper.Map<List<SubjectVM>>(listSubject);

            foreach (var item in listSubjectVM)
            {
                TreeNode node = new TreeNode();
                node.Text = "  " + item.Name;
                node.Tag = item.ID;
                tvSubject.Nodes.Add(node);
            }
        }

        private void TvFinalTest_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string finalTestID = e.Node.Tag.ToString();
            string name = e.Node.Text.ToString();

            var finalTest = FinalTestService.Ins.GetSingleByID(finalTestID);
            var finalTestVM = Mapper.Map<FinalTestVM>(finalTest);
            string startDate = finalTestVM.StartDate.ToString("dd/MM/yyyy");
            string endDate = finalTestVM.EndDate.HasValue ? finalTestVM.EndDate.Value.ToString("dd/MM/yyyy") : "";
            string times = finalTestVM.Times.ToString();
            string done = finalTestVM.Done ? "Đã hoàn thành" : "Chưa hoàn thành";

            labName.Text = name;
            labStartDate.Text = "Ngày bắt đầu: " + startDate;
            labEndDate.Text = "Ngày kết thúc: " + endDate;
            labTimes.Text = "Đợt: " + times;
            labStatus.Text = "Trạng thái: " + done;
        }

        private void TvSubject_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Checked = !e.Node.Checked;
        }

        private void BtnAddFinalTest_Click(object sender, EventArgs e)
        {
            if (!Dashboard.Instance.PnlContainer.Controls.ContainsKey("UCTest"))
            {
                ucTest uc = new ucTest();
                uc.Dock = DockStyle.Fill;
                Dashboard.Instance.PnlContainer.Controls.Add(uc);
            }
            Dashboard.Instance.PnlContainer.Controls["UCTest"].BringToFront();
            Dashboard.Instance.BackButton.Enabled = true;
            Dashboard.Instance.PnlMenu.Enabled = false;
        }
    }
}
