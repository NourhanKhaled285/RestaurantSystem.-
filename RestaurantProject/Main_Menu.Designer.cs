namespace RestaurantProject
{
    partial class Main_Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Grd_Menu = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_Menu = new System.Windows.Forms.TabControl();
            this.tabCust_Info = new System.Windows.Forms.TabPage();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.cmb_Area = new System.Windows.Forms.ComboBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_premium = new System.Windows.Forms.Label();
            this.pnl_premium = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Finalprice = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.pnl_db = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_dbPhone = new System.Windows.Forms.Label();
            this.lbl_dbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_dbID = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.Grd_Cart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteMeal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_rec = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowpnlRec = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.tab_prev = new System.Windows.Forms.TabPage();
            this.flwPrevPanal = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Menu)).BeginInit();
            this.tab_Menu.SuspendLayout();
            this.tabCust_Info.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCart.SuspendLayout();
            this.pnl_premium.SuspendLayout();
            this.pnl_db.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Cart)).BeginInit();
            this.tab_rec.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_prev.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grd_Menu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 10.20895F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.Grd_Menu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_Menu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grd_Menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grd_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Meal,
            this.Price,
            this.Description,
            this.qty,
            this.Select});
            this.Grd_Menu.GridColor = System.Drawing.SystemColors.Control;
            this.Grd_Menu.Location = new System.Drawing.Point(32, 71);
            this.Grd_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grd_Menu.Name = "Grd_Menu";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 10.20895F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grd_Menu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_Menu.RowTemplate.Height = 24;
            this.Grd_Menu.Size = new System.Drawing.Size(871, 476);
            this.Grd_Menu.TabIndex = 0;
            this.Grd_Menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Meal
            // 
            this.Meal.HeaderText = "Meal";
            this.Meal.Name = "Meal";
            this.Meal.ReadOnly = true;
            this.Meal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Meal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Meal.Width = 200;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 400;
            // 
            // qty
            // 
            this.qty.HeaderText = "quantity";
            this.qty.MaxDropDownItems = 50;
            this.qty.Name = "qty";
            this.qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Select
            // 
            this.Select.HeaderText = "Add";
            this.Select.Name = "Select";
            this.Select.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(287, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurant Menu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(351, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tab_Menu
            // 
            this.tab_Menu.Controls.Add(this.tabCust_Info);
            this.tab_Menu.Controls.Add(this.tabMenu);
            this.tab_Menu.Controls.Add(this.tabCart);
            this.tab_Menu.Controls.Add(this.tab_rec);
            this.tab_Menu.Controls.Add(this.tab_prev);
            this.tab_Menu.Font = new System.Drawing.Font("Monotype Corsiva", 11.8209F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Menu.Location = new System.Drawing.Point(0, 0);
            this.tab_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Menu.Name = "tab_Menu";
            this.tab_Menu.SelectedIndex = 0;
            this.tab_Menu.Size = new System.Drawing.Size(942, 799);
            this.tab_Menu.TabIndex = 4;
            // 
            // tabCust_Info
            // 
            this.tabCust_Info.AccessibleName = "tabCustInfo";
            this.tabCust_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCust_Info.BackgroundImage")));
            this.tabCust_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCust_Info.Controls.Add(this.txt_Address);
            this.tabCust_Info.Controls.Add(this.btn_Start);
            this.tabCust_Info.Controls.Add(this.cmb_Area);
            this.tabCust_Info.Controls.Add(this.txt_Phone);
            this.tabCust_Info.Location = new System.Drawing.Point(4, 33);
            this.tabCust_Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCust_Info.Name = "tabCust_Info";
            this.tabCust_Info.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCust_Info.Size = new System.Drawing.Size(934, 762);
            this.tabCust_Info.TabIndex = 2;
            this.tabCust_Info.Text = "Your Info";
            this.tabCust_Info.UseVisualStyleBackColor = true;
            // 
            // txt_Address
            // 
            this.txt_Address.AutoCompleteCustomSource.AddRange(new string[] {
            "011185689723"});
            this.txt_Address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Address.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(32, 190);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(231, 42);
            this.txt_Address.TabIndex = 9;
            this.txt_Address.Text = "Address";
            this.txt_Address.Click += new System.EventHandler(this.txt_Address_Click);
            this.txt_Address.MouseEnter += new System.EventHandler(this.txt_Address_MouseEnter);
            this.txt_Address.MouseLeave += new System.EventHandler(this.txt_Address_MouseLeave);
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(95, 314);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(178, 50);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "Order Now";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // cmb_Area
            // 
            this.cmb_Area.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Area.FormattingEnabled = true;
            this.cmb_Area.Items.AddRange(new object[] {
            "Abbaseya",
            "El_Obour",
            "El-Shrouk",
            "El-Zayton",
            "El_Rehab",
            "Heliopolis",
            "Madinty",
            "Madint Nasr"});
            this.cmb_Area.Location = new System.Drawing.Point(269, 187);
            this.cmb_Area.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Area.Name = "cmb_Area";
            this.cmb_Area.Size = new System.Drawing.Size(231, 45);
            this.cmb_Area.TabIndex = 7;
            this.cmb_Area.Text = "Enter Your Area";
            // 
            // txt_Phone
            // 
            this.txt_Phone.AutoCompleteCustomSource.AddRange(new string[] {
            "011185689723"});
            this.txt_Phone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Phone.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(32, 90);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(231, 42);
            this.txt_Phone.TabIndex = 6;
            this.txt_Phone.Text = "Phone Number";
            this.txt_Phone.MouseEnter += new System.EventHandler(this.txt_Phone_MouseEnter);
            this.txt_Phone.MouseLeave += new System.EventHandler(this.txt_Phone_MouseLeave);
            // 
            // tabMenu
            // 
            this.tabMenu.AccessibleName = "tabMenu";
            this.tabMenu.Controls.Add(this.flowLayoutPanel1);
            this.tabMenu.Controls.Add(this.Grd_Menu);
            this.tabMenu.Controls.Add(this.button1);
            this.tabMenu.Controls.Add(this.label1);
            this.tabMenu.Location = new System.Drawing.Point(4, 33);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMenu.Size = new System.Drawing.Size(934, 762);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 71);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(924, 640);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 142);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(610, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 38);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total Price : ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(729, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add To Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 38);
            this.label8.TabIndex = 10;
            this.label8.Text = "Price";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(752, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 32);
            this.comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Price : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabCart
            // 
            this.tabCart.AccessibleName = "tabCart";
            this.tabCart.Controls.Add(this.button3);
            this.tabCart.Controls.Add(this.lbl_premium);
            this.tabCart.Controls.Add(this.pnl_premium);
            this.tabCart.Controls.Add(this.pnl_db);
            this.tabCart.Controls.Add(this.lbl_Total);
            this.tabCart.Controls.Add(this.Grd_Cart);
            this.tabCart.Controls.Add(this.btn_Order);
            this.tabCart.Controls.Add(this.label2);
            this.tabCart.Location = new System.Drawing.Point(4, 33);
            this.tabCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCart.Size = new System.Drawing.Size(934, 762);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "cart";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::RestaurantProject.Properties.Resources.cancel;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(46, 644);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 46);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_premium
            // 
            this.lbl_premium.AutoSize = true;
            this.lbl_premium.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_premium.Location = new System.Drawing.Point(714, 6);
            this.lbl_premium.Name = "lbl_premium";
            this.lbl_premium.Size = new System.Drawing.Size(165, 38);
            this.lbl_premium.TabIndex = 22;
            this.lbl_premium.Text = "**Premium**";
            this.lbl_premium.Visible = false;
            // 
            // pnl_premium
            // 
            this.pnl_premium.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_premium.Controls.Add(this.label7);
            this.pnl_premium.Controls.Add(this.label4);
            this.pnl_premium.Controls.Add(this.lbl_Finalprice);
            this.pnl_premium.Controls.Add(this.lbl_discount);
            this.pnl_premium.Location = new System.Drawing.Point(671, 153);
            this.pnl_premium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_premium.Name = "pnl_premium";
            this.pnl_premium.Size = new System.Drawing.Size(257, 148);
            this.pnl_premium.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 38);
            this.label7.TabIndex = 19;
            this.label7.Text = "Final Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "Discount :";
            // 
            // lbl_Finalprice
            // 
            this.lbl_Finalprice.AutoSize = true;
            this.lbl_Finalprice.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Finalprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Finalprice.Location = new System.Drawing.Point(157, 82);
            this.lbl_Finalprice.Name = "lbl_Finalprice";
            this.lbl_Finalprice.Size = new System.Drawing.Size(83, 38);
            this.lbl_Finalprice.TabIndex = 18;
            this.lbl_Finalprice.Text = "Final ";
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_discount.Location = new System.Drawing.Point(146, 7);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(109, 38);
            this.lbl_discount.TabIndex = 16;
            this.lbl_discount.Text = "discount";
            // 
            // pnl_db
            // 
            this.pnl_db.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_db.Controls.Add(this.label10);
            this.pnl_db.Controls.Add(this.label9);
            this.pnl_db.Controls.Add(this.lbl_dbPhone);
            this.pnl_db.Controls.Add(this.lbl_dbName);
            this.pnl_db.Controls.Add(this.label3);
            this.pnl_db.Controls.Add(this.label5);
            this.pnl_db.Controls.Add(this.lbl_dbID);
            this.pnl_db.Location = new System.Drawing.Point(671, 316);
            this.pnl_db.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_db.Name = "pnl_db";
            this.pnl_db.Size = new System.Drawing.Size(259, 226);
            this.pnl_db.TabIndex = 20;
            this.pnl_db.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(20, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 33);
            this.label10.TabIndex = 20;
            this.label10.Text = "Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(20, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 33);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone :";
            // 
            // lbl_dbPhone
            // 
            this.lbl_dbPhone.AutoSize = true;
            this.lbl_dbPhone.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dbPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dbPhone.Location = new System.Drawing.Point(102, 154);
            this.lbl_dbPhone.Name = "lbl_dbPhone";
            this.lbl_dbPhone.Size = new System.Drawing.Size(71, 33);
            this.lbl_dbPhone.TabIndex = 18;
            this.lbl_dbPhone.Text = "phone";
            // 
            // lbl_dbName
            // 
            this.lbl_dbName.AutoSize = true;
            this.lbl_dbName.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dbName.Location = new System.Drawing.Point(108, 102);
            this.lbl_dbName.Name = "lbl_dbName";
            this.lbl_dbName.Size = new System.Drawing.Size(64, 33);
            this.lbl_dbName.TabIndex = 17;
            this.lbl_dbName.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "DeliveyBoy Details :";
            // 
            // lbl_dbID
            // 
            this.lbl_dbID.AutoSize = true;
            this.lbl_dbID.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dbID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dbID.Location = new System.Drawing.Point(102, 53);
            this.lbl_dbID.Name = "lbl_dbID";
            this.lbl_dbID.Size = new System.Drawing.Size(44, 33);
            this.lbl_dbID.TabIndex = 14;
            this.lbl_dbID.Text = "ID";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(808, 68);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(134, 38);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "Total price";
            // 
            // Grd_Cart
            // 
            this.Grd_Cart.AllowUserToAddRows = false;
            this.Grd_Cart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grd_Cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grd_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.UPrice,
            this.TotalPrice,
            this.DeleteMeal});
            this.Grd_Cart.GridColor = System.Drawing.SystemColors.Control;
            this.Grd_Cart.Location = new System.Drawing.Point(4, 36);
            this.Grd_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grd_Cart.Name = "Grd_Cart";
            this.Grd_Cart.RowTemplate.Height = 24;
            this.Grd_Cart.ShowCellErrors = false;
            this.Grd_Cart.Size = new System.Drawing.Size(648, 535);
            this.Grd_Cart.TabIndex = 5;
            this.Grd_Cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Cart_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Meal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // UPrice
            // 
            this.UPrice.HeaderText = "Unit price";
            this.UPrice.Name = "UPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // DeleteMeal
            // 
            this.DeleteMeal.HeaderText = "Remove";
            this.DeleteMeal.Name = "DeleteMeal";
            this.DeleteMeal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteMeal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteMeal.Text = "Remove";
            this.DeleteMeal.UseColumnTextForButtonValue = true;
            // 
            // btn_Order
            // 
            this.btn_Order.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.Location = new System.Drawing.Point(690, 577);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(178, 50);
            this.btn_Order.TabIndex = 8;
            this.btn_Order.Text = "CheckOut";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Price : ";
            // 
            // tab_rec
            // 
            this.tab_rec.Controls.Add(this.panel1);
            this.tab_rec.Location = new System.Drawing.Point(4, 33);
            this.tab_rec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_rec.Name = "tab_rec";
            this.tab_rec.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_rec.Size = new System.Drawing.Size(934, 762);
            this.tab_rec.TabIndex = 3;
            this.tab_rec.Text = "Recommended";
            this.tab_rec.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowpnlRec);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 757);
            this.panel1.TabIndex = 0;
            // 
            // flowpnlRec
            // 
            this.flowpnlRec.AutoScroll = true;
            this.flowpnlRec.Location = new System.Drawing.Point(3, 56);
            this.flowpnlRec.Name = "flowpnlRec";
            this.flowpnlRec.Size = new System.Drawing.Size(929, 696);
            this.flowpnlRec.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Castellar", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(310, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(351, 33);
            this.label12.TabIndex = 3;
            this.label12.Text = "Recommended Menu";
            // 
            // tab_prev
            // 
            this.tab_prev.Controls.Add(this.flwPrevPanal);
            this.tab_prev.Location = new System.Drawing.Point(4, 33);
            this.tab_prev.Margin = new System.Windows.Forms.Padding(4);
            this.tab_prev.Name = "tab_prev";
            this.tab_prev.Padding = new System.Windows.Forms.Padding(4);
            this.tab_prev.Size = new System.Drawing.Size(934, 762);
            this.tab_prev.TabIndex = 4;
            this.tab_prev.Text = "Previous";
            this.tab_prev.UseVisualStyleBackColor = true;
            // 
            // flwPrevPanal
            // 
            this.flwPrevPanal.Location = new System.Drawing.Point(0, 4);
            this.flwPrevPanal.Margin = new System.Windows.Forms.Padding(4);
            this.flwPrevPanal.Name = "flwPrevPanal";
            this.flwPrevPanal.Size = new System.Drawing.Size(928, 748);
            this.flwPrevPanal.TabIndex = 0;
            this.flwPrevPanal.Paint += new System.Windows.Forms.PaintEventHandler(this.flwPrevPanal_Paint);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab_Menu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main_Menu";
            this.Size = new System.Drawing.Size(942, 799);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Menu)).EndInit();
            this.tab_Menu.ResumeLayout(false);
            this.tabCust_Info.ResumeLayout(false);
            this.tabCust_Info.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCart.ResumeLayout(false);
            this.tabCart.PerformLayout();
            this.pnl_premium.ResumeLayout(false);
            this.pnl_premium.PerformLayout();
            this.pnl_db.ResumeLayout(false);
            this.pnl_db.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Cart)).EndInit();
            this.tab_rec.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_prev.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tab_Menu;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabCust_Info;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ComboBox cmb_Area;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_dbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Finalprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_db;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_dbPhone;
        private System.Windows.Forms.Label lbl_dbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tab_rec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn qty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteMeal;
        private System.Windows.Forms.Panel pnl_premium;
        private System.Windows.Forms.Label lbl_premium;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView Grd_Cart;
        private System.Windows.Forms.TabPage tab_prev;
        private System.Windows.Forms.FlowLayoutPanel flwPrevPanal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowpnlRec;
    }
}
