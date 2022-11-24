using System;
using System.Collections.Generic;

#nullable disable

namespace TrainingMgmt.Repositories.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string City { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
