using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IFinalTestRepository : IRepository<FinalTest>
    { }

    public class FinalTestRepository : Repository<FinalTest>, IFinalTestRepository
    {
        //public FinalTestRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}