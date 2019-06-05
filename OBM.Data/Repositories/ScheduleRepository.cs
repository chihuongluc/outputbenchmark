using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
    }

    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        //public ScheduleRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}