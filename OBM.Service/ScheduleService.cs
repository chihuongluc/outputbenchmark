using OBM.Data;
using OBM.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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

        public Schedule Add(Schedule entity)
        {
            return DataProvider.Ins.DB.Schedules.Add(entity);
        }

        public virtual void Update(Schedule entity)
        {
            DataProvider.Ins.DB.Schedules.Attach(entity);
            DataProvider.Ins.DB.Entry(entity).State = EntityState.Modified;
        }

        public virtual Schedule GetSingleById(string id)
        {
            return DataProvider.Ins.DB.Schedules.Find(id);
        }

        public virtual IEnumerable<Schedule> GetByFinalTestID(string id, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = DataProvider.Ins.DB.Schedules.Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.Where(p => p.FinalTestID.Equals(id)).AsQueryable();
            }
            return DataProvider.Ins.DB.Schedules.Where(p=>p.FinalTestID.Equals(id)).AsQueryable();
        }
    }
}