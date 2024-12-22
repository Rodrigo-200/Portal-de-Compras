namespace Portal_Compras
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_finalizeBuy = new System.Windows.Forms.Button();
            this.btn_exitCheckout = new System.Windows.Forms.Button();
            this.btn_removeProducts = new System.Windows.Forms.Button();
            this.nud_quantityRemoveProducts = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantityRemoveProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(409, 222);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total: 0€";
            // 
            // btn_finalizeBuy
            // 
            this.btn_finalizeBuy.Location = new System.Drawing.Point(288, 267);
            this.btn_finalizeBuy.Name = "btn_finalizeBuy";
            this.btn_finalizeBuy.Size = new System.Drawing.Size(133, 30);
            this.btn_finalizeBuy.TabIndex = 2;
            this.btn_finalizeBuy.Text = "Finalizar a compra";
            this.btn_finalizeBuy.UseVisualStyleBackColor = true;
            // 
            // btn_exitCheckout
            // 
            this.btn_exitCheckout.Location = new System.Drawing.Point(347, 429);
            this.btn_exitCheckout.Name = "btn_exitCheckout";
            this.btn_exitCheckout.Size = new System.Drawing.Size(75, 30);
            this.btn_exitCheckout.TabIndex = 3;
            this.btn_exitCheckout.Text = "Sair";
            this.btn_exitCheckout.UseVisualStyleBackColor = true;
            // 
            // btn_removeProducts
            // 
            this.btn_removeProducts.Location = new System.Drawing.Point(12, 271);
            this.btn_removeProducts.Name = "btn_removeProducts";
            this.btn_removeProducts.Size = new System.Drawing.Size(145, 30);
            this.btn_removeProducts.TabIndex = 4;
            this.btn_removeProducts.Text = "Remover produto/s";
            this.btn_removeProducts.UseVisualStyleBackColor = true;
            // 
            // nud_quantityRemoveProducts
            // 
            this.nud_quantityRemoveProducts.Location = new System.Drawing.Point(67, 308);
            this.nud_quantityRemoveProducts.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_quantityRemoveProducts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantityRemoveProducts.Name = "nud_quantityRemoveProducts";
            this.nud_quantityRemoveProducts.Size = new System.Drawing.Size(90, 22);
            this.nud_quantityRemoveProducts.TabIndex = 5;
            this.nud_quantityRemoveProducts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 471);
            this.Controls.Add(this.nud_quantityRemoveProducts);
            this.Controls.Add(this.btn_removeProducts);
            this.Controls.Add(this.btn_exitCheckout);
            this.Controls.Add(this.btn_finalizeBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Checkout";
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantityRemoveProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_finalizeBuy;
        private System.Windows.Forms.Button btn_exitCheckout;
        private System.Windows.Forms.Button btn_removeProducts;
        private System.Windows.Forms.NumericUpDown nud_quantityRemoveProducts;
    }
}