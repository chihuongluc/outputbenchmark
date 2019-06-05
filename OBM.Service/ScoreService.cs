using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IScoreService
    {
    }

    public class ScoreService : IScoreService
    {
        private IScoreRepository _scoreRepository;
        private IUnitOfWork _unitOfWork;

        public ScoreService(IScoreRepository scoreRepository, IUnitOfWork unitOfWork)
        {
            this._scoreRepository = scoreRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}