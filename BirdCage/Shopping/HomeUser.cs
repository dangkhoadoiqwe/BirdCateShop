using DataAccess;
using Model.Models;
using Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping
{
    
    public partial class HomeUser : Form
    {
        ProductReponsitory repo = new ProductReponsitory();
        public HomeUser()
        {
            InitializeComponent();
            LoadTop2Products();
        }
        private void LoadTop2Products()
        {
            try
            {
                // Gọi hàm lấy top 3 sản phẩm từ Database
                List<Product> top3Products = repo.Load2Product();

                // Kiểm tra xem có đủ 3 sản phẩm không
                if (top3Products.Count >= 2)
                {
                    // Hiển thị thông tin sản phẩm 1
                    txtPro1.Text = top3Products[0].ProductName;
                    txtprice1.Text = top3Products[0].Price.ToString();
                   
                    string img = top3Products[0].Image.ToString();
                    try
                    {
                        Bitmap bitmap = new Bitmap(img);
                        pictureBox2.Image = bitmap;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error loading image: " + ex.Message);
                    }
                    txtquantity1.Text = top3Products[0].Quantity.ToString();
                 
                    // Hiển thị thông tin sản phẩm 2
                    txtPro2.Text = top3Products[1].ProductName;
                    txtprice2.Text = top3Products[1].Price.ToString();
                  
                    string img2 = top3Products[1].Image.ToString();
                    try
                    {
                        Bitmap bitmap = new Bitmap(img2);
                        pictureBox3.Image = bitmap;
                        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error loading image: " + ex.Message);
                    }
                    txtquantity2.Text = top3Products[1].Quantity.ToString();
                   
                    // Hiển thị thông tin sản phẩm 3

                }
                else
                {
                    // Nếu không đủ 3 sản phẩm, xử lý tương ứng (có thể hiển thị thông báo)
                    MessageBox.Show("Không đủ sản phẩm để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
      

    }
}
