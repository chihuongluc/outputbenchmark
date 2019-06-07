using System.Collections.Generic;

namespace OBM.App.ViewModels
{
    public class RoomVM
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int MaxCapacity { get; set; }

        public bool Booked { get; set; }

        public virtual ICollection<ScheduleVM> Schedules { get; set; }
    }
}