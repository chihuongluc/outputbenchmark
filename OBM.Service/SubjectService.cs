using OBM.Data.Infrastructure;
using OBM.Data.Repositories;

namespace OBM.Service
{
    public interface ISubjectService
    {
    }

    public class SubjectService : ISubjectService
    {
        private ISubjectRepository _subjectRepository;
        private IUnitOfWork _unitOfWork;

        public SubjectService(ISubjectRepository subjectRepository, IUnitOfWork unitOfWork)
        {
            this._subjectRepository = subjectRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}