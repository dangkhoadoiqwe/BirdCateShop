using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Model.Models;

namespace DataAccess
{
    public class CartDao
    {
        public static int GetProductCountInCart(int accountId)
        {
            try
            {
                using (var context = new BirdCage777Context())
                {
                    // Lấy cardId từ bảng Cart dựa trên accountId
                    int? cardId = context.Carts
                        .Where(c => c.AccountId == accountId)
                        .Select(c => c.CartId)
                        .SingleOrDefault();

                    if (cardId.HasValue)
                    {
                        // Nếu có cardId, đếm số sản phẩm trong bảng CartDetail dựa trên cardId
                        int productCount = context.CartDetails
                            .Count(cd => cd.CartId == cardId.Value);

                        return productCount;
                    }

                    // Nếu không có cardId, trả về 0 vì không có sản phẩm trong giỏ hàng
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error counting products in cart: " + ex.Message);
            }
        }
    }
}
