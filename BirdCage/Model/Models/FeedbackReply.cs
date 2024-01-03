using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class FeedbackReply
    {
        public int ReplyId { get; set; }
        public int? FeedbackId { get; set; }
        public string Commentreply { get; set; }

        public virtual Feedback Feedback { get; set; }
    }
}
