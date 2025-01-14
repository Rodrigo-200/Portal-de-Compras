using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Portal_Compras
{
    public partial class CancelarCompra : Form
    {
        int Buy_To_Cancel = 0;
        bool Save_All = false;

        EntitiesBarEscola EntitiesBarEscola = new EntitiesBarEscola();

        public CancelarCompra(int buy = 0)
        {
            InitializeComponent();
            Buy_To_Cancel = buy;
            RefreshProducts();
        }

        private void lvw_Full_Receipt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Afetar a BD
            List<BUY_PRODUCTS> Products_To_Cancel = EntitiesBarEscola.BUY_PRODUCTS.Where(b => b.ID_BUY == Buy_To_Cancel).ToList();
            decimal totalRefund = 0;
            decimal newTotal = 0;


            foreach (ListViewItem product in lvw_Full_Receipt.CheckedItems)
            {
                var productToCancel = Products_To_Cancel.Where(b => b.PRODUCT_NAME == product.Text).FirstOrDefault();
                if (productToCancel != null)
                {
                    decimal productPrice = decimal.Parse(product.SubItems[2].Text.Split(' ')[0]);
                    int productQuantity = int.Parse(product.SubItems[1].Text);
                    var ProductToUpdate = EntitiesBarEscola.Product.Where(p => p.ID == productToCancel.ID_PRODUCT).FirstOrDefault();

                    if (productQuantity != 0)
                    {

                        if (ProductToUpdate != null)
                        {
                            ProductToUpdate.Stock += productToCancel.QUANTITY - productQuantity;
                        }

                        productToCancel.PRICE = productPrice;
                        productToCancel.QUANTITY = productQuantity;
                    }
                    else
                    {
                        if (ProductToUpdate != null)
                        {
                            ProductToUpdate.Stock += productToCancel.QUANTITY;
                        }
                    }
                    productToCancel.Is_Deleted = productQuantity == 0 ? true : false;

                    // Atualizar o valor a devolver ao cliente
                    BUY_PRODUCTS MoneyToReturn = Products_To_Cancel.Where(p => p.PRODUCT_NAME == product.Text).FirstOrDefault();

                        totalRefund += Convert.ToDecimal(MoneyToReturn.PRICE / MoneyToReturn.QUANTITY);




                    newTotal += productPrice;

                    productToCancel.PRICE = productPrice;
                    productToCancel.QUANTITY = productQuantity;
                }
            }

            // Atualizar o saldo do cliente
            var client = EntitiesBarEscola.CLIENT.Where(c => c.ID == Generic.current_Logged_Client.ID).FirstOrDefault();
            if (client != null)
            {
                client.BALANCE += totalRefund;
            }

            // Atualizar o total da compra
            EntitiesBarEscola.BUYS.FirstOrDefault(b => b.ID == Buy_To_Cancel).TOTAL = newTotal;

            EntitiesBarEscola.SaveChanges();
            RefreshProducts();
        }

        private void RefreshProducts()
        {
            //O price já tem o desconto aplicado???
            //Se a qtd for 0 pôr a rasurado

            lvw_Full_Receipt.Items.Clear();

            int AllDeleted = 0;

            foreach(BUY_PRODUCTS Buy_Product in EntitiesBarEscola.BUY_PRODUCTS.Where(b => b.ID_BUY == Buy_To_Cancel ))
            {
                if (Buy_Product.Is_Deleted != true)
                {
                    ListViewItem Product = new ListViewItem();
                    Product.Text = Buy_Product.PRODUCT_NAME;
                    Product.Tag = Product.Text;

                    ListViewItem.ListViewSubItem Quantity = new ListViewItem.ListViewSubItem();
                    Quantity.Text = Buy_Product.QUANTITY.ToString();
                    Quantity.Tag = Quantity.Text;

                    ListViewItem.ListViewSubItem Price = new ListViewItem.ListViewSubItem();
                    Price.Text = Buy_Product.PRICE + " €";
                    Price.Tag = Price.Text;

                    Product.SubItems.Add(Quantity);
                    Product.SubItems.Add(Price);

                    lvw_Full_Receipt.Items.Add(Product);
                }
                else
                {
                    AllDeleted++;
                }
            }

            if (AllDeleted == EntitiesBarEscola.BUY_PRODUCTS.Where(b => b.ID_BUY == Buy_To_Cancel).Count())
            {
                BUYS Buy = EntitiesBarEscola.BUYS.Where(b => b.ID == Buy_To_Cancel).FirstOrDefault();
                if(Buy != null)
                {
                    EntitiesBarEscola.BUYS.Where(b => b.ID == Buy_To_Cancel).FirstOrDefault().IS_DELETED = true;
                    EntitiesBarEscola.SaveChanges();

                    MessageBox.Show("Não existem mais produtos para devolver!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
        }

        private void CancelarCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void lvw_Full_Receipt_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!Save_All)
            {
                if (e.Item.Checked)
                {
                    string Quantity_To_Cancel = Interaction.InputBox("Quantidade a cancelar?", "Cancel", "");

                    if (int.TryParse(Quantity_To_Cancel, out int value) && int.Parse(e.Item.SubItems[1].Text) - value >= 0)
                    {
                        //Atualizar a quantidade e o preço total
                        decimal Single_Price = decimal.Parse(e.Item.SubItems[2].Text.Split(' ')[0]) / decimal.Parse(e.Item.SubItems[1].Text);

                        e.Item.SubItems[1].Text = (int.Parse(e.Item.SubItems[1].Text) - value).ToString();

                        e.Item.SubItems[2].Text = (decimal.Parse(e.Item.SubItems[1].Text) * Single_Price).ToString() + " €";
                    }
                    else
                    {
                        e.Item.Checked = false;
                        MessageBox.Show("Quantidade Inválida!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //Cancelar o reembolso do produto
                {
                    //Repor os valores através das tags
                    e.Item.SubItems[1].Text = e.Item.SubItems[1].Tag.ToString();
                    e.Item.SubItems[2].Text = e.Item.SubItems[2].Tag.ToString();
                }
            }

            Save_All = false;
        }

        private void tsb_Select_All_Click(object sender, EventArgs e)
        {
            //Se selecionar todos não se escolhe a quantidade
            foreach (ListViewItem Produto in lvw_Full_Receipt.Items)
            {
                Save_All = true;
                Produto.Checked = true;
                Produto.SubItems[1].Text = "0";
                Produto.SubItems[2].Text = "0.00 €";
            }
        }
    }
}
