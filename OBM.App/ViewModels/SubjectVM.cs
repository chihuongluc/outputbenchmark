using System.Collections.Generic;

namespace OBM.App.ViewModels
{
    public class SubjectVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<RegisterVM> Registers { get; set; }
        public virtual ICollection<ScheduleVM> Schedules { get; set; }
    }
}