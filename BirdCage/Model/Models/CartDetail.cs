using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class CartDetail
    {
        public CartDetail()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int? CartStatus { get; set; }
        public int CartDetailId { get; set; }
        public int? PaymentId { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
