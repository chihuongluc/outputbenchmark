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
    public partial class ucStudentDetails : UserControl
    {
        #region Properties
        private string studentID;
        public string StudentID { get => studentID; set => studentID = value; }

        private int ngayIndex;
        #endregion

        public ucStudentDetails()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            LoadGender(cbGender);
            LoadBirthplace(cbBirthplace);
            LoadYear(cbYear);
            LoadMonth(cbMonth);
            LoadDay(31);
            cbDay.SelectedIndex = 0;
            EnableControls(false);
        }

        private void UcStudentDetails_Load(object sender, EventArgs e)
        {
            var student = StudentService.Ins.GetSingleByID(studentID);
            var studentVM = Mapper.Map<StudentVM>(student);

            string fullname = studentVM.LastName + " " + studentVM.FirstName;
            string mobile = studentVM.Mobile;
            string email = studentVM.Email;
            string gender = studentVM.Gender;
            string course = studentVM.Course;
            string birthday = studentVM.Birthday;
            string birthplace = studentVM.Birthplace;

            labTitle.Text = "SV " + fullname;
            txbStudentID.Text = studentID;
            txbFullname.Text = fullname;
            txbCourse.Text = course;
            txbMobile.Text = mobile;
            txbEmail.Text = email;
            cbGender.Text = gender;
            cbBirthplace.Text = birthplace;
            if (birthday.Length > 4)
            {
                string day = birthday.Substring(0, 2);
                cbDay.Text = day.IndexOf("0") == 0 ? day.Substring(1, 1) : day;
                string month = birthday.Substring(3, 2);
                cbMonth.Text = month.IndexOf("0") == 0 ? month.Substring(1, 1) : month;
                cbYear.Text = birthday.Substring(6, 4);
            }
            else
            {
                cbYear.Text = birthday;
                cbMonth.SelectedIndex = 0;
                cbDay.SelectedIndex = 0;
            }
        }

        private void EnableControls(bool enable)
        {
            txbFullname.Enabled = enable;
            txbCourse.Enabled = enable;
            txbEmail.Enabled = enable;
            txbMobile.Enabled = enable;
            cbDay.Enabled = enable;
            cbMonth.Enabled = enable;
            cbYear.Enabled = enable;
            cbGender.Enabled = enable;
            cbBirthplace.Enabled = enable;
        }

        #region Load Combobox
        private void LoadGender(ComboBox cb)
        {
            List<GenderVM> listGender = new List<GenderVM>()
            {
                new GenderVM(){Name="Nam"},
                new GenderVM(){Name="Nữ"}
            };
            cb.DataSource = listGender;
            cb.DisplayMember = "Name";
        }

        private void LoadBirthplace(ComboBox cb)
        {
            List<BirthplaceVM> listBirthplace = new List<BirthplaceVM>()
            {
                new BirthplaceVM(){Name="An Giang"},
                new BirthplaceVM(){Name="Bạc Liêu"},
                new BirthplaceVM(){Name="Bến Tre"},
                new BirthplaceVM(){Name="Cà Mau"},
                new BirthplaceVM(){Name="Cần Thơ"},
                new BirthplaceVM(){Name="Đà Nẵng"},
                new BirthplaceVM(){Name="Đồng Tháp"},
                new BirthplaceVM(){Name="Hà Nội"},
                new BirthplaceVM(){Name="Hậu Giang"},
                new BirthplaceVM(){Name="Kiên Giang"},
                new BirthplaceVM(){Name="Long An"},
                new BirthplaceVM(){Name="Sóc Trăng"},
                new BirthplaceVM(){Name="Thanh Hoá"},
                new BirthplaceVM(){Name="Thừa Thiên Huế"},
                new BirthplaceVM(){Name="Tiền Giang"},
                new BirthplaceVM(){Name="TP.Hồ Chí Minh"},
                new BirthplaceVM(){Name="Trà Vinh"},
                new BirthplaceVM(){Name="Vĩnh Long"},
                new BirthplaceVM(){Name="Yên Bái"}
            };
            cb.DataSource = listBirthplace;
            cb.DisplayMember = "Name";
        }

        private void LoadYear(ComboBox cb)
        {
            int maxYear = DateTime.Now.Year - 16;
            int minYear = maxYear - 34;

            cb.Items.Add("Năm");
            for (int i = maxYear; i >= minYear; i--)
            {
                cb.Text = i.ToString();
                cb.Items.Add(i);
            }
            cb.SelectedIndex = 0;
        }

        private void LoadMonth(ComboBox cb)
        {
            cb.Items.Add("Tháng");
            for (int i = 1; i <= 12; i++)
            {
                cb.Text = i.ToString();
                cb.Items.Add(i);
            }
            cb.SelectedIndex = 0;
        }

        private void LoadDay(int ngayToiDa)
        {
            cbDay.Items.Clear();
            cbDay.Items.Add("Ngày");
            for (int i = 1; i <= ngayToiDa; i++)
            {
                cbDay.Text = i.ToString();
                cbDay.Items.Add(i);
            }
        }

        private int LayNgayToiDa(int thang)
        {
            int ngayToiDa = 0;

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ngayToiDa = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    ngayToiDa = 30;
                    break;
                case 2:
                    if (cbYear.SelectedIndex > 0 && ((Int32.Parse(cbYear.Text) % 4 == 0 && Int32.Parse(cbYear.Text) % 100 != 0) || Int32.Parse(cbYear.Text) % 400 == 0))
                        ngayToiDa = 29;
                    else
                        ngayToiDa = 28;
                    break;
                default:
                    break;
            }
            return ngayToiDa;
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex < 1)
                return;

            if (cbMonth.Text != "")
            {
                int ngayMax = LayNgayToiDa(cbMonth.SelectedIndex);
                LoadDay(ngayMax);
                if (ngayIndex <= ngayMax)
                    cbDay.SelectedIndex = ngayIndex;
                else
                    cbDay.SelectedIndex = 0;
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex < 1)
                return;

            if (cbYear.Text != "")
            {
                int ngayMax = LayNgayToiDa((sender as ComboBox).SelectedIndex);
                LoadDay(ngayMax);
                if (ngayIndex <= ngayMax)
                    cbDay.SelectedIndex = ngayIndex;
                else
                    cbDay.SelectedIndex = 0;
            }
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex < 1)
                return;

            ngayIndex = (sender as ComboBox).SelectedIndex;
        }
#endregion

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            txbFullname.Focus();
        }

        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            // update student's info
            // reload form
            EnableControls(false);
        }
    }
}
