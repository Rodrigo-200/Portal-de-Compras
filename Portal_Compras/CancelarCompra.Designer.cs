namespace Portal_Compras
{
    partial class CancelarCompra
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpeza de recursos usados.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
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
        /// Método exigido para suporte do Windows Form Designer.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvw_Full_Receipt = new System.Windows.Forms.ListView();
            this.chk_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chk_Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chk_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ts_Options = new System.Windows.Forms.ToolStrip();
            this.tsb_Select_All = new System.Windows.Forms.ToolStripButton();
            this.ts_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvw_Full_Receipt
            // 
            this.lvw_Full_Receipt.CheckBoxes = true;
            this.lvw_Full_Receipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chk_Name,
            this.chk_Quantity,
            this.chk_Price});
            this.lvw_Full_Receipt.FullRowSelect = true;
            this.lvw_Full_Receipt.HideSelection = false;
            this.lvw_Full_Receipt.Location = new System.Drawing.Point(12, 65);
            this.lvw_Full_Receipt.Name = "lvw_Full_Receipt";
            this.lvw_Full_Receipt.Size = new System.Drawing.Size(335, 280);
            this.lvw_Full_Receipt.TabIndex = 0;
            this.lvw_Full_Receipt.UseCompatibleStateImageBehavior = false;
            this.lvw_Full_Receipt.View = System.Windows.Forms.View.Details;
            this.lvw_Full_Receipt.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvw_Full_Receipt_ItemChecked);
            this.lvw_Full_Receipt.SelectedIndexChanged += new System.EventHandler(this.lvw_Full_Receipt_SelectedIndexChanged);
            // 
            // chk_Name
            // 
            this.chk_Name.Text = "Nome";
            this.chk_Name.Width = 100;
            // 
            // chk_Quantity
            // 
            this.chk_Quantity.Text = "Quantidade";
            this.chk_Quantity.Width = 100;
            // 
            // chk_Price
            // 
            this.chk_Price.Text = "Preço Total";
            this.chk_Price.Width = 120;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(230, 355);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(115, 40);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione os produtos a cancelar:";
            // 
            // ts_Options
            // 
            this.ts_Options.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Select_All});
            this.ts_Options.Location = new System.Drawing.Point(0, 0);
            this.ts_Options.Name = "ts_Options";
            this.ts_Options.Size = new System.Drawing.Size(360, 27);
            this.ts_Options.TabIndex = 9;
            this.ts_Options.Text = "toolStrip1";
            // 
            // tsb_Select_All
            // 
            this.tsb_Select_All.Image = global::Portal_Compras.Properties.Resources.list;
            this.tsb_Select_All.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Select_All.Name = "tsb_Select_All";
            this.tsb_Select_All.Size = new System.Drawing.Size(120, 24);
            this.tsb_Select_All.Text = "Selecionar Todos";
            this.tsb_Select_All.Click += new System.EventHandler(this.tsb_Select_All_Click);
            // 
            // CancelarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 420);
            this.Controls.Add(this.ts_Options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lvw_Full_Receipt);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CancelarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Compra";
            this.Load += new System.EventHandler(this.CancelarCompra_Load);
            this.ts_Options.ResumeLayout(false);
            this.ts_Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvw_Full_Receipt;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chk_Name;
        private System.Windows.Forms.ColumnHeader chk_Quantity;
        private System.Windows.Forms.ColumnHeader chk_Price;
        private System.Windows.Forms.ToolStrip ts_Options;
        private System.Windows.Forms.ToolStripButton tsb_Select_All;
    }
}
