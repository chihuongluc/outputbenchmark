using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
    }

    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        //public AccountRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}