namespace Portal_Compras
{
    partial class Checkout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lvw_CartItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_exitCheckout = new System.Windows.Forms.Button();
            this.nud_QuatityToRemove = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_removeProducts = new System.Windows.Forms.Button();
            this.btn_finalizeBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_QuatityToRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // lvw_CartItems
            // 
            this.lvw_CartItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvw_CartItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lvw_CartItems.FullRowSelect = true;
            this.lvw_CartItems.HideSelection = false;
            this.lvw_CartItems.Location = new System.Drawing.Point(12, 12);
            this.lvw_CartItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvw_CartItems.Name = "lvw_CartItems";
            this.lvw_CartItems.Size = new System.Drawing.Size(623, 384);
            this.lvw_CartItems.TabIndex = 0;
            this.lvw_CartItems.UseCompatibleStateImageBehavior = false;
            this.lvw_CartItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantidade";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço";
            this.columnHeader3.Width = 150;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Total.Location = new System.Drawing.Point(7, 400);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(82, 28);
            this.lbl_Total.TabIndex = 1;
            this.lbl_Total.Text = "Total: 0";
            // 
            // btn_exitCheckout
            // 
            this.btn_exitCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_exitCheckout.FlatAppearance.BorderSize = 0;
            this.btn_exitCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitCheckout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_exitCheckout.ForeColor = System.Drawing.Color.White;
            this.btn_exitCheckout.Location = new System.Drawing.Point(647, 402);
            this.btn_exitCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exitCheckout.Name = "btn_exitCheckout";
            this.btn_exitCheckout.Size = new System.Drawing.Size(149, 39);
            this.btn_exitCheckout.TabIndex = 3;
            this.btn_exitCheckout.Text = "Sair";
            this.btn_exitCheckout.UseVisualStyleBackColor = false;
            this.btn_exitCheckout.Click += new System.EventHandler(this.btn_exitCheckout_Click);
            // 
            // nud_QuatityToRemove
            // 
            this.nud_QuatityToRemove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nud_QuatityToRemove.Location = new System.Drawing.Point(647, 38);
            this.nud_QuatityToRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_QuatityToRemove.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_QuatityToRemove.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_QuatityToRemove.Name = "nud_QuatityToRemove";
            this.nud_QuatityToRemove.Size = new System.Drawing.Size(149, 30);
            this.nud_QuatityToRemove.TabIndex = 6;
            this.nud_QuatityToRemove.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(641, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade";
            // 
            // btn_removeProducts
            // 
            this.btn_removeProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_removeProducts.FlatAppearance.BorderSize = 0;
            this.btn_removeProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_removeProducts.ForeColor = System.Drawing.Color.White;
            this.btn_removeProducts.Location = new System.Drawing.Point(647, 75);
            this.btn_removeProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_removeProducts.Name = "btn_removeProducts";
            this.btn_removeProducts.Size = new System.Drawing.Size(149, 39);
            this.btn_removeProducts.TabIndex = 5;
            this.btn_removeProducts.Text = "Remover";
            this.btn_removeProducts.UseVisualStyleBackColor = false;
            this.btn_removeProducts.Click += new System.EventHandler(this.btn_removeProducts_Click);
            // 
            // btn_finalizeBuy
            // 
            this.btn_finalizeBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_finalizeBuy.Enabled = false;
            this.btn_finalizeBuy.FlatAppearance.BorderSize = 0;
            this.btn_finalizeBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizeBuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_finalizeBuy.ForeColor = System.Drawing.Color.White;
            this.btn_finalizeBuy.Location = new System.Drawing.Point(647, 346);
            this.btn_finalizeBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_finalizeBuy.Name = "btn_finalizeBuy";
            this.btn_finalizeBuy.Size = new System.Drawing.Size(149, 39);
            this.btn_finalizeBuy.TabIndex = 2;
            this.btn_finalizeBuy.Text = "Finalizar";
            this.btn_finalizeBuy.UseVisualStyleBackColor = false;
            this.btn_finalizeBuy.Click += new System.EventHandler(this.btn_finalizeBuy_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 455);
            this.Controls.Add(this.btn_exitCheckout);
            this.Controls.Add(this.btn_finalizeBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_removeProducts);
            this.Controls.Add(this.nud_QuatityToRemove);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lvw_CartItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_QuatityToRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvw_CartItems;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_exitCheckout;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown nud_QuatityToRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_removeProducts;
        private System.Windows.Forms.Button btn_finalizeBuy;
    }
}