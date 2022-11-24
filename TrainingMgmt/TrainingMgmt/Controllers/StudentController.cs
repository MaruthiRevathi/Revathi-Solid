using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TrainingMgmt.Repositories.Models;
using TrainingMgmt.Repositories.Interfaces;

namespace TrainingMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpPost]
        [Route("Create")]
        public Student Create(Student student)
        {
            return studentRepository.Add(student);
        }

        [HttpGet]
        [Route("GetList")]
        public List<Student> GetList()
        {
            return studentRepository.GetList();
        }

        [HttpGet]
        [Route("GetById")]
        public Student GetById(int id)
        {
            return studentRepository.GetById(id);
        }

        [HttpPost]
        [Route("Update")]
        public Student Update(Student student)
        {
            return studentRepository.Update(student);
        }

        [HttpDelete]
        [Route("Update")]
        public bool Update(int id)
        {
            return studentRepository.Delete(id);
        }
    }
}
