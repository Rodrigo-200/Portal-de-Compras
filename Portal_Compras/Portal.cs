using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Portal_Compras
{
    public partial class Portal : Form
    {
        private EntitiesBarEscola EntitiesBarEscola = new EntitiesBarEscola();

        public Portal(int tabPage = 0)
        {
            InitializeComponent();
            LoadUserProfile();
            tc_Options.SelectedIndex = tabPage;
            RefreshData();
            lbl_totalBalance.Text = "Saldo Total: " + Generic.current_Logged_Client.BALANCE + "€";
            cbb_categoryFilter.SelectedItem = "Todos";
        }

        private void Portal_Load(object sender, EventArgs e)
        {
        }

        private void LoadUserProfile()
        {
            lbl_name.Text = "Name: " + Generic.current_Logged_Client.NAME;
            lbl_username.Text = "Username: " + Generic.current_Logged_Client.USERNAME;
            //lbl_NIF.Text = Generic.current_Logged_Client.NIF;
        }

        private void RefreshData()
        {
            cbb_categoryFilter.Items.Clear();
            cbb_categoryFilter.Items.Add("Todos");
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

        private void cbb_categoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProductsByCategory();
        }

        private void FilterProductsByCategory()
        {
            if (chk_showFavorites.Checked == false)
            {
                lvw_products.Items.Clear();
                foreach (Product item in EntitiesBarEscola.Product)
                {
                    if (cbb_categoryFilter.SelectedItem.ToString() == "Todos")
                    {
                        refreshListview();
                        break;
                    }

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
            else
            {
                lvw_products.Items.Clear();
                foreach (Favorite_Product item in Generic.current_Logged_Client.Favorite_Product)
                {
                    if (item.Product.TYPE.NAME == cbb_categoryFilter.SelectedItem.ToString())
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
                    else
                    {
                        if (cbb_categoryFilter.SelectedItem.ToString() == "Todos")
                        {
                            RefreshFavorites();
                            break;
                        }
                    }
                }
            }
        }

        private void lvw_products_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string selectedProductName = lvw_products.SelectedItems[0].Text;
                int id_product = EntitiesBarEscola.Product.Where(d => d.Name == selectedProductName).FirstOrDefault().ID;
                Favorite_Product favorite_Product = EntitiesBarEscola.Favorite_Product.Where(p => p.Id_Product == id_product && p.Id_Client == Generic.current_Logged_Client.ID).FirstOrDefault();

                if (favorite_Product == null)
                {
                    cms_LvwProducts.Items[0].Text = "Adicionar como Favorito";
                    cms_LvwProducts.Items[0].Image = Properties.Resources.heart;
                }
                else
                {
                    cms_LvwProducts.Items[0].Text = "Remover dos Favoritos";
                    cms_LvwProducts.Items[0].Image = Properties.Resources.heart__1_;
                }

                cms_LvwProducts.Show(Cursor.Position);
            }
        }

        private void adicionarComoFavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedProductName = lvw_products.SelectedItems[0].Text;
            int id_product = EntitiesBarEscola.Product.Where(d => d.Name == selectedProductName).FirstOrDefault().ID;
            Favorite_Product favorite_Product = EntitiesBarEscola.Favorite_Product.Where(p => p.Id_Product == id_product && p.Id_Client == Generic.current_Logged_Client.ID).FirstOrDefault();

            if (favorite_Product == null)
            {
                cms_LvwProducts.Items[0].Text = "Remover dos Favoritos";
                cms_LvwProducts.Items[0].Image = Properties.Resources.heart__1_;
                favorite_Product = new Favorite_Product
                {
                    Id_Product = id_product,
                    Id_Client = Generic.current_Logged_Client.ID
                };
                EntitiesBarEscola.Favorite_Product.Add(favorite_Product);
            }
            else
            {
                cms_LvwProducts.Items[0].Text = "Adicionar como Favorito";
                cms_LvwProducts.Items[0].Image = Properties.Resources.heart;
                EntitiesBarEscola.Favorite_Product.Remove(favorite_Product);
            }

            EntitiesBarEscola.SaveChanges();
        }

        private void chk_showFavorites_CheckedChanged(object sender, EventArgs e)
        {
            RefreshFavorites();
        }

        private void RefreshFavorites()
        {
            if (chk_showFavorites.Checked == true)
            {
                lvw_products.Items.Clear();
                var ListidFavorites = Generic.current_Logged_Client.Favorite_Product.Select(p => p.Id_Product).ToList();
                List<Product> teste = EntitiesBarEscola.Product.Where(s => ListidFavorites.Contains(s.ID)).ToList();

                foreach (Product item in teste)
                {
                    Product product = item;
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
                FilterProductsByCategory();
            }
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            if (EntitiesBarEscola.CART.Where(u => u.User_ID == Generic.current_Logged_Client.ID).FirstOrDefault() == null)
            {
                CART cart = new CART
                {
                    User_ID = Generic.current_Logged_Client.ID,
                    Created_Date = DateTime.Now
                };
                EntitiesBarEscola.CART.Add(cart);
                EntitiesBarEscola.SaveChanges();
            }
            if (lvw_products.SelectedItems.Count > 0)
            {
                string selectedProductName = lvw_products.SelectedItems[0].Text;
                int id_product = EntitiesBarEscola.Product.Where(d => d.Name == selectedProductName).FirstOrDefault().ID;
                Product product = EntitiesBarEscola.Product.Where(p => p.ID == id_product).FirstOrDefault();
                CART_ITEMS VerifycartItem = EntitiesBarEscola.CART_ITEMS.Where(i => i.Cart_ID == EntitiesBarEscola.CART.Where(u => u.User_ID == Generic.current_Logged_Client.ID).FirstOrDefault().Cart_ID && i.Product_ID == id_product).FirstOrDefault();

                if (VerifycartItem == null)
                {
                    CART_ITEMS cartItem = new CART_ITEMS
                    {
                        Product_ID = product.ID,
                        Cart_ID = EntitiesBarEscola.CART.Where(u => u.User_ID == Generic.current_Logged_Client.ID).FirstOrDefault().Cart_ID,
                        Quantity = Convert.ToInt32(nud_Quantity.Value)
                    };
                    EntitiesBarEscola.CART_ITEMS.Add(cartItem);
                    EntitiesBarEscola.SaveChanges();
                }
                else
                {
                    VerifycartItem.Quantity += Convert.ToInt32(nud_Quantity.Value);
                    EntitiesBarEscola.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para adicionar ao carrinho", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_depositMoney_Click(object sender, EventArgs e)
        {
            Generic.current_Logged_Client.BALANCE += Convert.ToDecimal(nud_depositMoney.Value);
            EntitiesBarEscola.CLIENT.Where(c => c.ID == Generic.current_Logged_Client.ID).FirstOrDefault().BALANCE = Generic.current_Logged_Client.BALANCE;
            EntitiesBarEscola.SaveChanges();
            lbl_totalBalance.Text = "Saldo Total: " + Generic.current_Logged_Client.BALANCE + "€";
        }
    }
}