using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Feedback
    {
        public Feedback()
        {
            FeedbackReplies = new HashSet<FeedbackReply>();
        }

        public int FeedbackId { get; set; }
        public int? CartDetailId { get; set; }
        public DateTime CreateTime { get; set; }
        public int AccountId { get; set; }
        public int? Rating { get; set; }
        public int? FeedbackStatus { get; set; }
        public string Comment { get; set; }

        public virtual Account Account { get; set; }
        public virtual CartDetail CartDetail { get; set; }
        public virtual ICollection<FeedbackReply> FeedbackReplies { get; set; }
    }
}
