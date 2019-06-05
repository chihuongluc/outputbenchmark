using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IRoleRepository : IRepository<Role>
    {
    }

    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        //public RoleRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}