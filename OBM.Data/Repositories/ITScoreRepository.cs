using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IITScoreRepository : IRepository<ITScore>
    {
    }

    public class ITScoreRepository : Repository<ITScore>, IITScoreRepository
    {
        //public ITScoreRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}