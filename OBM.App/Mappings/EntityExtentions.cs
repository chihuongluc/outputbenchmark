using OBM.App.ViewModels;
using OBM.Data.Models;

namespace OBM.App.Mappings
{
    public static class EntityExtentions
    {
        public static void UpdateFinalTest(this FinalTest model, FinalTestVM viewModel)
        {
            model.ID = viewModel.ID;
            model.StartDate = viewModel.StartDate;
            model.EndDate = viewModel.EndDate;
            model.Times = viewModel.Times;
            model.Done = viewModel.Done;
        }

        public static void UpdateRoom(this Room model, RoomVM viewModel)
        {
            model.ID = viewModel.ID;
            model.Name = viewModel.Name;
            model.MaxSize = viewModel.MaxSize;
        }

        public static void UpdateRegister(this Register model, RegisterVM viewModel)
        {
            model.ID = viewModel.ID;
            model.StudentID = viewModel.StudentID;
            model.SubjectID = viewModel.SubjectID;
            model.ScheduleID = viewModel.ScheduleID;
        }

        public static void UpdateStudent(this Student model, StudentVM viewModel)
        {
            model.ID = viewModel.ID;
            model.LastName = viewModel.LastName;
            model.FirstName = viewModel.FirstName;
            model.Gender = viewModel.Gender;
            model.Birthday = viewModel.Birthday;
            model.Birthplace = viewModel.Birthplace;
            model.Course = viewModel.Course;
            model.Mobile = viewModel.Mobile;
            model.Email = viewModel.Email;
            model.PassForeignLanguage = viewModel.PassForeignLanguage;
            model.PassInformationTechnology = viewModel.PassInformationTechnology;
        }

        public static void UpdateSchedule(this Schedule model, ScheduleVM viewModel)
        {
            model.ID = viewModel.ID;
            model.FinalTestID = viewModel.FinalTestID;
            model.SubjectID = viewModel.SubjectID;
            model.GroupOf = viewModel.GroupOf;
            model.MaxSize = viewModel.MaxSize;
            model.RoomID = viewModel.RoomID;
            model.TestDate = viewModel.TestDate;
            model.TestTime = viewModel.TestTime;
        }

        public static void UpdateSubject(this Subject model, SubjectVM viewModel)
        {
            model.ID = viewModel.ID;
            model.Name = viewModel.Name;
        }

        public static void UpdateScore(this Score model, ScoreVM viewModel)
        {
            model.ID = viewModel.ID;
            model.Code = viewModel.Code;
            model.Times = viewModel.Times;
            model.Value = viewModel.Value;
            model.Passed = viewModel.Passed;
            model.Note = viewModel.Note;
        }

        public static void UpdateToeicScore(this ToeicScore model, ToeicScoreVM viewModel)
        {
            model.ID = viewModel.ID;
            model.Listening = viewModel.Listening;
            model.Reading = viewModel.Reading;
        }

        public static void UpdateChineseScore(this ChineseScore model, ChineseScoreVM viewModel)
        {
            model.ID = viewModel.ID;
        }

        public static void UpdateITScore(this ITScore model, ITScoreVM viewModel)
        {
            model.ID = viewModel.ID;
            model.WindowInternet = viewModel.WindowInternet;
            model.Word = viewModel.Word;
            model.Excel = viewModel.Excel;
            model.PowerPoint = viewModel.PowerPoint;
        }

        public static void UpdateRole(this Role model, RoleVM viewModel)
        {
            model.ID = viewModel.ID;
            model.Name = viewModel.Name;
        }

        public static void UpdateAccount(this Account model, AccountVM viewModel)
        {
            model.UserName = viewModel.UserName;
            model.Password = viewModel.Password;
            model.Email = viewModel.Email;
            model.RoleID = viewModel.RoleID;
        }
    }
}