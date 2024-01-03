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
    public partial class Login : Form
    {
        AccountReponsitory repo = new AccountReponsitory();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String pass = txtPass.Text;
                var account = repo.Login(name, pass);

                if (account != null)
                {
                    // Kiểm tra RoleID
                    if (account.Role == 1)
                    {
                        // Nếu là RoleID = 1 (Admin), mở form ListAllProduct
                        ListAllProduct listAllProduct = new ListAllProduct();
                        listAllProduct.AccountId = account.AccountId;
                        //listAllProduct.Show();
                        HomeUser homeUser = new HomeUser(); 
                        homeUser.Show();
                        this.Hide();
                    }
                    else if (account.Role == 2)
                    {
                        // Nếu là RoleID = 2 (User), mở form ListAllAccount
                        ListAllAccount listAllAccount = new ListAllAccount(); 
                        listAllAccount.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Xử lý cho các RoleID khác (nếu cần)
                        MessageBox.Show("Đăng nhập thành công, nhưng không có quyền truy cập.");
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra tên đăng nhập và mật khẩu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
