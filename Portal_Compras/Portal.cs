using System;
using System.Linq;
using System.Windows.Forms;

namespace Portal_Compras
{
    public partial class Portal : Form
    {
        private EntitiesBarEscola db = new EntitiesBarEscola();

        public Portal()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            cmb_categoryFilter.Items.Clear();
            foreach (TYPE category in db.TYPE)
            {
                if (category.DELETE_DATE == null)
                {
                    cmb_categoryFilter.Items.Add(category.NAME);
                }
            }
            foreach (Product product in db.Product)
            {
                if (db.TYPE.Where(t => t.ID == product.Type_Id).First().DELETE_DATE != null)
                {
                    int id = product.ID;
                    string name = product.Name;
                    decimal price = product.Price_Discount; // MAKE A NULL CHECK
                    db.ApplyDiscounts();
                }
            }
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Checkout checkout = new Checkout();
            checkout.ShowDialog();
            this.Visible = true;
        }

        private void txt_searchBar_Enter(object sender, EventArgs e)
        {
            if (txt_searchBar.Text == "Pesquise um produto")
            {
                txt_searchBar.Text = "";
            }
        }

        private void txt_searchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_searchBar.Text))
            {
                txt_searchBar.Text = "Pesquise um produto";
            }
        }
    }
}