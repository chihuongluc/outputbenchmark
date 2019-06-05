using OBM.Data.Infrastructure;
using OBM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OBM.Data.Repositories
{
    //public interface IStudentRepository : IRepository<Student>
    //{
    //}

    public class StudentRepository : Repository<Student>
    {
        //public StudentRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
        //private static StudentRepository _ins;

        //public static StudentRepository Ins
        //{
        //    get { if (_ins == null) _ins = new StudentRepository(); return _ins; }
        //    private set => _ins = value;
        //}

        //private StudentRepository() { }

        //public IEnumerable<Student> GetStudentList()
        //{
        //        return DataProvider.Ins.DB.Students.ToList();
        //}
        
    }
}
