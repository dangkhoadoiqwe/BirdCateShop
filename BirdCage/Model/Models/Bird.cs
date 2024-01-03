using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Bird
    {
        public Bird()
        {
            TrainingSchedules = new HashSet<TrainingSchedule>();
        }

        public int BirdId { get; set; }
        public string Species { get; set; }
        public string CommonName { get; set; }
        public int? Age { get; set; }
        public string Color { get; set; }
        public int? Point { get; set; }
        public string AvailabilityStatus { get; set; }
        public string TrainingStatus { get; set; }

        public virtual ICollection<TrainingSchedule> TrainingSchedules { get; set; }
    }
}
