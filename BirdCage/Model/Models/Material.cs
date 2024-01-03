using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Material
    {
        public Material()
        {
            BookingRequests = new HashSet<BookingRequest>();
        }

        public int MaterialId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual ICollection<BookingRequest> BookingRequests { get; set; }
    }
}
