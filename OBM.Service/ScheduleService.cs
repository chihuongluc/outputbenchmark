using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IScheduleService
    {
    }

    public class ScheduleService : IScheduleService
    {
        private IScheduleRepository _scheduleRepository;
        private IUnitOfWork _unitOfWork;

        public ScheduleService(IScheduleRepository scheduleRepository, IUnitOfWork unitOfWork)
        {
            this._scheduleRepository = scheduleRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}