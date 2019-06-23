using OBM.Data;
using OBM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBM.Service
{
    public class RegisterService
    {
        private static RegisterService _ins;

        public static RegisterService Ins
        {
            get { if (_ins == null) _ins = new RegisterService(); return _ins; }
            private set => _ins = value;
        }

        private RegisterService()
        {
        }

        public virtual Register Add(Register entity)
        {
            return DataProvider.Ins.DB.Registers.Add(entity);
        }

        public virtual IEnumerable<Register> GetMulti(string scheduleID = null, string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = DataProvider.Ins.DB.Registers.Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.Where(p => p.ScheduleID.Equals(scheduleID)).AsQueryable();
            }

            return DataProvider.Ins.DB.Registers.Where(p=>p.ScheduleID.Equals(scheduleID)).AsQueryable();
        }
    }
}
