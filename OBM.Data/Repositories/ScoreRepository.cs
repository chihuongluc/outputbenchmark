using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IScoreRepository : IRepository<Score>
    {
    }

    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        //public ScoreRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}