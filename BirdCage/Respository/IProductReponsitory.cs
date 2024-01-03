using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository
{
    public interface IProductReponsitory
    {
        List<Product> Getallpro();
        void AddProduct (Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        void AddproToCart(int accountID, int productId, int quantity);
        void CheckQuantiy();
    }

}
