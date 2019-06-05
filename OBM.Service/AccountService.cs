using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IAccountService
    {
    }

    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;
        private IUnitOfWork _unitOfWork;

        public AccountService(IAccountRepository accountRepository, IUnitOfWork unitOfWork)
        {
            this._accountRepository = accountRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}