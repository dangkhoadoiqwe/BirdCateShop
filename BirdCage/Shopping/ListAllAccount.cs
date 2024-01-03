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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shopping
{
    public partial class ListAllAccount : Form
    {
        AccountReponsitory repo = new AccountReponsitory();
        public ListAllAccount()
        {
            InitializeComponent();
            dataAllAccount.DataSource = repo.getall();
        }
        private void ViewAAcc(object sender, EventArgs e)
        {
            if (dataAllAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataAllAccount.SelectedRows[0];
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtAddress.Text = row.Cells[9].Value.ToString();
                txtEmail.Text = row.Cells[7].Value.ToString();
                txtPoint.Text = row.Cells[8].Value.ToString();
                txtID.Text = row.Cells[0].Value.ToString();
                int status;
                if (int.TryParse(row.Cells[6].Value.ToString(), out status))
                {
                    txtStatus.Text = (status == 0) ? "Block" : "Active";
                    if (status == 0)
                    {
                        btnBlock.Text = "Unblock";
                    }
                    else if (status == 1)
                    {
                        btnBlock.Text = "Block";
                    }
                }
                else
                {
                    Console.WriteLine("!");
                }
                txtID.Enabled = false;
                txtStatus.Enabled = false;
                string imagePath = row.Cells[3].Value.ToString();
                try
                {
                    Bitmap bitmap = new Bitmap(imagePath);
                    pictureBox1.Image = bitmap;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading image: " + ex.Message);
                }

            }
        }
        private void UpdateDataGridView()
        {
            // Lấy danh sách sản phẩm từ cơ sở dữ liệu
            List<Account> productList = AccountDao.LoadAllAccounts();

            // Gán danh sách sản phẩm cho DataSource của DataGridView
            dataAllAccount.DataSource = productList;

            // Cập nhật lại giao diện DataGridView
            dataAllAccount.Refresh();
        }
       

        private void BtnBlockAcc(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtID.Text, out int accountId))
                {
                    // Gọi hàm cập nhật trạng thái từ Database
                    AccountDao.BlockAcc(int.Parse(txtID.Text));

                    MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gọi hàm cập nhật DataGridView hoặc làm bất kỳ công việc cần thiết khác
                    UpdateDataGridView();
                }
                else
                {
                    MessageBox.Show("Account ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
