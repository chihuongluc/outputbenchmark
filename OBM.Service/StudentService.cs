using OBM.Data;
using OBM.Data.Infrastructure;
using OBM.Data.Models;
using OBM.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace OBM.Service
{
    //public interface IStudentService
    //{
    //}

    public class StudentService:StudentRepository
    {
        //private IStudentRepository _studentRepository;
        //private IUnitOfWork _unitOfWork;

        //public StudentService(IStudentRepository studentRepository, IUnitOfWork unitOfWork)
        //{
        //    this._studentRepository = studentRepository;
        //    this._unitOfWork = unitOfWork;
        //}
        //private static StudentService _ins;

        //public static StudentService Ins
        //{
        //    get { if (_ins == null) _ins = new StudentService(); return _ins; }
        //    private set => _ins = value;
        //}

        //private StudentService() { }

        //public IEnumerable<Student> GetStudentList()
        //{
        //    return StudentRepository.Ins.GetStudentList();
        //}
    }
}