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
using OBM.App.Mappings;
using OBM.App.Common;
using OBM.Data.Models;

namespace OBM.App.Views
{
    public partial class AddFinalTest : Form
    {
        public IFinalTest ucFinalTest { get; set; }
        private bool isChanged = false;

        public AddFinalTest()
        {
            InitializeComponent();
        }

        private void ClosedForm()
        {
            if (isChanged)
                this.ucFinalTest.PerformRefresh();
            this.Close();
        }

        /// <summary>
        /// Thêm lịch thi cho kỳ thi
        /// </summary>
        /// <param name="finalTestID">kỳ thi</param>
        /// <param name="subjectID">môn thi</param>
        /// <returns></returns>
        private Schedule AddSchedule(string finalTestID, string subjectID)
        {
            ScheduleVM scheduleVM = new ScheduleVM()
            {
                ID = Guid.NewGuid().ToString(),
                FinalTestID = finalTestID,
                SubjectID = subjectID,
                GroupOf = 1,
                MaxSize = 30,
                TestDate = DateTime.Now.Date,
                //TestTime = "7h30",
                RoomID = 1
            };
            Schedule schedule = new Schedule();
            schedule.UpdateSchedule(scheduleVM);
            return schedule;
        }

        /// <summary>
        /// Lấy số đợt thi theo năm
        /// </summary>
        /// <param name="year">năm mở kỳ thi</param>
        /// <returns></returns>
        private int GetTimesByYear(int year)
        {
            return FinalTestService.Ins.GetTimesByYear(year);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            ClosedForm();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(!chkToeic.Checked && !chkHoaVan.Checked && !chkTHVP.Checked && !chkTHCB.Checked)
            {
                MessageBox.Show("Vui lòng chọn tối thiểu 01 chuẩn đầu ra.", "Thêm kỳ thi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string finalTestID = Guid.NewGuid().ToString();
            DateTime startDate = DateTime.Now.Date;
            int times = GetTimesByYear(startDate.Year);

            if (chkToeic.Checked)
                ScheduleService.Ins.Add(AddSchedule(finalTestID, Extentions.toeicID));
            if (chkHoaVan.Checked)
                ScheduleService.Ins.Add(AddSchedule(finalTestID, Extentions.hoaVanID));
            if (chkTHVP.Checked)
                ScheduleService.Ins.Add(AddSchedule(finalTestID, Extentions.thvpID));
            if (chkTHCB.Checked)
                ScheduleService.Ins.Add(AddSchedule(finalTestID, Extentions.thcbID));

            FinalTest finalTest = new FinalTest();
            FinalTestVM finalTestVM = new FinalTestVM()
            {
                ID = finalTestID,
                StartDate = startDate,
                Times = times + 1
            };
            finalTest.UpdateFinalTest(finalTestVM);
            FinalTestService.Ins.Add(finalTest);
            if (UnitOfWork.Ins.Commit())
            {
                isChanged = true;
                MessageBox.Show("Mở kỳ thi thành công!", "Thêm kỳ thi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClosedForm();
            }
        }
    }
}
