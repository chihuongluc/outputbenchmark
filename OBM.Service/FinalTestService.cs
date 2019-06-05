using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IFinalTestService
    {
    }

    public class FinalTestService : IFinalTestService
    {
        private IFinalTestRepository _finalTestRepository;
        private IUnitOfWork _unitOfWork;

        public FinalTestService(IFinalTestRepository finalTestRepository, IUnitOfWork unitOfWork)
        {
            this._finalTestRepository = finalTestRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}