using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
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
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.lbl_Search_Message = new System.Windows.Forms.Label();
            this.tp_History = new System.Windows.Forms.TabPage();
            this.tsp_Open = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_Open = new System.Windows.Forms.ToolStripButton();
            this.tsb_Cancel_Buy = new System.Windows.Forms.ToolStripButton();
            this.lvw_history = new System.Windows.Forms.ListView();
            this.ch_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Total_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_Profile = new System.Windows.Forms.TabPage();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_NIF = new System.Windows.Forms.Label();
            this.nud_depositMoney = new System.Windows.Forms.NumericUpDown();
            this.btn_depositMoney = new System.Windows.Forms.Button();
            this.lbl_totalBalance = new System.Windows.Forms.Label();
            this.ts_Options = new System.Windows.Forms.ToolStrip();
            this.tsddb_Ver = new System.Windows.Forms.ToolStripDropDownButton();
            this.cms_LvwProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adicionarComoFavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsmi_List = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsm_Icons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_refreshProducts = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.iml_ListView = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tc_Options.SuspendLayout();
            this.tp_Buy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            this.tp_History.SuspendLayout();
            this.tsp_Open.SuspendLayout();
            this.tp_Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_depositMoney)).BeginInit();
            this.cms_LvwProducts.SuspendLayout();
            this.pnl_TopBar.SuspendLayout();
            this.SuspendLayout();
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
            this.tp_Buy.Controls.Add(this.btn_addToCart);
            this.tp_Buy.Controls.Add(this.lbl_Search_Message);
            this.tp_Buy.Location = new System.Drawing.Point(4, 32);
            this.tp_Buy.Name = "tp_Buy";
            this.tp_Buy.Size = new System.Drawing.Size(672, 444);
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
            this.cbb_categoryFilter.Size = new System.Drawing.Size(150, 31);
            this.cbb_categoryFilter.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cbb_categoryFilter, "Filtrar os produtos por categoria");
            this.cbb_categoryFilter.SelectedIndexChanged += new System.EventHandler(this.cbb_categoryFilter_SelectedIndexChanged);
            // 
            // txt_searchBar
            // 
            this.txt_searchBar.Location = new System.Drawing.Point(170, 35);
            this.txt_searchBar.Name = "txt_searchBar";
            this.txt_searchBar.Size = new System.Drawing.Size(300, 30);
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
            this.chk_showFavorites.Size = new System.Drawing.Size(30, 25);
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
            this.btn_openCart.Size = new System.Drawing.Size(34, 34);
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
            this.nud_Quantity.Location = new System.Drawing.Point(436, 375);
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
            this.nud_Quantity.Size = new System.Drawing.Size(214, 30);
            this.nud_Quantity.TabIndex = 6;
            this.nud_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.nud_Quantity, "Quantidade do um produto que pretende adicionar ao carrinho");
            this.nud_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Location = new System.Drawing.Point(436, 406);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(214, 30);
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
            this.lbl_Search_Message.Size = new System.Drawing.Size(0, 23);
            this.lbl_Search_Message.TabIndex = 9;
            // 
            // tp_History
            // 
            this.tp_History.BackColor = System.Drawing.Color.White;
            this.tp_History.Controls.Add(this.tsp_Open);
            this.tp_History.Controls.Add(this.lvw_history);
            this.tp_History.Location = new System.Drawing.Point(4, 25);
            this.tp_History.Name = "tp_History";
            this.tp_History.Size = new System.Drawing.Size(672, 451);
            this.tp_History.TabIndex = 1;
            this.tp_History.Text = "Histórico";
            // 
            // tsp_Open
            // 
            this.tsp_Open.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsp_Open.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tsb_Open,
            this.tsb_Cancel_Buy});
            this.tsp_Open.Location = new System.Drawing.Point(0, 0);
            this.tsp_Open.Name = "tsp_Open";
            this.tsp_Open.Size = new System.Drawing.Size(672, 27);
            this.tsp_Open.TabIndex = 9;
            this.tsp_Open.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButton1.Image = global::Portal_Compras.Properties.Resources.view_list;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(64, 24);
            this.toolStripDropDownButton1.Text = "Ver";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 26);
            this.toolStripMenuItem1.Text = "Lista";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ltsmi_List_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 26);
            this.toolStripMenuItem2.Text = "ícones";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ltsm_Icons_Click);
            // 
            // tsb_Open
            // 
            this.tsb_Open.Enabled = false;
            this.tsb_Open.Image = global::Portal_Compras.Properties.Resources.share;
            this.tsb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Open.Name = "tsb_Open";
            this.tsb_Open.Size = new System.Drawing.Size(66, 24);
            this.tsb_Open.Text = "Abrir";
            this.tsb_Open.Click += new System.EventHandler(this.tsb_Open_Click);
            // 
            // tsb_Cancel_Buy
            // 
            this.tsb_Cancel_Buy.Enabled = false;
            this.tsb_Cancel_Buy.Image = global::Portal_Compras.Properties.Resources.close;
            this.tsb_Cancel_Buy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Cancel_Buy.Name = "tsb_Cancel_Buy";
            this.tsb_Cancel_Buy.Size = new System.Drawing.Size(147, 24);
            this.tsb_Cancel_Buy.Text = "Cancelar Compra";
            this.tsb_Cancel_Buy.Click += new System.EventHandler(this.tsb_Cancel_Buy_Click);
            // 
            // lvw_history
            // 
            this.lvw_history.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Number,
            this.ch_Date,
            this.ch_Total_Price});
            this.lvw_history.FullRowSelect = true;
            this.lvw_history.HideSelection = false;
            this.lvw_history.Location = new System.Drawing.Point(1, 29);
            this.lvw_history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvw_history.Name = "lvw_history";
            this.lvw_history.Size = new System.Drawing.Size(667, 419);
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
            // tp_Profile
            // 
            this.tp_Profile.BackColor = System.Drawing.Color.White;
            this.tp_Profile.Controls.Add(this.label2);
            this.tp_Profile.Controls.Add(this.lbl_username);
            this.tp_Profile.Controls.Add(this.lbl_name);
            this.tp_Profile.Controls.Add(this.lbl_NIF);
            this.tp_Profile.Controls.Add(this.nud_depositMoney);
            this.tp_Profile.Controls.Add(this.btn_depositMoney);
            this.tp_Profile.Location = new System.Drawing.Point(4, 32);
            this.tp_Profile.Name = "tp_Profile";
            this.tp_Profile.Size = new System.Drawing.Size(672, 444);
            this.tp_Profile.TabIndex = 2;
            this.tp_Profile.Text = "Perfil";
            // 
            // lbl_username
            // 
            this.lbl_username.Location = new System.Drawing.Point(10, 32);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(301, 23);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username: ";
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(10, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(301, 23);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nome completo: ";
            // 
            // lbl_NIF
            // 
            this.lbl_NIF.Location = new System.Drawing.Point(10, 55);
            this.lbl_NIF.Name = "lbl_NIF";
            this.lbl_NIF.Size = new System.Drawing.Size(301, 23);
            this.lbl_NIF.TabIndex = 2;
            this.lbl_NIF.Text = "NIF:";
            // 
            // nud_depositMoney
            // 
            this.nud_depositMoney.DecimalPlaces = 2;
            this.nud_depositMoney.Location = new System.Drawing.Point(14, 126);
            this.nud_depositMoney.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_depositMoney.Name = "nud_depositMoney";
            this.nud_depositMoney.Size = new System.Drawing.Size(80, 30);
            this.nud_depositMoney.TabIndex = 4;
            // 
            // btn_depositMoney
            // 
            this.btn_depositMoney.Location = new System.Drawing.Point(14, 162);
            this.btn_depositMoney.Name = "btn_depositMoney";
            this.btn_depositMoney.Size = new System.Drawing.Size(80, 30);
            this.btn_depositMoney.TabIndex = 5;
            this.btn_depositMoney.Text = "Depositar";
            this.btn_depositMoney.Click += new System.EventHandler(this.btn_depositMoney_Click);
            // 
            // lbl_totalBalance
            // 
            this.lbl_totalBalance.AutoSize = true;
            this.lbl_totalBalance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_totalBalance.ForeColor = System.Drawing.Color.White;
            this.lbl_totalBalance.Location = new System.Drawing.Point(224, 14);
            this.lbl_totalBalance.Name = "lbl_totalBalance";
            this.lbl_totalBalance.Size = new System.Drawing.Size(171, 32);
            this.lbl_totalBalance.TabIndex = 3;
            this.lbl_totalBalance.Text = "Saldo total: 0€";
            // 
            // ts_Options
            // 
            this.ts_Options.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_Options.Location = new System.Drawing.Point(0, 0);
            this.ts_Options.Name = "ts_Options";
            this.ts_Options.Size = new System.Drawing.Size(100, 25);
            this.ts_Options.TabIndex = 0;
            // 
            // tsddb_Ver
            // 
            this.tsddb_Ver.Name = "tsddb_Ver";
            this.tsddb_Ver.Size = new System.Drawing.Size(23, 23);
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
            // btn_refreshProducts
            // 
            this.btn_refreshProducts.BackgroundImage = global::Portal_Compras.Properties.Resources.refresh__1_;
            this.btn_refreshProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refreshProducts.FlatAppearance.BorderSize = 0;
            this.btn_refreshProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshProducts.Location = new System.Drawing.Point(184, 15);
            this.btn_refreshProducts.Name = "btn_refreshProducts";
            this.btn_refreshProducts.Size = new System.Drawing.Size(25, 24);
            this.btn_refreshProducts.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_refreshProducts, "Atualizar a página");
            this.btn_refreshProducts.Click += new System.EventHandler(this.btn_refreshProducts_Click);
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
            // pnl_TopBar
            // 
            this.pnl_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.pnl_TopBar.Controls.Add(this.lbl_Title);
            this.pnl_TopBar.Controls.Add(this.btn_logout);
            this.pnl_TopBar.Controls.Add(this.btn_refreshProducts);
            this.pnl_TopBar.Controls.Add(this.lbl_totalBalance);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(700, 50);
            this.pnl_TopBar.TabIndex = 2;
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
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // iml_ListView
            // 
            this.iml_ListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml_ListView.ImageStream")));
            this.iml_ListView.TransparentColor = System.Drawing.Color.Transparent;
            this.iml_ListView.Images.SetKeyName(0, "receipt.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atualizar Saldo";
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
            this.tc_Options.ResumeLayout(false);
            this.tp_Buy.ResumeLayout(false);
            this.tp_Buy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            this.tp_History.ResumeLayout(false);
            this.tp_History.PerformLayout();
            this.tsp_Open.ResumeLayout(false);
            this.tsp_Open.PerformLayout();
            this.tp_Profile.ResumeLayout(false);
            this.tp_Profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_depositMoney)).EndInit();
            this.cms_LvwProducts.ResumeLayout(false);
            this.pnl_TopBar.ResumeLayout(false);
            this.pnl_TopBar.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        // =================================
        // Declaração de todos os controles
        // =================================
        private System.Windows.Forms.TabControl tc_Options;
        private System.Windows.Forms.TabPage tp_Buy;
        private System.Windows.Forms.TabPage tp_History;
        private System.Windows.Forms.ToolStrip ts_Options;
        private System.Windows.Forms.ToolStripDropDownButton tsddb_Ver;
        private System.Windows.Forms.ListView lvw_history;
        private System.Windows.Forms.ColumnHeader ch_Number;
        private System.Windows.Forms.ColumnHeader ch_Date;
        private System.Windows.Forms.ColumnHeader ch_Total_Price;
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

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_NIF;
        private System.Windows.Forms.Label lbl_totalBalance;
        private System.Windows.Forms.NumericUpDown nud_depositMoney;
        private System.Windows.Forms.Button btn_depositMoney;

        private System.Windows.Forms.ContextMenuStrip cms_LvwProducts;
        private System.Windows.Forms.ToolStripMenuItem adicionarComoFavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ltsmi_List;
        private System.Windows.Forms.ToolStripMenuItem ltsm_Icons;
        private System.Windows.Forms.ToolTip toolTip1;
        private ToolStrip tsp_Open;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Button btn_logout;
        private Label lbl_Title;
        private Panel pnl_TopBar;
        private ToolStripButton tsb_Cancel_Buy;
        private ToolStripButton tsb_Open;
        private ImageList iml_ListView;
        private Label label2;
    }
}
