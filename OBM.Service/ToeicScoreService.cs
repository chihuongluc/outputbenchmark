using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IToeicScoreService
    {
    }

    public class ToeicScoreService : IToeicScoreService
    {
        private IToeicScoreRepository _toeicScoreRepository;
        private IUnitOfWork _unitOfWork;

        public ToeicScoreService(IToeicScoreRepository toeicScoreRepository, IUnitOfWork unitOfWork)
        {
            this._toeicScoreRepository = toeicScoreRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}