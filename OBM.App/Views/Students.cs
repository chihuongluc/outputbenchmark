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
        StudentService s = new StudentService();
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
            // Set data
            List<Student> list = new List<Student>() {
                new Student() { ID = "150501001", LastName = "Lâm Tú", FirstName = "Phụng", Gender = "Nữ", Birthday = "01/01/1997", Birthplace = "Cà Mau", Course = "18TH0101", Mobile = "", Email = "" },
                new Student() { ID = "150501002", LastName = "Phạm Đạt", FirstName = "Lợi", Gender = "Nam", Birthday = "11/12/1996", Birthplace = "TP.Hồ Chí Minh", Course = "18TH0101", Mobile = "", Email = "" },
                new Student() { ID = "150501003", LastName = "Nguyễn Chí", FirstName = "Trung", Gender = "Nam", Birthday = "30/12/1995", Birthplace = "Bạc Liêu", Course = "18TH0101", Mobile = "", Email = "" }
            };
            dtgv.DataSource = s.GetAll().ToList();

            // Xoá auto size cho tất cả các column
            for (int i = 0; i < dtgv.Columns.Count-1; i++)
                dtgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            string[] colHeader = { "MSSV", "Họ", "Tên", "Phái", "Ngày sinh", "Nơi sinh", "Lớp", "SĐT", "Email" };
            int[] colWidth = { 90, 160, 80, 70, 110, 115, 100, 100, 300 };

            // Đổi tên các column và set độ rộng
            for (int i = 0; i < dtgv.Columns.Count-1; i++)
            {
                dtgv.Columns[i].HeaderText = colHeader[i];
                dtgv.Columns[i].Width = colWidth[i];
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
