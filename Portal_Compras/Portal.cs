using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_Compras
{
    public partial class Portal : Form
    {
        CancelarCompra cancelarCompra = new CancelarCompra();

        EntitiesBarEscola EntitiesBarEscola = new EntitiesBarEscola();


        public Portal(int tabPage = 0)
        {
            InitializeComponent();
            tc_Options.SelectedIndex = tabPage;
            RefreshAndFetchData();
            cbb_categoryFilter.SelectedItem = "Todos";

            checkCartItemsStock();
        }

        private void checkCartItemsStock()
        {
            if (Generic.current_Logged_Client != null)
            {
                string aux = "Os seguintes produtos do seu carrinho estão fora de stock:\n";
                int Qtd = 0;
                List<CART_ITEMS> CartItems = EntitiesBarEscola.CART_ITEMS.Where(i => i.Cart_ID == EntitiesBarEscola.CART.FirstOrDefault(u => u.User_ID == Generic.current_Logged_Client.ID).Cart_ID).ToList();
                foreach (var item in CartItems)
                {
                    if (item.Product.Stock < item.Quantity)
                    {
                        Qtd++;
                        aux += item.Product.Name + "\n";
                    }
                }
                if (Qtd > 0)
                {
                    MessageBox.Show(aux, "Produtos fora de stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RefreshAndFetchData()
        {
            EntitiesBarEscola = new EntitiesBarEscola();
            EntitiesBarEscola.ApplyDiscounts();
            RefreshData();
            RefreshListView();
            Refresh_History();
            LoadUserProfile();

            cbb_categoryFilter.SelectedItem = "Todos";
        }

        private void Portal_Load(object sender, EventArgs e)
        {
            tsb_Cancel_Buy.Enabled = true;
            decimal Balance = Convert.ToDecimal(Generic.current_Logged_Client.BALANCE);
            lbl_totalBalance.Text = "Saldo Total: " + Math.Round(Balance, 2) + "€";
        }

        private void LoadUserProfile()
        {
            EntitiesBarEscola = new EntitiesBarEscola();

            Generic.current_Logged_Client = EntitiesBarEscola.CLIENT.Where(p => p.ID == Generic.current_Logged_Client.ID).FirstOrDefault();

            if (Generic.current_Logged_Client != null)
            {
                lbl_name.Text = "Name: " + Generic.current_Logged_Client.NAME;
                lbl_username.Text = "Username: " + Generic.current_Logged_Client.USERNAME;
                decimal Balance = Convert.ToDecimal(Generic.current_Logged_Client.BALANCE);
                lbl_totalBalance.Text = "Saldo Total: " + Math.Round(Balance, 2) + "€";
                lbl_NIF.Text = "NIF: " + Generic.current_Logged_Client.NIF;
            }
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
            RefreshListView();
        }

        private void RefreshListView()
        {
            lvw_products.Items.Clear();
            foreach (Product item in EntitiesBarEscola.Product)
            {
                if (item.Is_Deleted != true)
                {
                    ListViewItem Product = new ListViewItem();
                    Product.Text = item.Name;
                    Product.Tag = Product.Text;

                    ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                    Price.Text = item.Price_Discount == null ? Math.Round(item.Price, 2).ToString() + "€" : Math.Round(Convert.ToDouble(item.Price_Discount), 2).ToString() + "€";
                    Price.Tag = Price.Text;

                    ListViewItem.ListViewSubItem DiscountPercentage = new ListViewItem.ListViewSubItem();
                    DiscountPercentage.Text = item.Price_Discount == null ? "" : item.Discount.Where(p => p.PRODUCT_ID == item.ID && DateTime.Now >= p.FROM && DateTime.Now <= p.TO).FirstOrDefault().PERCENTAGE.ToString() + "%";

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
            this.Close();
            Checkout checkout = new Checkout();
            checkout.ShowDialog();

        }

        private void txt_searchBar_Enter(object sender, EventArgs e)
        {
            if (txt_searchBar.Text == "Procure pelo nome do produto")
            {
                txt_searchBar.Text = "";
            }
        }

        private void txt_searchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_searchBar.Text))
            {
                txt_searchBar.Text = "Procure pelo nome do produto";
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
            bool searchFavortites = false;
            if (chk_showFavorites.Checked)
            {
                searchFavortites = true;
            }
            else
            {
                searchFavortites = false;
            }
            List<GetFilteredProducts_Result> filteredProducts = EntitiesBarEscola.GetFilteredProducts(searchText, false, searchFavortites, searchFavortites ? Generic.current_Logged_Client.ID : 0).ToList();

            // Limpar e atualizar a listview
            refreshFilteredListview(filteredProducts);
        }

        private void refreshFilteredListview(List<GetFilteredProducts_Result> filteredProducts)
        {
            lvw_products.Items.Clear();
            foreach (GetFilteredProducts_Result item in filteredProducts)
            {
                if (item.Is_Deleted != true)
                {
                    ListViewItem Product = new ListViewItem();
                    Product.Text = item.Name;
                    Product.Tag = Product.Text;

                    ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                    Price.Text = item.Price_Discount == null ? Math.Round(item.Price, 2).ToString() + "€" : Math.Round(Convert.ToDouble(item.Price_Discount), 2).ToString() + "€";
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
        }

        private void cbb_categoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProductsByCategory();
        }

        private void FilterProductsByCategory()
        {
            EntitiesBarEscola = new EntitiesBarEscola();

            List<Product> Products = new List<Product>();
            if (chk_showFavorites.Checked)
            {
                Generic.current_Logged_Client = EntitiesBarEscola.CLIENT.Where(p => p.ID == Generic.current_Logged_Client.ID).FirstOrDefault();
                var ListidFavorites = Generic.current_Logged_Client.Favorite_Product.Select(p => p.Id_Product).ToList();
                Products = EntitiesBarEscola.Product.Where(s => ListidFavorites.Contains(s.ID)).ToList();
            }
            else
            {
                Products = EntitiesBarEscola.Product.ToList();
            }

            lvw_products.Items.Clear();
            foreach (Product item in Products)
            {
                if (cbb_categoryFilter.SelectedItem.ToString() == "Todos")
                {
                    if (chk_showFavorites.Checked)
                    {
                        RefreshFavorites();
                        break;
                    }
                    else
                    {
                        RefreshListView();
                        break;
                    }

                }

                if (item.TYPE.NAME == cbb_categoryFilter.SelectedItem.ToString())
                {
                    if (item.Is_Deleted != true)
                    {
                        ListViewItem Product = new ListViewItem();
                        Product.Text = item.Name;
                        Product.Tag = Product.Text;

                        ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                        Price.Text = item.Price_Discount == null ? Math.Round(item.Price, 2).ToString() + "€" : Math.Round(Convert.ToDouble(item.Price_Discount), 2).ToString() + "€";
                        Price.Tag = Price.Text;

                        ListViewItem.ListViewSubItem DiscountPercentage = new ListViewItem.ListViewSubItem();
                        DiscountPercentage.Text = item.Price_Discount == null ? "" : item.Discount.Where(p => p.PRODUCT_ID == item.ID && DateTime.Now >= p.FROM && DateTime.Now <= p.TO).FirstOrDefault().PERCENTAGE.ToString() + "%";

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
            AddFavoriteProduct();
        }

        private void AddFavoriteProduct()
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
            if (chk_showFavorites.Checked)
            {
                chk_showFavorites.BackgroundImage = Properties.Resources.heart__1_;
            }
            else
            {
                chk_showFavorites.BackgroundImage = Properties.Resources.heart;
            }

            if (cbb_categoryFilter.SelectedItem != "Todos")
            {
                FilterProductsByCategory();
            }
            else
            {

                RefreshFavorites();
            }
            if (txt_searchBar.Text != "Procure pelo nome do produto")
            {
                refreshFilteredListview(EntitiesBarEscola.GetFilteredProducts(txt_searchBar.Text, false, chk_showFavorites.Checked, chk_showFavorites.Checked ? Generic.current_Logged_Client.ID : 0).ToList());
            }
        }

        private void RefreshFavorites()
        {
            EntitiesBarEscola = new EntitiesBarEscola();
            if (chk_showFavorites.Checked == true)
            {
                lvw_products.Items.Clear();

                Generic.current_Logged_Client = EntitiesBarEscola.CLIENT.Where(p => p.ID == Generic.current_Logged_Client.ID).FirstOrDefault();
                var ListidFavorites = Generic.current_Logged_Client.Favorite_Product.Select(p => p.Id_Product).ToList();
                List<Product> Favorite_Products = EntitiesBarEscola.Product.Where(s => ListidFavorites.Contains(s.ID)).ToList();


                foreach (Product item in Favorite_Products)
                {
                    if (item.Is_Deleted != true)
                    {
                        ListViewItem ProductName = new ListViewItem();
                        ProductName.Text = item.Name;
                        ProductName.Tag = ProductName.Text;

                        ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                        Price.Text = item.Price_Discount == null ? Math.Round(item.Price, 2).ToString() + "€" : Math.Round(Convert.ToDouble(item.Price_Discount)).ToString() + "€";
                        Price.Tag = Price.Text;

                        ListViewItem.ListViewSubItem DiscountPercentage = new ListViewItem.ListViewSubItem();
                        DiscountPercentage.Text = item.Price_Discount == null ? "" : item.Discount.Where(p => p.PRODUCT_ID == item.ID && DateTime.Now >= p.FROM && DateTime.Now <= p.TO).FirstOrDefault().PERCENTAGE.ToString() + "%";

                        ListViewItem.ListViewSubItem Type_Name = new ListViewItem.ListViewSubItem();
                        Type_Name.Text = item.TYPE.NAME;
                        Type_Name.Tag = Type_Name.Text;

                        ProductName.SubItems.Add(Price);
                        ProductName.SubItems.Add(DiscountPercentage);
                        ProductName.SubItems.Add(Type_Name);

                        lvw_products.Items.Add(ProductName);
                    }
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
                MessageBox.Show("Produto adicionado ao carrinho!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            decimal Balance = Convert.ToDecimal(Generic.current_Logged_Client.BALANCE);
            lbl_totalBalance.Text = "Saldo Total: " + Math.Round(Balance, 2) + "€";

            MessageBox.Show("Saldo atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Refresh_History()
        {
            EntitiesBarEscola = new EntitiesBarEscola();

            lvw_history.Items.Clear();

            foreach (BUYS Receipt in EntitiesBarEscola.BUYS.Where(b => b.ID_CLIENT == Generic.current_Logged_Client.ID))
            {
                ListViewItem ReceiptNumber = new ListViewItem();
                ReceiptNumber.Text = Receipt.ID.ToString();
                ReceiptNumber.Tag = Receipt.ID.ToString();

                ListViewItem.ListViewSubItem Date = new ListViewItem.ListViewSubItem();
                Date.Text = Receipt.DATE.ToString();
                Date.Tag = Date.Text;

                ListViewItem.ListViewSubItem Total_Price = new ListViewItem.ListViewSubItem();
                Total_Price.Text = Math.Round(Convert.ToDouble(Receipt.TOTAL), 2).ToString() + "€";
                Total_Price.Tag = Total_Price.Text;

                ReceiptNumber.SubItems.Add(Date);
                ReceiptNumber.SubItems.Add(Total_Price);



                if (Receipt.IS_DELETED == true)
                {
                    ReceiptNumber.ForeColor = System.Drawing.Color.LightGray;
                    ReceiptNumber.Font = new System.Drawing.Font(ReceiptNumber.Font, System.Drawing.FontStyle.Strikeout);
                }

                lvw_history.Items.Add(ReceiptNumber);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tc_Options_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void tc_Options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_Options.SelectedIndex == 1)
            {
                Refresh_History();
            }
        }

        private void tsb_Open_Click(object sender, EventArgs e)
        {
            Show_Full_Receipt();
        }

        private void lvw_history_DoubleClick(object sender, EventArgs e)
        {
            if (lvw_history.SelectedItems.Count > 0)
            {
                Show_Full_Receipt();
            }
        }

        private void Show_Full_Receipt()
        {
            EntitiesBarEscola = new EntitiesBarEscola();

            string msg = "";
            int Buy_Id = int.Parse(lvw_history.SelectedItems[0].Tag.ToString());
            BUYS Selected_Buy = EntitiesBarEscola.BUYS.Where(b => b.ID == Buy_Id).FirstOrDefault();
            if (Selected_Buy.IS_DELETED == true)
            {
                MessageBox.Show("Esta compra foi cancelada!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<BUY_PRODUCTS> Buy_Products = EntitiesBarEscola.BUY_PRODUCTS.Where(b => b.ID_BUY == Selected_Buy.ID).ToList();

            foreach (BUY_PRODUCTS Receipt_Item in Buy_Products)
            {
                string disc = Receipt_Item.DISCOUNT == null ? " " : "(Desconto: " + Receipt_Item.DISCOUNT.ToString() + "%)";
                msg += $"{Receipt_Item.PRODUCT_NAME} {disc} \n{Receipt_Item.QUANTITY} X\t {Math.Round(Convert.ToDouble(Receipt_Item.PRICE / Receipt_Item.QUANTITY), 2)} \t\t {Math.Round(Convert.ToDouble(Receipt_Item.PRICE), 2)} \n\n";
            }

            msg += $"Total: {Math.Round(Convert.ToDouble(Selected_Buy.TOTAL), 2)}€";

            MessageBox.Show(msg, "Fatura", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void lvw_history_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_history.SelectedItems.Count > 0)
            {
                tsb_Open.Enabled = true;
                tsb_Cancel_Buy.Enabled = true;
            }
            else
            {
                tsb_Open.Enabled = false;
                tsb_Cancel_Buy.Enabled = false;
            }
        }

        private void lvw_history_Click(object sender, EventArgs e)
        {

        }

        private void tp_History_Leave(object sender, EventArgs e)
        {
            tsb_Open.Enabled = false;
            tsb_Cancel_Buy.Enabled = false;
        }

        private void ltsmi_List_Click(object sender, EventArgs e)
        {
            lvw_history.View = View.Details;
            foreach (ListViewItem item in lvw_history.Items)
            {
                item.Text = item.Text.Trim().Split('-')[0];
            }
        }

        private void ltsm_Icons_Click(object sender, EventArgs e)
        {
            lvw_history.View = View.LargeIcon;
            lvw_history.LargeImageList = iml_ListView;

            foreach (ListViewItem item in lvw_history.Items)
            {
                item.ImageIndex = 0;
                item.Text = item.SubItems[0].Text + " - " + item.SubItems[1].Text;
            }
        }

        private void tsb_Cancel_Buy_Click(object sender, EventArgs e)
        {
            string msg = $"Tem a certeza que quer cancelar esta compra? \n Vai-lhe ser devolvido {lvw_history.SelectedItems[0].SubItems[2].Tag}€";

            int Buy_To_Cancel = int.Parse(lvw_history.SelectedItems[0].Tag.ToString());
            this.Visible = false;
            cancelarCompra = new CancelarCompra(Buy_To_Cancel);
            cancelarCompra.ShowDialog();
            Refresh_History();
            LoadUserProfile();
            this.Visible = true;
        }

        private void btn_refreshProducts_Click(object sender, EventArgs e)
        {
            RefreshAndFetchData();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}