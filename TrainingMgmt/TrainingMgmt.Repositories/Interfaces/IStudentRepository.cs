using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingMgmt.Repositories.Models;

namespace TrainingMgmt.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Student Add(Student student);
        List<Student> GetList();
        Student GetById(int id);
        Student Update(Student student);
        bool Delete(int id);
    }
}
