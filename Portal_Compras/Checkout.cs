using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_Compras
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            // Simulate loading cart items into the DataGridView
            var dt = new DataTable();
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Price");

            // Add sample data
            dt.Rows.Add("Product 1", 2, "20€");
            dt.Rows.Add("Product 2", 1, "10€");
            dt.Rows.Add("Product 3", 5, "50€");

            dataGridView1.DataSource = dt;
        }

        private void btn_finalizeBuy_Click(object sender, EventArgs e)
        {
            // Simulate purchase process
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                // Simulate some work being done
                System.Threading.Thread.Sleep(10);
                progressBar1.Value = i;
            }

            MessageBox.Show("Purchase completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_removeProducts_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    int removeQuantity = (int)nud_quantityRemoveProducts.Value;

                    if (removeQuantity >= currentQuantity)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    else
                    {
                        row.Cells["Quantity"].Value = currentQuantity - removeQuantity;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
