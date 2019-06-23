using OBM.Data;
using OBM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBM.Service
{
    public class FinalTestService
    {
        private static FinalTestService _ins;

        public static FinalTestService Ins
        {
            get { if (_ins == null) _ins = new FinalTestService(); return _ins; }
            private set => _ins = value;
        }

        private FinalTestService()
        {
        }

        public FinalTest Add(FinalTest entity)
        {
            return DataProvider.Ins.DB.FinalTests.Add(entity);
        }

        public List<FinalTest> GetAll()
        {
            return DataProvider.Ins.DB.FinalTests.ToList();
        }

        public FinalTest GetSingleByID(string id)
        {
            return DataProvider.Ins.DB.FinalTests.Find(id);
        }

        public int GetTimesByYear(int year)
        {
            return DataProvider.Ins.DB.FinalTests.Where(p => p.StartDate.Year == year).Count();
        }

        public bool GetStatus(out string startDate)
        {
            startDate = null;
            var result = DataProvider.Ins.DB.FinalTests.Where(p => p.Done == false);
            if(result.Count() > 0)
            {
                startDate = result.FirstOrDefault().StartDate.ToString("dd/MM/yyyy");
                return true;
            }
            return false;
        }
    }
}
