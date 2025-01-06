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
        EntitiesBarEscola EntitiesBarEscola = new EntitiesBarEscola();
        public Checkout()
        {
            InitializeComponent();
        }




        private void btn_finalizeBuy_Click(object sender, EventArgs e)
        {
            //Perguntar ao professor
            EntitiesBarEscola EntitiesBarEscola = new EntitiesBarEscola();

            if (Generic.current_Logged_Client.BALANCE < Convert.ToDecimal(lbl_Total.Text.Split(':')[1]))
            {
                //Perguntar ao professor
                DialogResult result = MessageBox.Show("Saldo insuficiente! \n Deseja atualizar o saldo do seu cartão?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    this.Visible = false;
                    Portal portal = new Portal(2);
                    portal.ShowDialog();
                    return;
                }
                else
                    return;
            }
            else
            {
                foreach (var item in EntitiesBarEscola.CART_ITEMS.Where(i => i.Cart_ID == EntitiesBarEscola.CART.Where(u => u.User_ID == Generic.current_Logged_Client.ID).FirstOrDefault().Cart_ID))
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
                        DISCOUNT = item.Product.Price_Discount == null ? null : item.Product.Discount.Where(p => p.PRODUCT_ID == item.Product_ID).FirstOrDefault().PERCENTAGE,
                        PRODUCT_NAME = item.Product.Name
                    };
                    EntitiesBarEscola.BUY_PRODUCTS.Add(buy_Products);
                }

                EntitiesBarEscola.SaveChanges();



                EntitiesBarEscola.CART_ITEMS.RemoveRange(EntitiesBarEscola.CART_ITEMS.Where(i => i.Cart_ID == EntitiesBarEscola.CART.Where(u => u.User_ID == Generic.current_Logged_Client.ID).FirstOrDefault().Cart_ID));
                EntitiesBarEscola.SaveChanges();
                refreshListView();
            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            refreshListView();

        }

        private void refreshListView()
        {
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
                Price.Text = (item.Quantity * price).ToString();

                Product.SubItems.Add(Quantity);
                Product.SubItems.Add(Price);

                lvw_CartItems.Items.Add(Product);

                total += Convert.ToDecimal(item.Quantity * price);
            }

            lbl_Total.Text = "Total: " + total.ToString();
        }
    }
}
