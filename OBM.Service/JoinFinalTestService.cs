using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IJoinFinalTestService
    {
    }

    public class JoinFinalTestService : IJoinFinalTestService
    {
        private IJoinFinalTestRepository _joinFinalTestRepository;
        private IUnitOfWork _unitOfWork;

        public JoinFinalTestService(IJoinFinalTestRepository joinFinalTestRepository, IUnitOfWork unitOfWork)
        {
            this._joinFinalTestRepository = joinFinalTestRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}