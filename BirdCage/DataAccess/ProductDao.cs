using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDao
    {
        public static void DeletPro(int ProductID)
        {
            try
            {
                using (var context = new BirdCage777Context())
                {
                    var exisit = context.Products.SingleOrDefault(p => p.ProductId == ProductID);
                    if (exisit != null)
                    {
                        context.Products.Remove(exisit);
                        context.SaveChanges();
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting product: " + ex.Message);
            }
        }
        public static void UpdatePro(Product product)
        {
            try
            {
                using (var context = new BirdCage777Context())
                {
                    var existing = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                    if (existing != null)
                    {
                        existing.ProductName = product.ProductName;
                        existing.Price = product.Price;
                        existing.Quantity = product.Quantity;
                        existing.Description = product.Description;
                        existing.Image = product.Image;
                        context.SaveChanges();
                    }
                }
            } 
            catch (Exception ex)
            {
                throw new Exception("Error updating product: " + ex.Message);
            }

        }
        public static void AddPro(Product product)
        {
            try
            {
                using (var context = new BirdCage777Context())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            catch(Exception ex) 
            {
                throw new Exception("Error adding product: " + ex.Message);
            }

        }
        public static void CheckQuantity()
        {
            try
            {
                using (var context =  new BirdCage777Context())
                {
                    var existing = context.Products.Where(p => p.Quantity == 0 ).ToList();
                    foreach (var product in existing)
                    {
                        product.ProductStatus = 0;
                    }
                    var contain = context.Products.Where(p => p.Quantity > 0 && p.ProductStatus == 0).ToList();
                    foreach (var product in contain)
                    {
                        product.ProductStatus = 1;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public static void AddproToCart(int accountID , int productId , int quantity)
        {
            try
            {
                using (var cotext = new BirdCage777Context())
                {
                    var cart = cotext.Carts.SingleOrDefault(c => c.AccountId == accountID);
                    if (cart == null)
                    {
                        cart = new Cart { AccountId = accountID };
                        cotext.Carts.Add(cart);
                        cotext.SaveChanges();
                    }
                    var carDetai = new CartDetail
                    {
                        CartId = cart.CartId,
                        ProductId = productId,
                        Quantity = quantity,
                        CartStatus = 0,

                    };
                    cotext.CartDetails.Add(carDetai);
                    cotext.SaveChanges();
                    var product = cotext.Products.SingleOrDefault(p => p.ProductId == productId);

                    if(product != null)
                    {
                        product.Quantity -= quantity;
                        cotext.SaveChanges();
                    }
                }
            }
            catch(Exception ex) { throw new Exception(ex.Message); }

        }
        public static List<Product> Load2Product()
        {
            List<Product> list = new List<Product>();
            try
            {
                using(var context =  new BirdCage777Context())
                {
                    var get2pro = context.Products.OrderByDescending(pro => pro.ProductId).ToList();
                    list = get2pro.Take(2).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return list;
        }
        public static  List<Product> GetallProduct()
        {
            List<Product> list = new List<Product>();
            try
            {
                using (var context = new BirdCage777Context())
                {
                    list = context.Products.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;


        }
    }
}
