using OBM.Data;
using OBM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBM.Service
{
    public class SubjectService
    {
        private static SubjectService _ins;

        public static SubjectService Ins
        {
            get { if (_ins == null) _ins = new SubjectService(); return _ins; }
            private set => _ins = value;
        }

        private SubjectService()
        {
        }

        public List<Subject> GetAll()
        {
            return DataProvider.Ins.DB.Subjects.ToList();
        }
    }
}
