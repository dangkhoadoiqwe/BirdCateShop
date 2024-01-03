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

namespace BirdCage
{
    public partial class ListProduct : Form
    {
        ProductReponsitory repo = new ProductReponsitory();
        public ListProduct()
        {
            InitializeComponent();
            dataGridViewProduct.DataSource = repo.Getallpro();
        }

        private void ViewAStudent(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewProduct.SelectedRows[0];
                txtNamePro.Text = row.Cells[0].Value.ToString();
                txtPrice.Text = row.Cells[1].Value.ToString();
                txtquantity.Text = row.Cells[2].Value.ToString();
                
            }
        }
        private void BtnLoadingPro(object sender, EventArgs e)
        {
            try
            {
                List<Product> product = repo.Getallpro();

                // Bind the accounts to the DataGridView
                dataGridViewProduct.DataSource = product;
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, show error message, etc.)
                MessageBox.Show($"Error loading accounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddpro(object sender, EventArgs e)
        {

        }
    }
}
