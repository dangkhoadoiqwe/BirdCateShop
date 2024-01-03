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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BirdCage
{
    public partial class Login : Form
    {
        AccountReponsitory repo = new AccountReponsitory();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin(object sender, EventArgs e)
        {


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPass.Text;
            try
            {
                // Gọi phương thức Login từ DataAccess để kiểm tra tên đăng nhập và mật khẩu
                Account loggedInAccount = repo.Login(username, password);

                if (loggedInAccount != null)
                {
                    // Đăng nhập thành công, thực hiện các hành động sau khi đăng nhập
                    MessageBox.Show("Đăng nhập thành công!");
                    // Ví dụ: Mở form mới, hiển thị thông tin, v.v.
                    ListProduct listProductForm = new ListProduct();
                    listProductForm.ShowDialog();
                    this.Hide();
                }
                else
                {
                    // Đăng nhập không thành công, hiển thị thông báo
                    MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception tại đây (ghi log, thông báo, v.v.)
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}");
            }
        }
    }
}