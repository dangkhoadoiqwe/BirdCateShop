using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class TrainingSchedule
    {
        public int TrainingId { get; set; }
        public int? BirdId { get; set; }
        public int? AccountId { get; set; }
        public int? CouseraId { get; set; }
        public DateTime? TrainingDate { get; set; }
        public TimeSpan? TrainingTime { get; set; }

        public virtual Account Account { get; set; }
        public virtual Bird Bird { get; set; }
        public virtual Coursera Cousera { get; set; }
    }
}
