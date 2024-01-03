using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Product
    {
        public Product()
        {
            CartDetails = new HashSet<CartDetail>();
            UpdateProducts = new HashSet<UpdateProduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoriesId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public DateTime CreateTime { get; set; }
        public string Image { get; set; }
        public int ProductStatus { get; set; }
        public string Manufacturer { get; set; }
        public string MadeIn { get; set; }
        public string Description { get; set; }

        public virtual Category Categories { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
        public virtual ICollection<UpdateProduct> UpdateProducts { get; set; }
    }
}
