namespace Portal_Compras
{
    partial class Portal
    {
        private System.ComponentModel.IContainer components = null;

        // Disposer
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
            this.components = new System.ComponentModel.Container();
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tc_Options = new System.Windows.Forms.TabControl();
            this.tp_Buy = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_categoryFilter = new System.Windows.Forms.ComboBox();
            this.txt_searchBar = new System.Windows.Forms.TextBox();
            this.chk_showFavorites = new System.Windows.Forms.CheckBox();
            this.btn_openCart = new System.Windows.Forms.Button();
            this.lvw_products = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nud_Quantity = new System.Windows.Forms.NumericUpDown();
            this.btn_refreshProducts = new System.Windows.Forms.Button();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.lbl_Search_Message = new System.Windows.Forms.Label();
            this.tp_History = new System.Windows.Forms.TabPage();
            this.ts_Options = new System.Windows.Forms.ToolStrip();
            this.tsddb_Ver = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsb_Open = new System.Windows.Forms.ToolStripButton();
            this.tsb_Cancel_Buy = new System.Windows.Forms.ToolStripButton();
            this.lvw_history = new System.Windows.Forms.ListView();
            this.ch_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Total_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_cancelBuy = new System.Windows.Forms.Button();
            this.tp_Profile = new System.Windows.Forms.TabPage();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_NIF = new System.Windows.Forms.Label();
            this.lbl_totalBalance = new System.Windows.Forms.Label();
            this.nud_depositMoney = new System.Windows.Forms.NumericUpDown();
            this.btn_depositMoney = new System.Windows.Forms.Button();
            this.cms_LvwProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adicionarComoFavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsmi_List = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsm_Icons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_TopBar.SuspendLayout();
            this.tc_Options.SuspendLayout();
            this.tp_Buy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            this.tp_History.SuspendLayout();
            this.ts_Options.SuspendLayout();
            this.tp_Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_depositMoney)).BeginInit();
            this.cms_LvwProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TopBar
            // 
            this.pnl_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.pnl_TopBar.Controls.Add(this.lbl_Title);
            this.pnl_TopBar.Controls.Add(this.btn_logout);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(700, 50);
            this.pnl_TopBar.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(10, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(174, 50);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Portal de Compras";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_logout
            // 
            this.btn_logout.BackgroundImage = global::Portal_Compras.Properties.Resources.logout;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(654, 9);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(28, 33);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // tc_Options
            // 
            this.tc_Options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_Options.Controls.Add(this.tp_Buy);
            this.tc_Options.Controls.Add(this.tp_History);
            this.tc_Options.Controls.Add(this.tp_Profile);
            this.tc_Options.Location = new System.Drawing.Point(10, 60);
            this.tc_Options.Name = "tc_Options";
            this.tc_Options.SelectedIndex = 0;
            this.tc_Options.Size = new System.Drawing.Size(680, 480);
            this.tc_Options.TabIndex = 0;
            this.tc_Options.SelectedIndexChanged += new System.EventHandler(this.tc_Options_SelectedIndexChanged);
            this.tc_Options.TabIndexChanged += new System.EventHandler(this.tc_Options_TabIndexChanged);

            // 
            // tp_Buy
            // 
            this.tp_Buy.BackColor = System.Drawing.Color.White;
            this.tp_Buy.Controls.Add(this.label1);
            this.tp_Buy.Controls.Add(this.cbb_categoryFilter);
            this.tp_Buy.Controls.Add(this.txt_searchBar);
            this.tp_Buy.Controls.Add(this.chk_showFavorites);
            this.tp_Buy.Controls.Add(this.btn_openCart);
            this.tp_Buy.Controls.Add(this.lvw_products);
            this.tp_Buy.Controls.Add(this.nud_Quantity);
            this.tp_Buy.Controls.Add(this.btn_refreshProducts);
            this.tp_Buy.Controls.Add(this.btn_addToCart);
            this.tp_Buy.Controls.Add(this.lbl_Search_Message);
            this.tp_Buy.Location = new System.Drawing.Point(4, 26);
            this.tp_Buy.Name = "tp_Buy";
            this.tp_Buy.Size = new System.Drawing.Size(672, 450);
            this.tp_Buy.TabIndex = 0;
            this.tp_Buy.Text = "Compras";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar produtos:";
            // 
            // cbb_categoryFilter
            // 
            this.cbb_categoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_categoryFilter.Location = new System.Drawing.Point(10, 35);
            this.cbb_categoryFilter.Name = "cbb_categoryFilter";
            this.cbb_categoryFilter.Size = new System.Drawing.Size(150, 25);
            this.cbb_categoryFilter.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cbb_categoryFilter, "Filtrar os produtos por categoria");
            this.cbb_categoryFilter.SelectedIndexChanged += new System.EventHandler(this.cbb_categoryFilter_SelectedIndexChanged);
            // 
            // txt_searchBar
            // 
            this.txt_searchBar.Location = new System.Drawing.Point(170, 35);
            this.txt_searchBar.Name = "txt_searchBar";
            this.txt_searchBar.Size = new System.Drawing.Size(300, 25);
            this.txt_searchBar.TabIndex = 2;
            this.txt_searchBar.Text = "Procure pelo nome do produto";
            this.txt_searchBar.TextChanged += new System.EventHandler(this.txt_searchBar_TextChanged);
            this.txt_searchBar.Enter += new System.EventHandler(this.txt_searchBar_Enter);
            this.txt_searchBar.Leave += new System.EventHandler(this.txt_searchBar_Leave);
            // 
            // chk_showFavorites
            // 
            this.chk_showFavorites.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_showFavorites.BackgroundImage = global::Portal_Compras.Properties.Resources.heart;
            this.chk_showFavorites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chk_showFavorites.FlatAppearance.BorderSize = 0;
            this.chk_showFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_showFavorites.Location = new System.Drawing.Point(480, 35);
            this.chk_showFavorites.Name = "chk_showFavorites";
            this.chk_showFavorites.Size = new System.Drawing.Size(30, 30);
            this.chk_showFavorites.TabIndex = 3;
            this.toolTip1.SetToolTip(this.chk_showFavorites, "Ver apenas os seus produtos favoritos");
            this.chk_showFavorites.CheckedChanged += new System.EventHandler(this.chk_showFavorites_CheckedChanged);
            // 
            // btn_openCart
            // 
            this.btn_openCart.BackgroundImage = global::Portal_Compras.Properties.Resources.shopping_cart;
            this.btn_openCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_openCart.FlatAppearance.BorderSize = 0;
            this.btn_openCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openCart.Location = new System.Drawing.Point(516, 30);
            this.btn_openCart.Name = "btn_openCart";
            this.btn_openCart.Size = new System.Drawing.Size(40, 40);
            this.btn_openCart.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_openCart, "Carrinho");
            this.btn_openCart.Click += new System.EventHandler(this.btn_Cart_Click);
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
            this.lvw_products.Location = new System.Drawing.Point(10, 70);
            this.lvw_products.Name = "lvw_products";
            this.lvw_products.Size = new System.Drawing.Size(640, 300);
            this.lvw_products.TabIndex = 5;
            this.lvw_products.UseCompatibleStateImageBehavior = false;
            this.lvw_products.View = System.Windows.Forms.View.Details;
            this.lvw_products.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvw_products_MouseClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Desconto";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tipo";
            this.columnHeader6.Width = 130;
            // 
            // nud_Quantity
            // 
            this.nud_Quantity.Location = new System.Drawing.Point(537, 375);
            this.nud_Quantity.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nud_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Quantity.Name = "nud_Quantity";
            this.nud_Quantity.Size = new System.Drawing.Size(113, 25);
            this.nud_Quantity.TabIndex = 6;
            this.nud_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.nud_Quantity, "Quantidade do um produto que pretende adicionar ao carrinho");
            this.nud_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_refreshProducts
            // 
            this.btn_refreshProducts.BackgroundImage = global::Portal_Compras.Properties.Resources.refresh;
            this.btn_refreshProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refreshProducts.FlatAppearance.BorderSize = 0;
            this.btn_refreshProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshProducts.Location = new System.Drawing.Point(10, 379);
            this.btn_refreshProducts.Name = "btn_refreshProducts";
            this.btn_refreshProducts.Size = new System.Drawing.Size(31, 32);
            this.btn_refreshProducts.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_refreshProducts, "Atualizar a página");
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Location = new System.Drawing.Point(480, 406);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(170, 30);
            this.btn_addToCart.TabIndex = 8;
            this.btn_addToCart.Text = "Adicionar ao Carrinho";
            this.toolTip1.SetToolTip(this.btn_addToCart, "Adicionar o produto ao carrinho");
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // lbl_Search_Message
            // 
            this.lbl_Search_Message.AutoSize = true;
            this.lbl_Search_Message.Location = new System.Drawing.Point(10, 55);
            this.lbl_Search_Message.Name = "lbl_Search_Message";
            this.lbl_Search_Message.Size = new System.Drawing.Size(0, 19);
            this.lbl_Search_Message.TabIndex = 9;
            // 
            // tp_History
            // 
            this.tp_History.BackColor = System.Drawing.Color.White;
            this.tp_History.Controls.Add(this.lstvw_history);
            this.tp_History.Controls.Add(this.btn_cancelBuy);
            this.tp_History.Location = new System.Drawing.Point(4, 26);
            this.tp_History.Name = "tp_History";
            this.tp_History.Size = new System.Drawing.Size(672, 450);
            this.tp_History.TabIndex = 1;
            this.tp_History.Text = "Histórico";
            // 
            // tsb_Cancel_Buy
            // 
            this.lstvw_history.HideSelection = false;
            this.lstvw_history.Location = new System.Drawing.Point(10, 10);
            this.lstvw_history.Name = "lstvw_history";
            this.lstvw_history.Size = new System.Drawing.Size(640, 390);
            this.lstvw_history.TabIndex = 0;
            this.lstvw_history.UseCompatibleStateImageBehavior = false;
            // 
            // lvw_history
            // 
            this.lvw_history.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Number,
            this.ch_Date,
            this.ch_Total_Price});
            this.lvw_history.FullRowSelect = true;
            this.lvw_history.HideSelection = false;
            this.lvw_history.Location = new System.Drawing.Point(7, 28);
            this.lvw_history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvw_history.Name = "lvw_history";
            this.lvw_history.Size = new System.Drawing.Size(464, 488);
            this.lvw_history.TabIndex = 7;
            this.lvw_history.UseCompatibleStateImageBehavior = false;
            this.lvw_history.View = System.Windows.Forms.View.Details;
            this.lvw_history.SelectedIndexChanged += new System.EventHandler(this.lvw_history_SelectedIndexChanged);
            this.lvw_history.Click += new System.EventHandler(this.lvw_history_Click);
            this.lvw_history.DoubleClick += new System.EventHandler(this.lvw_history_DoubleClick);
            // 
            // ch_Number
            // 
            this.ch_Number.Text = "Número";
            this.ch_Number.Width = 94;
            // 
            // ch_Date
            // 
            this.ch_Date.Text = "Data da Compra";
            this.ch_Date.Width = 133;
            // 
            // ch_Total_Price
            // 
            this.ch_Total_Price.Text = "Preço Total";
            this.ch_Total_Price.Width = 103;
            // 
            // btn_cancelBuy
            // 
            this.btn_cancelBuy.Location = new System.Drawing.Point(520, 410);
            this.btn_cancelBuy.Name = "btn_cancelBuy";
            this.btn_cancelBuy.Size = new System.Drawing.Size(130, 30);
            this.btn_cancelBuy.TabIndex = 1;
            this.btn_cancelBuy.Text = "Cancelar Compra";
            // 
            // tp_Profile
            // 
            this.tp_Profile.BackColor = System.Drawing.Color.White;
            this.tp_Profile.Controls.Add(this.lbl_username);
            this.tp_Profile.Controls.Add(this.lbl_name);
            this.tp_Profile.Controls.Add(this.lbl_NIF);
            this.tp_Profile.Controls.Add(this.lbl_totalBalance);
            this.tp_Profile.Controls.Add(this.nud_depositMoney);
            this.tp_Profile.Controls.Add(this.btn_depositMoney);
            this.tp_Profile.Location = new System.Drawing.Point(4, 26);
            this.tp_Profile.Name = "tp_Profile";
            this.tp_Profile.Size = new System.Drawing.Size(672, 450);
            this.tp_Profile.TabIndex = 2;
            this.tp_Profile.Text = "Perfil";
            // 
            // lbl_username
            // 
            this.lbl_username.Location = new System.Drawing.Point(10, 10);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(100, 23);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username: ";
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(10, 40);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 23);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nome completo: ";
            // 
            // lbl_NIF
            // 
            this.lbl_NIF.Location = new System.Drawing.Point(10, 70);
            this.lbl_NIF.Name = "lbl_NIF";
            this.lbl_NIF.Size = new System.Drawing.Size(100, 23);
            this.lbl_NIF.TabIndex = 2;
            this.lbl_NIF.Text = "NIF:";
            // 
            // lbl_totalBalance
            // 
            this.lbl_totalBalance.BackColor = System.Drawing.Color.White;
            this.lbl_totalBalance.Location = new System.Drawing.Point(220, 10);
            this.lbl_totalBalance.Name = "lbl_totalBalance";
            this.lbl_totalBalance.Size = new System.Drawing.Size(100, 23);
            this.lbl_totalBalance.TabIndex = 3;
            this.lbl_totalBalance.Text = "Saldo total: 0€";
            // 
            // nud_depositMoney
            // 
            this.nud_depositMoney.DecimalPlaces = 2;
            this.nud_depositMoney.Location = new System.Drawing.Point(220, 40);
            this.nud_depositMoney.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_depositMoney.Name = "nud_depositMoney";
            this.nud_depositMoney.Size = new System.Drawing.Size(80, 25);
            this.nud_depositMoney.TabIndex = 4;
            // 
            // btn_depositMoney
            // 
            this.btn_depositMoney.Location = new System.Drawing.Point(220, 70);
            this.btn_depositMoney.Name = "btn_depositMoney";
            this.btn_depositMoney.Size = new System.Drawing.Size(80, 30);
            this.btn_depositMoney.TabIndex = 5;
            this.btn_depositMoney.Text = "Depositar";
            this.btn_depositMoney.Click += new System.EventHandler(this.btn_depositMoney_Click);
            // 
            // cms_LvwProducts
            // 
            this.cms_LvwProducts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_LvwProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarComoFavToolStripMenuItem});
            this.cms_LvwProducts.Name = "cms_LvwProducts";
            this.cms_LvwProducts.Size = new System.Drawing.Size(246, 30);
            // 
            // adicionarComoFavToolStripMenuItem
            // 
            this.adicionarComoFavToolStripMenuItem.Image = global::Portal_Compras.Properties.Resources.heart;
            this.adicionarComoFavToolStripMenuItem.Name = "adicionarComoFavToolStripMenuItem";
            this.adicionarComoFavToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.adicionarComoFavToolStripMenuItem.Text = "Adicionar como Favorito";
            this.adicionarComoFavToolStripMenuItem.Click += new System.EventHandler(this.adicionarComoFavToolStripMenuItem_Click);
            // 
            // ltsmi_List
            // 
            this.ltsmi_List.Name = "ltsmi_List";
            this.ltsmi_List.Size = new System.Drawing.Size(224, 26);
            this.ltsmi_List.Text = "Lista";
            this.ltsmi_List.Click += new System.EventHandler(this.ltsmi_List_Click);
            // 
            // ltsm_Icons
            // 
            this.ltsm_Icons.Name = "ltsm_Icons";
            this.ltsm_Icons.Size = new System.Drawing.Size(224, 26);
            this.ltsm_Icons.Text = "ícones";
            this.ltsm_Icons.Click += new System.EventHandler(this.ltsm_Icons_Click);
            // 
            // Portal
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.tc_Options);
            this.Controls.Add(this.pnl_TopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Portal";
            this.Text = "Portal de Compras";
            this.pnl_TopBar.ResumeLayout(false);
            this.tc_Options.ResumeLayout(false);
            this.tp_Buy.ResumeLayout(false);
            this.tp_Buy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            this.tp_History.ResumeLayout(false);
            this.tp_History.PerformLayout();
            this.ts_Options.ResumeLayout(false);
            this.ts_Options.PerformLayout();
            this.tp_Profile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_depositMoney)).EndInit();
            this.cms_LvwProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        // =================================
        // Declaração de todos os controles
        // =================================
        private System.Windows.Forms.TabControl tc_Options;
        private System.Windows.Forms.TabPage tp_Buy;
        private System.Windows.Forms.TabPage tp_History;
        private System.Windows.Forms.TabPage tp_Profile;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_categoryFilter;
        private System.Windows.Forms.TextBox txt_searchBar;
        private System.Windows.Forms.CheckBox chk_showFavorites;
        private System.Windows.Forms.ListView lvw_products;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.NumericUpDown nud_Quantity;
        private System.Windows.Forms.Button btn_refreshProducts;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.Button btn_openCart;
        private System.Windows.Forms.Label lbl_Search_Message;

        private System.Windows.Forms.ListView lstvw_history;
        private System.Windows.Forms.Button btn_cancelBuy;

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_NIF;
        private System.Windows.Forms.Label lbl_totalBalance;
        private System.Windows.Forms.NumericUpDown nud_depositMoney;
        private System.Windows.Forms.Button btn_depositMoney;
        private System.Windows.Forms.Button btn_logout;

        private System.Windows.Forms.ContextMenuStrip cms_LvwProducts;
        private System.Windows.Forms.ToolStripMenuItem adicionarComoFavToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnl_TopBar;
        private System.Windows.Forms.Label lbl_Title;
    }
}
