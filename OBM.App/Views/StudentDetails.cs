using AutoMapper;
using OBM.App.ViewModels;
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
    public partial class StudentDetails : Form
    {
        private string studentID;
        private bool changed;

        public string StudentID { get => studentID; set => studentID = value; }
        public bool Changed { get => changed; set => changed = value; }
        public StudentDetails()
        {
            InitializeComponent();
            //LoadForm();
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

        private void LoadForm()
        {
            var student = StudentService.Ins.GetSingleByID(studentID);
            var studentVM = Mapper.Map<StudentVM>(student);
            labStudentDetails.Text = "Sinh viên: " + studentVM.LastName + " " + studentVM.FirstName;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentDetails_Activated(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
