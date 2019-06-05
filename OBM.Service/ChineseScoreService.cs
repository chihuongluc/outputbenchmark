using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IChineseScoreService
    {
    }

    public class ChineseScoreService : IChineseScoreService
    {
        private IChineseScoreRepository _chineseScoreRepository;
        private IUnitOfWork _unitOfWork;

        public ChineseScoreService(IChineseScoreRepository chineseScoreRepository, IUnitOfWork unitOfWork)
        {
            this._chineseScoreRepository = chineseScoreRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}