using System;
using System.Collections.Generic;

#nullable disable

namespace TrainingMgmt.Repositories.Models
{
    public partial class Course
    {
        public Course()
        {
            FacultyCourses = new HashSet<FacultyCourse>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<FacultyCourse> FacultyCourses { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
