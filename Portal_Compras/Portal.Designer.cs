namespace Portal_Compras
{
    partial class Portal
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
            this.components = new System.ComponentModel.Container();
            this.tc_Options = new System.Windows.Forms.TabControl();
            this.tp_Buy = new System.Windows.Forms.TabPage();
            this.chk_showFavorites = new System.Windows.Forms.CheckBox();
            this.btn_addToFavorites = new System.Windows.Forms.Button();
            this.btn_refreshProducts = new System.Windows.Forms.Button();
            this.lbl_Search_Message = new System.Windows.Forms.Label();
            this.txt_searchBar = new System.Windows.Forms.TextBox();
            this.btn_openCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.nud_quanity = new System.Windows.Forms.NumericUpDown();
            this.lvw_products = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbb_categoryFilter = new System.Windows.Forms.ComboBox();
            this.tp_History = new System.Windows.Forms.TabPage();
            this.lstvw_history = new System.Windows.Forms.ListView();
            this.btn_cancelBuy = new System.Windows.Forms.Button();
            this.tp_Profile = new System.Windows.Forms.TabPage();
            this.lbl_NIF = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.nud_depositMoney = new System.Windows.Forms.NumericUpDown();
            this.btn_depositMoney = new System.Windows.Forms.Button();
            this.lbl_totalBalance = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.cms_LvwProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adicionarComoFavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_Options.SuspendLayout();
            this.tp_Buy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quanity)).BeginInit();
            this.tp_History.SuspendLayout();
            this.tp_Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_depositMoney)).BeginInit();
            this.cms_LvwProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Options
            // 
            this.tc_Options.Controls.Add(this.tp_Buy);
            this.tc_Options.Controls.Add(this.tp_History);
            this.tc_Options.Controls.Add(this.tp_Profile);
            this.tc_Options.Location = new System.Drawing.Point(3, 2);
            this.tc_Options.Margin = new System.Windows.Forms.Padding(2);
            this.tc_Options.Name = "tc_Options";
            this.tc_Options.SelectedIndex = 0;
            this.tc_Options.Size = new System.Drawing.Size(367, 479);
            this.tc_Options.TabIndex = 0;
            // 
            // tp_Buy
            // 
            this.tp_Buy.Controls.Add(this.chk_showFavorites);
            this.tp_Buy.Controls.Add(this.btn_addToFavorites);
            this.tp_Buy.Controls.Add(this.btn_refreshProducts);
            this.tp_Buy.Controls.Add(this.lbl_Search_Message);
            this.tp_Buy.Controls.Add(this.txt_searchBar);
            this.tp_Buy.Controls.Add(this.btn_openCart);
            this.tp_Buy.Controls.Add(this.label1);
            this.tp_Buy.Controls.Add(this.btn_addToCart);
            this.tp_Buy.Controls.Add(this.nud_quanity);
            this.tp_Buy.Controls.Add(this.lvw_products);
            this.tp_Buy.Controls.Add(this.cbb_categoryFilter);
            this.tp_Buy.Location = new System.Drawing.Point(4, 22);
            this.tp_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.tp_Buy.Name = "tp_Buy";
            this.tp_Buy.Padding = new System.Windows.Forms.Padding(2);
            this.tp_Buy.Size = new System.Drawing.Size(359, 453);
            this.tp_Buy.TabIndex = 0;
            this.tp_Buy.Text = "Compras";
            this.tp_Buy.UseVisualStyleBackColor = true;
            // 
            // chk_showFavorites
            // 
            this.chk_showFavorites.AutoSize = true;
            this.chk_showFavorites.Location = new System.Drawing.Point(125, 18);
            this.chk_showFavorites.Margin = new System.Windows.Forms.Padding(2);
            this.chk_showFavorites.Name = "chk_showFavorites";
            this.chk_showFavorites.Size = new System.Drawing.Size(118, 17);
            this.chk_showFavorites.TabIndex = 11;
            this.chk_showFavorites.Text = "Mostrar só favoritos";
            this.chk_showFavorites.UseVisualStyleBackColor = true;
            this.chk_showFavorites.CheckedChanged += new System.EventHandler(this.chk_showFavorites_CheckedChanged);
            // 
            // btn_addToFavorites
            // 
            this.btn_addToFavorites.Location = new System.Drawing.Point(75, 424);
            this.btn_addToFavorites.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addToFavorites.Name = "btn_addToFavorites";
            this.btn_addToFavorites.Size = new System.Drawing.Size(68, 24);
            this.btn_addToFavorites.TabIndex = 10;
            this.btn_addToFavorites.Text = "Favorito";
            this.btn_addToFavorites.UseVisualStyleBackColor = true;
            // 
            // btn_refreshProducts
            // 
            this.btn_refreshProducts.Location = new System.Drawing.Point(2, 424);
            this.btn_refreshProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refreshProducts.Name = "btn_refreshProducts";
            this.btn_refreshProducts.Size = new System.Drawing.Size(69, 24);
            this.btn_refreshProducts.TabIndex = 9;
            this.btn_refreshProducts.Text = "Refresh";
            this.btn_refreshProducts.UseVisualStyleBackColor = true;
            // 
            // lbl_Search_Message
            // 
            this.lbl_Search_Message.AutoSize = true;
            this.lbl_Search_Message.Location = new System.Drawing.Point(4, 64);
            this.lbl_Search_Message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Search_Message.Name = "lbl_Search_Message";
            this.lbl_Search_Message.Size = new System.Drawing.Size(0, 13);
            this.lbl_Search_Message.TabIndex = 6;
            // 
            // txt_searchBar
            // 
            this.txt_searchBar.Location = new System.Drawing.Point(4, 44);
            this.txt_searchBar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_searchBar.Name = "txt_searchBar";
            this.txt_searchBar.Size = new System.Drawing.Size(353, 20);
            this.txt_searchBar.TabIndex = 5;
            this.txt_searchBar.Tag = "";
            this.txt_searchBar.Text = "Pesquise um produto";
            this.txt_searchBar.TextChanged += new System.EventHandler(this.txt_searchBar_TextChanged);
            this.txt_searchBar.Enter += new System.EventHandler(this.txt_searchBar_Enter);
            this.txt_searchBar.Leave += new System.EventHandler(this.txt_searchBar_Leave);
            // 
            // btn_openCart
            // 
            this.btn_openCart.BackgroundImage = global::Portal_Compras.Properties.Resources.shopping_cart;
            this.btn_openCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_openCart.FlatAppearance.BorderSize = 0;
            this.btn_openCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openCart.Location = new System.Drawing.Point(331, 3);
            this.btn_openCart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_openCart.Name = "btn_openCart";
            this.btn_openCart.Size = new System.Drawing.Size(24, 23);
            this.btn_openCart.TabIndex = 1;
            this.btn_openCart.UseVisualStyleBackColor = true;
            this.btn_openCart.Click += new System.EventHandler(this.btn_Cart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar produtos";
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Location = new System.Drawing.Point(228, 424);
            this.btn_addToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(126, 24);
            this.btn_addToCart.TabIndex = 3;
            this.btn_addToCart.Text = "Adicionar ao Carrinho";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            // 
            // nud_quanity
            // 
            this.nud_quanity.Location = new System.Drawing.Point(286, 400);
            this.nud_quanity.Margin = new System.Windows.Forms.Padding(2);
            this.nud_quanity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_quanity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quanity.Name = "nud_quanity";
            this.nud_quanity.Size = new System.Drawing.Size(68, 20);
            this.nud_quanity.TabIndex = 2;
            this.nud_quanity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lvw_products
            // 
            this.lvw_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.lvw_products.FullRowSelect = true;
            this.lvw_products.HideSelection = false;
            this.lvw_products.Location = new System.Drawing.Point(4, 68);
            this.lvw_products.Margin = new System.Windows.Forms.Padding(2);
            this.lvw_products.MultiSelect = false;
            this.lvw_products.Name = "lvw_products";
            this.lvw_products.Size = new System.Drawing.Size(353, 328);
            this.lvw_products.TabIndex = 1;
            this.lvw_products.UseCompatibleStateImageBehavior = false;
            this.lvw_products.View = System.Windows.Forms.View.Details;
            this.lvw_products.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvw_products_MouseClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Desconto";
            this.columnHeader4.Width = 61;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tipo";
            this.columnHeader6.Width = 88;
            // 
            // cbb_categoryFilter
            // 
            this.cbb_categoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_categoryFilter.FormattingEnabled = true;
            this.cbb_categoryFilter.Location = new System.Drawing.Point(6, 19);
            this.cbb_categoryFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_categoryFilter.Name = "cbb_categoryFilter";
            this.cbb_categoryFilter.Size = new System.Drawing.Size(106, 21);
            this.cbb_categoryFilter.TabIndex = 0;
            this.cbb_categoryFilter.SelectedIndexChanged += new System.EventHandler(this.cbb_categoryFilter_SelectedIndexChanged);
            // 
            // tp_History
            // 
            this.tp_History.Controls.Add(this.lstvw_history);
            this.tp_History.Controls.Add(this.btn_cancelBuy);
            this.tp_History.Location = new System.Drawing.Point(4, 22);
            this.tp_History.Margin = new System.Windows.Forms.Padding(2);
            this.tp_History.Name = "tp_History";
            this.tp_History.Padding = new System.Windows.Forms.Padding(2);
            this.tp_History.Size = new System.Drawing.Size(359, 453);
            this.tp_History.TabIndex = 1;
            this.tp_History.Text = "Histórico";
            this.tp_History.UseVisualStyleBackColor = true;
            // 
            // lstvw_history
            // 
            this.lstvw_history.HideSelection = false;
            this.lstvw_history.Location = new System.Drawing.Point(5, 4);
            this.lstvw_history.Margin = new System.Windows.Forms.Padding(2);
            this.lstvw_history.Name = "lstvw_history";
            this.lstvw_history.Size = new System.Drawing.Size(349, 416);
            this.lstvw_history.TabIndex = 7;
            this.lstvw_history.UseCompatibleStateImageBehavior = false;
            // 
            // btn_cancelBuy
            // 
            this.btn_cancelBuy.Location = new System.Drawing.Point(259, 424);
            this.btn_cancelBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelBuy.Name = "btn_cancelBuy";
            this.btn_cancelBuy.Size = new System.Drawing.Size(95, 24);
            this.btn_cancelBuy.TabIndex = 1;
            this.btn_cancelBuy.Text = "Cancelar Compra";
            this.btn_cancelBuy.UseVisualStyleBackColor = true;
            // 
            // tp_Profile
            // 
            this.tp_Profile.Controls.Add(this.lbl_NIF);
            this.tp_Profile.Controls.Add(this.lbl_name);
            this.tp_Profile.Controls.Add(this.nud_depositMoney);
            this.tp_Profile.Controls.Add(this.btn_depositMoney);
            this.tp_Profile.Controls.Add(this.lbl_totalBalance);
            this.tp_Profile.Controls.Add(this.lbl_username);
            this.tp_Profile.Controls.Add(this.btn_logout);
            this.tp_Profile.Location = new System.Drawing.Point(4, 22);
            this.tp_Profile.Margin = new System.Windows.Forms.Padding(2);
            this.tp_Profile.Name = "tp_Profile";
            this.tp_Profile.Padding = new System.Windows.Forms.Padding(2);
            this.tp_Profile.Size = new System.Drawing.Size(359, 453);
            this.tp_Profile.TabIndex = 2;
            this.tp_Profile.Text = "Perfil";
            this.tp_Profile.UseVisualStyleBackColor = true;
            // 
            // lbl_NIF
            // 
            this.lbl_NIF.AutoSize = true;
            this.lbl_NIF.Location = new System.Drawing.Point(4, 90);
            this.lbl_NIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NIF.Name = "lbl_NIF";
            this.lbl_NIF.Size = new System.Drawing.Size(24, 13);
            this.lbl_NIF.TabIndex = 7;
            this.lbl_NIF.Text = "NIF";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(4, 45);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            // 
            // nud_depositMoney
            // 
            this.nud_depositMoney.DecimalPlaces = 2;
            this.nud_depositMoney.Location = new System.Drawing.Point(219, 60);
            this.nud_depositMoney.Margin = new System.Windows.Forms.Padding(2);
            this.nud_depositMoney.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_depositMoney.Name = "nud_depositMoney";
            this.nud_depositMoney.Size = new System.Drawing.Size(72, 20);
            this.nud_depositMoney.TabIndex = 5;
            // 
            // btn_depositMoney
            // 
            this.btn_depositMoney.Location = new System.Drawing.Point(219, 82);
            this.btn_depositMoney.Margin = new System.Windows.Forms.Padding(2);
            this.btn_depositMoney.Name = "btn_depositMoney";
            this.btn_depositMoney.Size = new System.Drawing.Size(72, 22);
            this.btn_depositMoney.TabIndex = 4;
            this.btn_depositMoney.Text = "Deposit";
            this.btn_depositMoney.UseVisualStyleBackColor = true;
            // 
            // lbl_totalBalance
            // 
            this.lbl_totalBalance.AutoSize = true;
            this.lbl_totalBalance.Location = new System.Drawing.Point(217, 32);
            this.lbl_totalBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totalBalance.Name = "lbl_totalBalance";
            this.lbl_totalBalance.Size = new System.Drawing.Size(75, 13);
            this.lbl_totalBalance.TabIndex = 1;
            this.lbl_totalBalance.Text = "Saldo total: 0€";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(4, 4);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImage = global::Portal_Compras.Properties.Resources.logout;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(330, 4);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(24, 22);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // cms_LvwProducts
            // 
            this.cms_LvwProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarComoFavToolStripMenuItem});
            this.cms_LvwProducts.Name = "cms_LvwProducts";
            this.cms_LvwProducts.Size = new System.Drawing.Size(206, 26);
            // 
            // adicionarComoFavToolStripMenuItem
            // 
            this.adicionarComoFavToolStripMenuItem.Image = global::Portal_Compras.Properties.Resources.heart;
            this.adicionarComoFavToolStripMenuItem.Name = "adicionarComoFavToolStripMenuItem";
            this.adicionarComoFavToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.adicionarComoFavToolStripMenuItem.Text = "Adicionar como Favorito";
            this.adicionarComoFavToolStripMenuItem.Click += new System.EventHandler(this.adicionarComoFavToolStripMenuItem_Click);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 483);
            this.Controls.Add(this.tc_Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Portal";
            this.Text = "Portal";
            this.Load += new System.EventHandler(this.Portal_Load);
            this.tc_Options.ResumeLayout(false);
            this.tp_Buy.ResumeLayout(false);
            this.tp_Buy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quanity)).EndInit();
            this.tp_History.ResumeLayout(false);
            this.tp_Profile.ResumeLayout(false);
            this.tp_Profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_depositMoney)).EndInit();
            this.cms_LvwProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Options;
        private System.Windows.Forms.TabPage tp_Buy;
        private System.Windows.Forms.TabPage tp_History;
        private System.Windows.Forms.NumericUpDown nud_quanity;
        private System.Windows.Forms.ListView lvw_products;
        private System.Windows.Forms.ComboBox cbb_categoryFilter;
        private System.Windows.Forms.TabPage tp_Profile;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.Button btn_openCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_searchBar;
        private System.Windows.Forms.Label lbl_Search_Message;
        private System.Windows.Forms.ListView lstvw_history;
        private System.Windows.Forms.Button btn_cancelBuy;
        private System.Windows.Forms.Button btn_refreshProducts;
        private System.Windows.Forms.Button btn_addToFavorites;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.NumericUpDown nud_depositMoney;
        private System.Windows.Forms.Button btn_depositMoney;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_totalBalance;
        private System.Windows.Forms.CheckBox chk_showFavorites;
        private System.Windows.Forms.Label lbl_NIF;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip cms_LvwProducts;
        private System.Windows.Forms.ToolStripMenuItem adicionarComoFavToolStripMenuItem;
    }
}