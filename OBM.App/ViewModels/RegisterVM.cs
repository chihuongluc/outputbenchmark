namespace OBM.App.ViewModels
{
    public class RegisterVM
    {
        public string ID { get; set; }
        public string StudentID { get; set; }
        public int SubjectID { get; set; }
        public string ScheduleID { get; set; }
        public virtual ScheduleVM Schedule { get; set; }
        public virtual StudentVM Student { get; set; }
        public virtual SubjectVM Subject { get; set; }
        public virtual ScoreVM Score { get; set; }
    }
}