using OBM.Data.Infrastructure;
using OBM.Data.Models;

namespace OBM.Data.Repositories
{
    public interface IRoomRepository : IRepository<Room>
    {
    }

    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        //public RoomRepository(IDbFactory dbFactory) : base(dbFactory)
        //{
        //}
    }
}