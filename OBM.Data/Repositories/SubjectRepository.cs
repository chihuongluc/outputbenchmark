using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface ISubjectRepository : IRepository<Subject>
    {
    }

    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        //public SubjectRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}