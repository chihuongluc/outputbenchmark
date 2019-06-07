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

        public List<FinalTest> GetAll()
        {
            return DataProvider.Ins.DB.FinalTests.ToList();
        }

        public FinalTest GetSingleByID(string id)
        {
            return DataProvider.Ins.DB.FinalTests.Find(id);
        }
    }
}
