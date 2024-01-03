using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class UpdateProduct
    {
        public int UpdateId { get; set; }
        public DateTime TimeUpdate { get; set; }
        public int AccountId { get; set; }
        public int? ProductId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Product Product { get; set; }
    }
}
