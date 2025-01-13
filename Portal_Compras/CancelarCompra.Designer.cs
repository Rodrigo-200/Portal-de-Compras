namespace Portal_Compras
{
    partial class CancelarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarCompra));
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
            this.lvw_Full_Receipt.Location = new System.Drawing.Point(9, 54);
            this.lvw_Full_Receipt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvw_Full_Receipt.Name = "lvw_Full_Receipt";
            this.lvw_Full_Receipt.Size = new System.Drawing.Size(330, 270);
            this.lvw_Full_Receipt.TabIndex = 0;
            this.lvw_Full_Receipt.UseCompatibleStateImageBehavior = false;
            this.lvw_Full_Receipt.View = System.Windows.Forms.View.Details;
            this.lvw_Full_Receipt.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvw_Full_Receipt_ItemChecked);
            this.lvw_Full_Receipt.SelectedIndexChanged += new System.EventHandler(this.lvw_Full_Receipt_SelectedIndexChanged);
            // 
            // chk_Name
            // 
            this.chk_Name.Text = "Nome";
            this.chk_Name.Width = 79;
            // 
            // chk_Quantity
            // 
            this.chk_Quantity.Text = "Quantidade";
            this.chk_Quantity.Width = 105;
            // 
            // chk_Price
            // 
            this.chk_Price.Text = "Preço Total";
            this.chk_Price.Width = 114;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(253, 328);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 28);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione os produtos que quer cancelar:";
            // 
            // ts_Options
            // 
            this.ts_Options.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Select_All});
            this.ts_Options.Location = new System.Drawing.Point(0, 0);
            this.ts_Options.Name = "ts_Options";
            this.ts_Options.Size = new System.Drawing.Size(348, 27);
            this.ts_Options.TabIndex = 9;
            this.ts_Options.Text = "toolStrip1";
            // 
            // tsb_Select_All
            // 
            this.tsb_Select_All.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Select_All.Image")));
            this.tsb_Select_All.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Select_All.Name = "tsb_Select_All";
            this.tsb_Select_All.Size = new System.Drawing.Size(120, 24);
            this.tsb_Select_All.Text = "Selecionar Todos";
            this.tsb_Select_All.Click += new System.EventHandler(this.tsb_Select_All_Click);
            // 
            // CancelarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 362);
            this.Controls.Add(this.ts_Options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lvw_Full_Receipt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CancelarCompra";
            this.Text = "CancelarCompra";
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