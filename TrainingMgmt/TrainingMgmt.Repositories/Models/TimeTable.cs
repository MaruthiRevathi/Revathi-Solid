using System;
using System.Collections.Generic;

#nullable disable

namespace TrainingMgmt.Repositories.Models
{
    public partial class TimeTable
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public virtual Course Course { get; set; }
    }
}
