using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Delivery
    {
        public Delivery()
        {
            Payments = new HashSet<Payment>();
        }

        public int DeliveryId { get; set; }
        public int Status { get; set; }
        public DateTime IntendTime { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
