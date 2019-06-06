using OBM.Data.Models;
using OBM.Service;
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
    public partial class Students : Form
    {
        public Students()
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
            var list = StudentService.Ins.GetAll()
                .Select(p=> new { ID = p.ID, Fullname = p.LastName +" "+ p.FirstName, Gender = p.Gender, Birthday = p.Birthday, Birthplace = p.Birthplace, Course = p.Course}).ToList();

            dtgv.DataSource = list;

            // Xoá auto size cho tất cả các column
            for (int i = 0; i < dtgv.Columns.Count-1; i++)
                dtgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            string[] colHeader = { "MSSV", "Họ Tên", "Giới tính", "Ngày sinh", "Nơi sinh", "Lớp" };
            int[] colWidth = { 120, 240, 100, 150, 200, 100};

            // Đổi tên các column và set độ rộng
            for (int i = 0; i < dtgv.Columns.Count; i++)
            {
                dtgv.Columns[i].HeaderText = colHeader[i];
                dtgv.Columns[i].Width = colWidth[i];
                if (i == dtgv.Columns.Count - 1)
                    dtgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dtgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentDetails fStudentDetails = new StudentDetails();
            fStudentDetails.ShowDialog();
        }
    }
}
