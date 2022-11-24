using System;
using System.Collections.Generic;

#nullable disable

namespace TrainingMgmt.Repositories.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            FacultyCourses = new HashSet<FacultyCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string City { get; set; }

        public virtual ICollection<FacultyCourse> FacultyCourses { get; set; }
    }
}
