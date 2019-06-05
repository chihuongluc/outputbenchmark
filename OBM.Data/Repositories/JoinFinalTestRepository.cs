using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IJoinFinalTestRepository : IRepository<JoinFinalTest>
    {
    }

    public class JoinFinalTestRepository : Repository<JoinFinalTest>, IJoinFinalTestRepository
    {
        //public JoinFinalTestRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}