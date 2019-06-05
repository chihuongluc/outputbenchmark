using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IRoomService
    {
    }

    public class RoomService : IRoomService
    {
        private IRoomRepository _roomRepository;
        private IUnitOfWork _unitOfWork;

        public RoomService(IRoomRepository roomRepository, IUnitOfWork unitOfWork)
        {
            this._roomRepository = roomRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}