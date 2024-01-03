using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class BookingRequest
    {
        public BookingRequest()
        {
            Payments = new HashSet<Payment>();
        }

        public int BookingId { get; set; }
        public int AccountId { get; set; }
        public string BirdType { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int MaterialId { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public string Subtotal { get; set; }
        public double Total { get; set; }
        public DateTime CreateTime { get; set; }
        public string Note { get; set; }
        public string CusAddress { get; set; }
        public string CusPhone { get; set; }
        public string MaterialCustom { get; set; }

        public virtual Account Account { get; set; }
        public virtual Material Material { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
