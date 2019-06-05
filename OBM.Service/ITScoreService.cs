using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IITScoreService
    {
    }

    public class ITScoreService : IITScoreService
    {
        private IITScoreRepository _iTScoreRepository;
        private IUnitOfWork _unitOfWork;

        public ITScoreService(IITScoreRepository iTScoreRepository, IUnitOfWork unitOfWork)
        {
            this._iTScoreRepository = iTScoreRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}