using System;
using Xunit;
using Moq;
using TrainingMgmt.Repositories.Interfaces;
using TrainingMgmt.Repositories.Models;
using TrainingMgmt.Controllers;
using Microsoft.EntityFrameworkCore;

namespace TrainingMgmt.API.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void student_record_should_not_be_null()
        {
            Student s = new()
            {
                Name = "Ravi",
                PhoneNumber = "9999",
                City = "Hyderabad",
                Mail = "R@G.COM"
            };
            Mock<IStudentRepository> mockRepository = new Mock<IStudentRepository>();
            mockRepository.Setup(x => x.Add(s)).Returns
                (
                    new Student()
                    { 
                        Id = 1, 
                        City = s.City, 
                        Mail = s.Mail, 
                        Name = s.Name,
                        PhoneNumber = s.PhoneNumber
                    }
                );
            StudentController controller = new StudentController(mockRepository.Object);

            Student createdStudnet = controller.Create(s);
            Assert.NotNull(createdStudnet);
        }

        [Fact]
        public void student_record_should_return_Id()
        {
            Student s = new()
            {
                Name = "Ravi",
                PhoneNumber = "9999",
                City = "Hyderabad",
                Mail = "R@G.COM"
            };
            Mock<IStudentRepository> mockRepository = new Mock<IStudentRepository>();
            mockRepository.Setup(x => x.Add(s)).Returns
                (
                    new Student()
                    {
                        Id = 1,
                        City = s.City,
                        Mail = s.Mail,
                        Name = s.Name,
                        PhoneNumber = s.PhoneNumber
                    }
                );
            StudentController controller = new StudentController(mockRepository.Object);

            Student createdStudnet = controller.Create(s);
            Assert.True(createdStudnet.Id == 1, "Not received correct Id");
        }

        [Fact]
        public void student_record_should_be_same_as_input()
        {
            Student s = new()
            {
                Name = "Ravi",
                PhoneNumber = "9999",
                City = "Hyderabad",
                Mail = "R@G.COM"
            };
            Mock<IStudentRepository> mockRepository = new Mock<IStudentRepository>();
            mockRepository.Setup(x => x.Add(s)).Returns
                (
                    new Student()
                    {
                        Id = 1,
                        City = s.City,
                        Mail = s.Mail,
                        Name = s.Name,
                        PhoneNumber = s.PhoneNumber
                    }
                );
            StudentController controller = new StudentController(mockRepository.Object);

            Student createdStudnet = controller.Create(s);
            Assert.True(createdStudnet.Id > 0, "Id is in valid");
            Assert.True(createdStudnet.Name == s.Name, "Name is not correct");
            Assert.True(createdStudnet.City == s.City, "City is not correct");
            Assert.True(createdStudnet.PhoneNumber == s.PhoneNumber, "Phone is not correct");
            Assert.True(createdStudnet.Mail == s.Mail, "Email is not correct");
        }

        [Fact]
        public void should_throw_exception_when_name_is_null()
        {
            Student s = new()
            {
                Name = null,
                PhoneNumber = "9999",
                City = "Hyderabad",
                Mail = "R@G.COM"
            };
            Mock<IStudentRepository> mockRepository = new Mock<IStudentRepository>();
            mockRepository.Setup(x => x.Add(s)).Throws<Exception>();
                
            StudentController controller = new StudentController(mockRepository.Object);
            Assert.ThrowsAny<Exception>(() => controller.Create(s));
        }
    }
}
