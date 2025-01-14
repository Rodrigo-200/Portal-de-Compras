using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_Compras
{
    public partial class Checkout : Form
    {
        Color initialButtonColor = new Color();
        EntitiesBarEscola EntitiesBarEscola = new EntitiesBarEscola();
        public Checkout()
        {
            InitializeComponent();
            initialButtonColor = btn_finalizeBuy.BackColor;
        }

        private void btn_finalizeBuy_Click(object sender, EventArgs e)
        {
            EntitiesBarEscola = new EntitiesBarEscola();

            if (Generic.current_Logged_Client.BALANCE < Convert.ToDecimal(lbl_Total.Text.Split(':')[1]))
            {
                DialogResult result = MessageBox.Show("Saldo insuficiente! \n Deseja atualizar o saldo do seu cartão?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    this.Visible = false;
                    this.Close();
                    Portal portal = new Portal(2);
                    portal.ShowDialog();
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                foreach (var item in EntitiesBarEscola.CART_ITEMS.Where(i => i.Cart_ID == EntitiesBarEscola.CART.FirstOrDefault(u => u.User_ID == Generic.current_Logged_Client.ID).Cart_ID).ToList())
                {
                    if (item.Product.Stock < item.Quantity)
                    {
                        DialogResult result = MessageBox.Show("O produto " + item.Product.Name + " está fora de stock \n Quer continuar esta compra removendo este produto do seu carrinho?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (result == DialogResult.Yes)
                        {
                            EntitiesBarEscola.CART_ITEMS.Remove(item);
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                EntitiesBarEscola.SaveChanges();
                refreshListView();

                foreach (var item in EntitiesBarEscola.CART_ITEMS.Where(i => i.Cart_ID == EntitiesBarEscola.CART.Where(u => u.User_ID == Generic.current_Logged_Client.ID).FirstOrDefault().Cart_ID))
                {
                    item.Product.Stock -= item.Quantity;
                }

                Generic.current_Logged_Client.BALANCE -= Convert.ToDecimal(lbl_Total.Text.Split(':')[1]);
                EntitiesBarEscola.CLIENT.Where(c => c.ID == Generic.current_Logged_Client.ID).FirstOrDefault().BALANCE = Generic.current_Logged_Client.BALANCE;

                BUYS buy = new BUYS
                {
                    ID_CLIENT = Generic.current_Logged_Client.ID,
                    DATE = DateTime.Now,
                    TOTAL = Convert.ToDecimal(lbl_Total.Text.Split(':')[1])
                };

                EntitiesBarEscola.BUYS.Add(buy);
                EntitiesBarEscola.SaveChanges();

                foreach (var item in EntitiesBarEscola.CART_ITEMS.Where(i => i.Cart_ID == EntitiesBarEscola.CART.Where(u => u.User_ID == Generic.current_Logged_Client.ID).FirstOrDefault().Cart_ID))
                {
                    BUY_PRODUCTS buy_Products = new BUY_PRODUCTS
                    {
                        ID_BUY = buy.ID,
                        ID_PRODUCT = item.Product_ID,
                        QUANTITY = Convert.ToInt32(item.Quantity),
                        PRICE = item.Quantity * Convert.ToDecimal(item.Product.Price_Discount == null ? item.Product.Price : item.Product.Price_Discount),
                        DISCOUNT = item.Product.Price_Discount == null ? null : item.Product.Discount.Where(p => p.PRODUCT_ID == item.Product_ID && DateTime.Now >= p.FROM && DateTime.Now <= p.TO).FirstOrDefault().PERCENTAGE,
                        PRODUCT_NAME = item.Product.Name
                    };
                    EntitiesBarEscola.BUY_PRODUCTS.Add(buy_Products);
                }

                EntitiesBarEscola.SaveChanges();



                EntitiesBarEscola.CART_ITEMS.RemoveRange(EntitiesBarEscola.CART_ITEMS.Where(i => i.Cart_ID == EntitiesBarEscola.CART.Where(u => u.User_ID == Generic.current_Logged_Client.ID).FirstOrDefault().Cart_ID));
                EntitiesBarEscola.SaveChanges();
                refreshListView();


                string msg = "";
                List<BUY_PRODUCTS> Buy_Products = EntitiesBarEscola.BUY_PRODUCTS.Where(b => b.ID_BUY == buy.ID).ToList();

                foreach (BUY_PRODUCTS Receipt_Item in Buy_Products)
                {
                    string disc = Receipt_Item.DISCOUNT == null ? " " : "(Desconto: " + Receipt_Item.DISCOUNT.ToString() + "%)";
                    msg += $"{Receipt_Item.PRODUCT_NAME} {disc} \n{Receipt_Item.QUANTITY} X\t {Math.Round(Convert.ToDouble(Receipt_Item.PRICE / Receipt_Item.QUANTITY), 2)} \t\t {Math.Round(Convert.ToDouble(Receipt_Item.PRICE), 2)} \n\n";
                }

                msg += $"Total: {Math.Round(Convert.ToDouble(buy.TOTAL), 2)}€";

                MessageBox.Show($"Compra Finalizada com Sucesso\nResumo de compra:\n\n{msg}", "Compra efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            refreshListView();
        }

        private void refreshListView()
        {
            EntitiesBarEscola = new EntitiesBarEscola();
            lvw_CartItems.Items.Clear();
            decimal total = 0;
            foreach (var item in EntitiesBarEscola.CART_ITEMS.Where(i => i.Cart_ID == EntitiesBarEscola.CART.Where(u => u.User_ID == Generic.current_Logged_Client.ID).FirstOrDefault().Cart_ID))
            {

                decimal price = Convert.ToDecimal(item.Product.Price_Discount == null ? item.Product.Price : item.Product.Price_Discount);

                ListViewItem Product = new ListViewItem();
                Product.Text = item.Product.Name;

                ListViewItem.ListViewSubItem Quantity = new ListViewItem.ListViewSubItem();
                Quantity.Text = item.Quantity.ToString();

                ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                Price.Text = Math.Round(Convert.ToDecimal(item.Quantity * price), 2).ToString();

                Product.SubItems.Add(Quantity);
                Product.SubItems.Add(Price);

                lvw_CartItems.Items.Add(Product);

                total += Convert.ToDecimal(item.Quantity * price);
            }

            lbl_Total.Text = "Total: " + Math.Round(total, 2).ToString();

            if (lvw_CartItems.Items.Count > 0)
            {
                btn_finalizeBuy.Enabled = true;
                btn_finalizeBuy.BackColor = initialButtonColor;

            }
            else
            {
                btn_finalizeBuy.Enabled = false;
                btn_finalizeBuy.BackColor = Color.LightGray;
            }
        }

        private void btn_removeProducts_Click(object sender, EventArgs e)
        {
            if (lvw_CartItems.SelectedItems.Count > 0)
            {
                int QuantityToRemove = Convert.ToInt32(nud_QuatityToRemove.Value);
                EntitiesBarEscola = new EntitiesBarEscola();
                foreach (ListViewItem item in lvw_CartItems.SelectedItems)
                {
                    var product = EntitiesBarEscola.CART_ITEMS.Where(i => i.Product.Name == item.Text).FirstOrDefault();
                    if (product.Quantity >= QuantityToRemove)
                    {
                        product.Quantity -= QuantityToRemove;
                    }

                    if (product.Quantity <= 0)
                    {
                        EntitiesBarEscola.CART_ITEMS.Remove(product);
                    }
                    else
                    {
                        EntitiesBarEscola.CART_ITEMS.Where(CART_ITEMS => CART_ITEMS.Product.Name == item.Text).FirstOrDefault().Quantity = product.Quantity;
                    }
                }

                EntitiesBarEscola.SaveChanges();
                refreshListView();
            }
        }

        private void btn_exitCheckout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            Portal portal = new Portal();
            portal.ShowDialog();
        }
    }
}
