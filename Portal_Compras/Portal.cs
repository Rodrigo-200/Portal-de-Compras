using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Portal_Compras
{
    public partial class Portal : Form
    {
        EntitiesBarEscola EntitiesBarEscola = new EntitiesBarEscola();

        public Portal()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            cbb_categoryFilter.Items.Clear();
            foreach (TYPE category in EntitiesBarEscola.TYPE)
            {
                if (category.DELETE_DATE == null)
                {
                    cbb_categoryFilter.Items.Add(category.NAME);
                }
            }

            EntitiesBarEscola.ApplyDiscounts();
            refreshListview();


        }

        private void refreshListview()
        {
            lvw_products.Items.Clear();
            foreach (Product product in EntitiesBarEscola.Product)
            {
                lvw_products.Items.Clear();
                foreach (Product item in EntitiesBarEscola.Product)
                {
                    ListViewItem Product = new ListViewItem();
                    Product.Text = item.Name;
                    Product.Tag = Product.Text;

                    ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                    Price.Text = item.Price_Discount == null ? item.Price.ToString() + "€" : item.Price_Discount.ToString() + "€";
                    Price.Tag = Price.Text;

                    ListViewItem.ListViewSubItem DiscountPercentage = new ListViewItem.ListViewSubItem();
                    DiscountPercentage.Text = item.Price_Discount == null ? "" : item.Discount.Where(p => p.PRODUCT_ID == item.ID).FirstOrDefault().PERCENTAGE.ToString() + "%";

                    ListViewItem.ListViewSubItem Type_Name = new ListViewItem.ListViewSubItem();
                    Type_Name.Text = item.TYPE.NAME;
                    Type_Name.Tag = Type_Name.Text;

                    Product.SubItems.Add(Price);
                    Product.SubItems.Add(DiscountPercentage);
                    Product.SubItems.Add(Type_Name);

                    lvw_products.Items.Add(Product);
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

        private void txt_searchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_searchBar.Text;

            if (txt_searchBar.Text == "Procure pelo nome do produto")
            {
                searchText = "";
            }

            else
            {
                searchText = txt_searchBar.Text;
            }


            // Call the stored procedure using BarEscolaEntities
            List<GetFilteredProducts_Result> filteredProducts = EntitiesBarEscola.GetFilteredProducts(searchText, false).ToList();

            // Limpar e atualizar a listview
            refreshFilteredListview(filteredProducts);
        }

        private void refreshFilteredListview(List<GetFilteredProducts_Result> filteredProducts)
        {
            lvw_products.Items.Clear();
            foreach (GetFilteredProducts_Result item in filteredProducts)
            {
                ListViewItem Product = new ListViewItem();
                Product.Text = item.Name;
                Product.Tag = Product.Text;

                ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                Price.Text = item.Price_Discount == null ? item.Price.ToString() + "€" : item.Price_Discount.ToString() + "€";
                Price.Tag = Price.Text;

                ListViewItem.ListViewSubItem DiscountPercentage = new ListViewItem.ListViewSubItem();
                DiscountPercentage.Text = item.Price_Discount == null ? "" : item.PERCENTAGE + "%";

                ListViewItem.ListViewSubItem Type_Name = new ListViewItem.ListViewSubItem();
                Type_Name.Text = item.TypeName;
                Type_Name.Tag = Type_Name.Text;

                Product.SubItems.Add(Price);
                Product.SubItems.Add(DiscountPercentage);
                Product.SubItems.Add(Type_Name);

                lvw_products.Items.Add(Product);
            }
        }

        private void Portal_Load(object sender, EventArgs e)
        {
        }

        private void cbb_categoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvw_products.Items.Clear();
            foreach (Product item in EntitiesBarEscola.Product)
            {
                if (item.TYPE.NAME == cbb_categoryFilter.SelectedItem.ToString())
                {
                    ListViewItem Product = new ListViewItem();
                    Product.Text = item.Name;
                    Product.Tag = Product.Text;

                    ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                    Price.Text = item.Price_Discount == null ? item.Price.ToString() + "€" : item.Price_Discount.ToString() + "€";
                    Price.Tag = Price.Text;

                    ListViewItem.ListViewSubItem DiscountPercentage = new ListViewItem.ListViewSubItem();
                    DiscountPercentage.Text = item.Price_Discount == null ? "" : item.Discount.Where(p => p.PRODUCT_ID == item.ID).FirstOrDefault().PERCENTAGE.ToString() + "%";

                    ListViewItem.ListViewSubItem Type_Name = new ListViewItem.ListViewSubItem();
                    Type_Name.Text = item.TYPE.NAME;
                    Type_Name.Tag = Type_Name.Text;

                    Product.SubItems.Add(Price);
                    Product.SubItems.Add(DiscountPercentage);
                    Product.SubItems.Add(Type_Name);

                    lvw_products.Items.Add(Product);
                }
            }
        }

        private void lvw_products_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms_LvwProducts.Show(Cursor.Position);
            }
        }

        private void adicionarComoFavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedProductName = lvw_products.SelectedItems[0].Text;
            //ACABAR TA MAL FEITO É PRECISO VERIFICAR SE O PRODUTO JA ESTA NOS FAVORITOS OU NAO E DEPOIS ADICIONAR OU REMOVER NAO CONFIRMAR PELO TEXTO DO MENU
            if (adicionarComoFavToolStripMenuItem.Text == "Adicionar como Favorito")
            {
                cms_LvwProducts.Items[0].Text = "Remover dos Favoritos";
                cms_LvwProducts.Items[0].Image = Properties.Resources.heart__1_;
                Favorite_Product favorite_Product = new Favorite_Product();
                int id_product = EntitiesBarEscola.Product.Where(d => d.Name == selectedProductName).FirstOrDefault().ID;
                favorite_Product.Id_Product = id_product;
                favorite_Product.Id_Client = Generic.current_Logged_Client.ID;
                EntitiesBarEscola.Favorite_Product.Add(favorite_Product);
                EntitiesBarEscola.SaveChanges();

            }
            else
            {
                cms_LvwProducts.Items[0].Text = "Adicionar como Favorito";
                cms_LvwProducts.Items[0].Image = Properties.Resources.heart;
                int id_product = EntitiesBarEscola.Product.Where(d => d.Name == selectedProductName).FirstOrDefault().ID;
                Favorite_Product favorite_Product = EntitiesBarEscola.Favorite_Product.Where(p => p.Id_Product == id_product).FirstOrDefault();
                EntitiesBarEscola.Favorite_Product.Remove(favorite_Product);
                EntitiesBarEscola.SaveChanges();
            }
        }

        private void chk_showFavorites_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_showFavorites.Checked == true)
            {
                lvw_products.Items.Clear();
                foreach (Favorite_Product item in Generic.current_Logged_Client.Favorite_Product)
                {
                    Product product = EntitiesBarEscola.Product.Where(p => p.ID == item.Id_Product).FirstOrDefault();
                    ListViewItem ProductName = new ListViewItem();
                    ProductName.Text = product.Name;
                    ProductName.Tag = ProductName.Text;

                    ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                    Price.Text = product.Price_Discount == null ? product.Price.ToString() + "€" : product.Price_Discount.ToString() + "€";
                    Price.Tag = Price.Text;

                    ListViewItem.ListViewSubItem DiscountPercentage = new ListViewItem.ListViewSubItem();
                    DiscountPercentage.Text = product.Price_Discount == null ? "" : product.Discount.Where(p => p.PRODUCT_ID == product.ID).FirstOrDefault().PERCENTAGE.ToString() + "%";

                    ListViewItem.ListViewSubItem Type_Name = new ListViewItem.ListViewSubItem();
                    Type_Name.Text = product.TYPE.NAME;
                    Type_Name.Tag = Type_Name.Text;

                    ProductName.SubItems.Add(Price);
                    ProductName.SubItems.Add(DiscountPercentage);
                    ProductName.SubItems.Add(Type_Name);

                    lvw_products.Items.Add(ProductName);
                }
            }
            else
            {
                refreshListview();
            }
            
        }
    }
}