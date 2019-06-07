using System.Collections.Generic;

namespace OBM.App.ViewModels
{
    public class ScheduleVM
    {
        public string ID { get; set; }
        public string FinalTestID { get; set; }
        public int SubjectID { get; set; }
        public int RoomID { get; set; }
        public string TestDate { get; set; }
        public string TestTime { get; set; }
        public virtual FinalTestVM FinalTest { get; set; }
        public virtual ICollection<RegisterVM> Registers { get; set; }
        public virtual RoomVM Room { get; set; }
        public virtual SubjectVM Subject { get; set; }
    }
}