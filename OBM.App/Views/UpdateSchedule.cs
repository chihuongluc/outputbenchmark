using AutoMapper;
using OBM.App.ViewModels;
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
using OBM.App.Mappings;

namespace OBM.App.Views
{
    public partial class UpdateSchedule : Form
    {
        public IFinalTest ucFinalTest { get; set; }
        private bool isChanged = false;
        private int ngayIndex;
        private Schedule schedule;
        public string ScheduleID { get; set; }
        public UpdateSchedule()
        {
            InitializeComponent();
            LoadForm();
        }

        private void ClosedForm()
        {
            if (isChanged)
                this.ucFinalTest.PerformRefresh();
            this.Close();
        }

        private void LoadForm()
        {
            LoadRoom(cbRoom);
            LoadHour(cbHour);
            LoadMinute(cbMinute);
            LoadYear(cbYear);
            LoadMonth(cbMonth);
            LoadDay(31);
            cbDay.SelectedIndex = 0;
        }

        private void LoadRoom(ComboBox cb)
        {
            var listRooms = RoomService.Ins.GetAll();
            var listRoomsVM = Mapper.Map<List<RoomVM>>(listRooms);

            cb.DataSource = listRoomsVM;
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
        }

        private void LoadHour(ComboBox cb)
        {
            cb.Items.Add("Giờ");
            for (int i = 7; i <= 15; i++)
            {
                if (i == 10 || i == 11 || i == 12)
                    continue;
                cb.Text = i.ToString();
                cb.Items.Add(string.Format("{0:00}", i));
            }
            cb.SelectedIndex = 0;
        }

        private void LoadMinute(ComboBox cb)
        {
            cb.Items.Add("Phút");
            for (int i = 0; i < 60; i = i + 15)
            {
                cb.Text = i.ToString();
                cb.Items.Add(string.Format("{0:00}", i));
            }
            cb.SelectedIndex = 0;
        }

        private void LoadYear(ComboBox cb)
        {
            int minYear = DateTime.Now.Year;
            int maxYear = minYear + 1;

            cb.Items.Add("Năm");
            for (int i = minYear; i <= maxYear; i++)
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

        #region Methods bắt lỗi
        private bool ValidateForm()
        {
            bool bValidDate = ValidateDate();
            bool bValidTime = ValidateTime();
            bool bValidRoom = ValidateRoom();
            if (bValidDate && bValidTime && bValidRoom)
                return true;
            else
                return false;
        }

        private bool ValidateDate()
        {
            bool bStatus = true;
            if (cbDay.SelectedIndex < 1 || cbMonth.SelectedIndex < 1 || cbYear.SelectedIndex < 1)
            {
                errorProvider1.SetError(cbYear, "Vui lòng chọn Ngày thi");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(cbYear, null);

                int day = DateTime.Now.Day;
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;

                if (int.Parse(cbYear.Text) == year)
                {
                    if (int.Parse(cbMonth.Text) < month)
                    {
                        errorProvider1.SetError(cbYear, "Ngày thi phải lớn hơn ngày hiện tại");
                        bStatus = false;
                    }
                    else if (int.Parse(cbMonth.Text) == month)
                    {
                        if (int.Parse(cbDay.Text) <= day)
                        {
                            errorProvider1.SetError(cbYear, "Ngày thi phải lớn hơn ngày hiện tại");
                            bStatus = false;
                        }
                        else
                        {
                            errorProvider1.SetError(cbYear, null);
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(cbYear, null);
                    }
                }
                else
                {
                    errorProvider1.SetError(cbYear, null);
                }
            }
            return bStatus;
        }

        private bool ValidateTime()
        {
            bool bStatus = true;
            if (cbHour.SelectedIndex < 1 || cbMinute.SelectedIndex < 1)
            {
                errorProvider1.SetError(cbMinute, "Vui lòng chọn Thời gian thi");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(cbMinute, null);
            }
            return bStatus;
        }

        private bool ValidateRoom()
        {
            bool bStatus = true;
            if (string.IsNullOrWhiteSpace(cbRoom.Text))
            {
                errorProvider1.SetError(cbRoom, "Vui lòng nhập vào Phòng thi");
                bStatus = false;
            }
            else
                errorProvider1.SetError(cbRoom, null);
            return bStatus;
        }
        #endregion

        private void BtnExit_Click(object sender, EventArgs e)
        {
            ClosedForm();
        }

        private void UpdateSchedule_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ScheduleID))
                return;

            schedule = ScheduleService.Ins.GetSingleById(ScheduleID);
            var scheduleVM = Mapper.Map<ScheduleVM>(schedule);

            labTitle.Text = string.Format("{0} ({1})", scheduleVM.Subject.Name, scheduleVM.GroupOf);
            cbRoom.Text = scheduleVM.Room.Name;
            string testDate = scheduleVM.TestDate.ToString("dd/MM/yyyy");
            string day = testDate.Substring(0, 2);
            cbDay.Text = day.IndexOf("0") == 0 ? day.Substring(1, 1) : day;
            string month = testDate.Substring(3, 2);
            cbMonth.Text = month.IndexOf("0") == 0 ? month.Substring(1, 1) : month;
            cbYear.Text = testDate.Substring(6, 4);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            // kiểm tra ngày, giờ, phòng phải khác những lịch thi khác

            int day = int.Parse(cbDay.Text);
            int month = int.Parse(cbMonth.Text);
            int year = int.Parse(cbYear.Text);
            string time = cbHour.Text + "h" + ((cbMinute.Text.Length < 2) ? ("0" + cbMinute.Text) : (cbMinute.Text));

            schedule.TestDate = new DateTime(year, month, day);
            schedule.TestTime = time;
            schedule.RoomID = (cbRoom.SelectedItem as RoomVM).ID;
            ScheduleService.Ins.Update(schedule);
            if (UnitOfWork.Ins.Commit())
            {
                isChanged = true;
                MessageBox.Show("Cập nhật lịch thi thành công!", "Cập nhật lịch thi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClosedForm();
            }
        }
    }
}
