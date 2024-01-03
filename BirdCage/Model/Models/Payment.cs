using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Payment
    {
        public Payment()
        {
            CartDetails = new HashSet<CartDetail>();
        }

        public int PaymentId { get; set; }
        public DateTime CreateTime { get; set; }
        public double FeeShip { get; set; }
        public int? VoucherId { get; set; }
        public double Total { get; set; }
        public int PaymentStatus { get; set; }
        public int DeliveryId { get; set; }
        public int? BookingId { get; set; }
        public string CusPhone { get; set; }
        public string CusAddress { get; set; }
        public string CusName { get; set; }
        public int? AccountId { get; set; }
        public string Note { get; set; }
        public int? VoucherPrice { get; set; }
        public int? Point { get; set; }
        public int? ProductsPrice { get; set; }

        public virtual BookingRequest Booking { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
