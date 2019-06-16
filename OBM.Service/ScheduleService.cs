using OBM.Data;
using OBM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBM.Service
{
    public class ScheduleService
    {
        private static ScheduleService _ins;

        public static ScheduleService Ins
        {
            get { if (_ins == null) _ins = new ScheduleService(); return _ins; }
            private set => _ins = value;
        }

        private ScheduleService()
        {
        }

        public List<Schedule> GetByFinalTestID(string id)
        {
            return DataProvider.Ins.DB.Schedules.Where(p => p.FinalTestID.Equals(id)).ToList();
        }
    }
}
