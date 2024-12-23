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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_finalizeBuy = new System.Windows.Forms.Button();
            this.btn_exitCheckout = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_removeProducts = new System.Windows.Forms.Button();
            this.nud_quantityRemoveProducts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantityRemoveProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(322, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total: 0€";
            // 
            // btn_finalizeBuy
            // 
            this.btn_finalizeBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_finalizeBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizeBuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_finalizeBuy.ForeColor = System.Drawing.Color.White;
            this.btn_finalizeBuy.Location = new System.Drawing.Point(231, 321);
            this.btn_finalizeBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_finalizeBuy.Name = "btn_finalizeBuy";
            this.btn_finalizeBuy.Size = new System.Drawing.Size(100, 30);
            this.btn_finalizeBuy.TabIndex = 2;
            this.btn_finalizeBuy.Text = "Finalizar";
            this.btn_finalizeBuy.UseVisualStyleBackColor = false;
            this.btn_finalizeBuy.Click += new System.EventHandler(this.btn_finalizeBuy_Click);
            // 
            // btn_exitCheckout
            // 
            this.btn_exitCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_exitCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitCheckout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_exitCheckout.ForeColor = System.Drawing.Color.White;
            this.btn_exitCheckout.Location = new System.Drawing.Point(275, 392);
            this.btn_exitCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exitCheckout.Name = "btn_exitCheckout";
            this.btn_exitCheckout.Size = new System.Drawing.Size(56, 27);
            this.btn_exitCheckout.TabIndex = 3;
            this.btn_exitCheckout.Text = "Sair";
            this.btn_exitCheckout.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 392);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(247, 27);
            this.progressBar1.TabIndex = 8;
            // 
            // btn_removeProducts
            // 
            this.btn_removeProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_removeProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_removeProducts.ForeColor = System.Drawing.Color.White;
            this.btn_removeProducts.Location = new System.Drawing.Point(127, 321);
            this.btn_removeProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btn_removeProducts.Name = "btn_removeProducts";
            this.btn_removeProducts.Size = new System.Drawing.Size(100, 30);
            this.btn_removeProducts.TabIndex = 5;
            this.btn_removeProducts.Text = "Remover";
            this.btn_removeProducts.UseVisualStyleBackColor = false;
            this.btn_removeProducts.Click += new System.EventHandler(this.btn_removeProducts_Click);
            // 
            // nud_quantityRemoveProducts
            // 
            this.nud_quantityRemoveProducts.Location = new System.Drawing.Point(14, 327);
            this.nud_quantityRemoveProducts.Margin = new System.Windows.Forms.Padding(2);
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
            this.nud_quantityRemoveProducts.Size = new System.Drawing.Size(109, 20);
            this.nud_quantityRemoveProducts.TabIndex = 6;
            this.nud_quantityRemoveProducts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.nud_quantityRemoveProducts);
            this.Controls.Add(this.btn_removeProducts);
            this.Controls.Add(this.btn_exitCheckout);
            this.Controls.Add(this.btn_finalizeBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_removeProducts;
        private System.Windows.Forms.NumericUpDown nud_quantityRemoveProducts;
        private System.Windows.Forms.Label label2;
    }
}