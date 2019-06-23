using System.Collections.Generic;

namespace OBM.App.ViewModels
{
    public class SubjectVM
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RegisterVM> Registers { get; set; }
        public virtual ICollection<ScheduleVM> Schedules { get; set; }
    }
}