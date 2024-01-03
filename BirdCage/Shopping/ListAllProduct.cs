using DataAccess;
using Microsoft.Identity.Client;
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
using System.Xml.Linq;

namespace Shopping
{
    public partial class ListAllProduct : Form
    {
        public int AccountId { get; set; }

        ProductReponsitory repo = new ProductReponsitory();
        public ListAllProduct()
        {
            InitializeComponent();
            
            repo.CheckQuantiy();
             
            dataAllProduct.DataSource = repo.Getallpro();
        }

        private void ViewAPro(object sender, EventArgs e)
        {
            int productCount = CartDao.GetProductCountInCart(AccountId);
            txtCountProduct.Text = productCount.ToString();
            txtCountProduct.Enabled = false;
            if (dataAllProduct.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dataAllProduct.SelectedRows[0];
                txtIdPRO.Text = row.Cells[0].Value.ToString();
                txtNamepro.Text = row.Cells[1].Value.ToString();
                txtPricePro.Text = row.Cells[4].Value.ToString();
                txtQuantiy.Text = row.Cells[3].Value.ToString();
                txtDepro.Text = row.Cells[13].Value.ToString();
                txtTime.Text = row.Cells[8].Value.ToString();
                txtImagePath.Text = row.Cells[9].Value.ToString();
                int status;
                if (int.TryParse(row.Cells[10].Value.ToString(), out status))
                {
                    txtStatus.Text = (status == 0) ? "Hết hàng " : "Còn hàng";
                }
                else
                {
                    Console.WriteLine("Invalid integer value in Cell 10");
                }

                txtIdPRO.Enabled = false;
                txtStatus.Enabled = false;

                // Lấy đường dẫn của hình ảnh từ cột trong DataGridView (đổi chỉ số tùy thuộc vào cấu trúc của dữ liệu)
                string imagePath = row.Cells[9].Value.ToString();

                try
                {
                    // Sử dụng Bitmap để đọc hình ảnh từ đường dẫn
                    Bitmap bitmap = new Bitmap(imagePath);

                    // Gán hình ảnh cho PictureBox
                    pictureBox1.Image = bitmap;

                    // Đặt SizeMode của PictureBox để hình ảnh vừa với khung hình
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    Console.WriteLine("Error loading image: " + ex.Message);
                }
            }
        }


        private void dataAllProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddPro_click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại mở tệp để chọn hình ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tệp được chọn
                string imagePath = openFileDialog.FileName;

                // Hiển thị hình ảnh trong PictureBox (pictureBox1 là tên PictureBox của bạn)
                pictureBox1.ImageLocation = imagePath;

                // Lưu đường dẫn hình ảnh vào biến hoặc TextBox để sử dụng sau này
                txtImagePath.Text = imagePath;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string productName = txtNamepro.Text;
            int productPrice = int.Parse(txtPricePro.Text);
            int productQuantity = int.Parse(txtQuantiy.Text);
            string productDescription = txtDepro.Text;
            string imagePath = txtImagePath.Text;

            // Tạo đối tượng Product từ dữ liệu nhập vào
            Product newProduct = new Product
            {

                ProductName = productName,
                Price = productPrice,
                Quantity = productQuantity,
                Description = productDescription,
                Image = imagePath,
                CategoriesId = 1,
                CreateTime = DateTime.Now,
                ProductStatus = 1,
            };

            // Thêm sản phẩm vào cơ sở dữ liệu
            ProductDao.AddPro(newProduct);

            // Gọi hàm cập nhật DataGridView hoặc làm bất kỳ công việc cần thiết khác
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            // Lấy danh sách sản phẩm từ cơ sở dữ liệu
            List<Product> productList = ProductDao.GetallProduct();

            // Gán danh sách sản phẩm cho DataSource của DataGridView
            dataAllProduct.DataSource = productList;

            // Cập nhật lại giao diện DataGridView
            dataAllProduct.Refresh();
        }

        private void txtQuantiy_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void btnUpdate_click(object sender, EventArgs e)
        {
            Product updatepro = new Product
            {
                ProductId = int.Parse(txtIdPRO.Text),
                ProductName = txtNamepro.Text,
                Price = int.Parse(txtPricePro.Text),
                Quantity = int.Parse(txtQuantiy.Text),
                Description = txtDepro.Text,
                Image = txtImagePath.Text,
                CategoriesId = 1,
                CreateTime = DateTime.Now,

            };
            repo.UpdateProduct(updatepro);
            repo.CheckQuantiy();
            UpdateDataGridView();
        }

        private void btnDeletPro(object sender, EventArgs e)
        {
            if (dataAllProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataAllProduct.SelectedRows[0];
                int productId = int.Parse(row.Cells[0].Value.ToString());

                // Gọi hàm xóa sản phẩm từ ProductDao
                ProductDao.DeletPro(productId);

                // Gọi hàm cập nhật DataGridView hoặc làm bất kỳ công việc cần thiết khác
                UpdateDataGridView();
            }
        }

        private void btnAddTOCart(object sender, EventArgs e)
        {
            try
            {
                ProductDao.AddproToCart(AccountId, int.Parse(txtIdPRO.Text), int.Parse(txtQuantiy.Text));

                MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                repo.CheckQuantiy();
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
