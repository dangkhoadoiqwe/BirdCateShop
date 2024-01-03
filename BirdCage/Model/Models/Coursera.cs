using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Coursera
    {
        public Coursera()
        {
            TrainingSchedules = new HashSet<TrainingSchedule>();
        }

        public int CourseraId { get; set; }
        public string Title { get; set; }
        public string Describe { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public string Coserastatus { get; set; }
        public string Img { get; set; }
        public double? Price { get; set; }
        public int? Slot { get; set; }

        public virtual ICollection<TrainingSchedule> TrainingSchedules { get; set; }
    }
}
