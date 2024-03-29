﻿using OBM.Data;
using OBM.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OBM.Service
{
    public class StudentService
    {
        private static StudentService _ins;

        public static StudentService Ins
        {
            get { if (_ins == null) _ins = new StudentService(); return _ins; }
            private set => _ins = value;
        }

        private StudentService()
        {
        }

        public virtual Student Add(Student entity)
        {
            return DataProvider.Ins.DB.Students.Add(entity);
        }

        public List<Student> GetAll()
        {
            return DataProvider.Ins.DB.Students.ToList();
        }

        public Student GetSingleByID(string id)
        {
            return DataProvider.Ins.DB.Students.Find(id);
        }
    }
}