using System.Collections.Generic;

namespace OBM.App.ViewModels
{
    public class RoomVM
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int MaxSize { get; set; }

        public virtual ICollection<ScheduleVM> Schedules { get; set; }
    }
}