using System;
using System.Collections.Generic;

namespace OBM.App.ViewModels
{
    public class FinalTestVM
    {
        public string ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Times { get; set; }
        public bool Done { get; set; }
        public virtual ICollection<ScheduleVM> Schedules { get; set; }
    }
}