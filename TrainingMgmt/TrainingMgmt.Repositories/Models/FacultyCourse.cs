using System;
using System.Collections.Generic;

#nullable disable

namespace TrainingMgmt.Repositories.Models
{
    public partial class FacultyCourse
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
