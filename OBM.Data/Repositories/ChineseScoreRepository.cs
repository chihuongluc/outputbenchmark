using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IChineseScoreRepository : IRepository<ChineseScore>
    {
    }

    public class ChineseScoreRepository : Repository<ChineseScore>, IChineseScoreRepository
    {
        //public ChineseScoreRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}