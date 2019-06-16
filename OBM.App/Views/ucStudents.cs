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
    public partial class ucStudents : UserControl
    {
        public ucStudents()
        {
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            var listStudent = StudentService.Ins.GetAll();
            var listStudentVM = Mapper.Map<List<StudentVM>>(listStudent)
                .Select(p => new
                {
                    ID = p.ID,
                    Fullname = p.LastName + " " + p.FirstName,
                    Gender = p.Gender,
                    Birthday = p.Birthday,
                    Birthplace = p.Birthplace,
                    Course = p.Course
                })
                .ToList();

            labTotal.Text = "Tổng: " + listStudentVM.Count();
            dtgv.DataSource = listStudentVM;

            // Xoá auto size cho tất cả các column
            for (int i = 0; i < dtgv.Columns.Count - 1; i++)
                dtgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            string[] colHeader = { "MSSV", "Họ Tên", "Giới tính", "Ngày sinh", "Nơi sinh", "Lớp" };
            int[] colWidth = { 120, 240, 100, 150, 200, 100 };

            // Đổi tên các column header và set độ rộng
            for (int i = 0; i < dtgv.Columns.Count; i++)
            {
                dtgv.Columns[i].HeaderText = colHeader[i];
                dtgv.Columns[i].Width = colWidth[i];
                if (i == dtgv.Columns.Count - 1)
                    dtgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                // UserControl chưa từng được mở thì thêm mới vào
                if (!Dashboard.Instance.PnlContainer.Controls.ContainsKey("ucStudentDetails"))
                {
                    ucStudentDetails uc = new ucStudentDetails();
                    uc.Dock = DockStyle.Fill;
                    uc.StudentID = dtgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Dashboard.Instance.PnlContainer.Controls.Add(uc);
                }

                // Hiển thị UserControl
                Dashboard.Instance.PnlContainer.Controls["ucStudentDetails"].BringToFront();
                Dashboard.Instance.BackButton.Visible = true;
                Dashboard.Instance.PnlMenu.Enabled = false;
            }
        }

    }
}
