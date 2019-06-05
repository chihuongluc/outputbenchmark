using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface IRoleService
    {
    }

    public class RoleService : IRoleService
    {
        private IRoleRepository _roleRepository;
        private IUnitOfWork _unitOfWork;

        public RoleService(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
        {
            this._roleRepository = roleRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}