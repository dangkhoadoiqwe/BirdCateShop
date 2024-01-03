using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartDetails = new HashSet<CartDetail>();
        }

        public int CartId { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
