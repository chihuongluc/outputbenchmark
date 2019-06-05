using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IToeicScoreRepository : IRepository<ToeicScore>
    {
    }

    public class ToeicScoreRepository : Repository<ToeicScore>, IToeicScoreRepository
    {
        //public ToeicScoreRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}