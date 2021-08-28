namespace RestaurantProject
{
    partial class DeliveryBoys_usercontrol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_Area = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dbOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dbArea = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_dbPhone = new System.Windows.Forms.Label();
            this.lbl_dbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_dbID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.cmb_Area.Location = new System.Drawing.Point(419, 81);
            this.cmb_Area.Name = "cmb_Area";
            this.cmb_Area.Size = new System.Drawing.Size(262, 49);
            this.cmb_Area.TabIndex = 8;
            this.cmb_Area.Text = "Enter  Area";
            this.cmb_Area.SelectedIndexChanged += new System.EventHandler(this.cmb_Area_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.db_ID,
            this.db_Name,
            this.db_phone,
            this.db_area,
            this.NumOrders});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 10.74627F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(208, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 151);
            this.dataGridView1.TabIndex = 9;
            // 
            // db_ID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 10.74627F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.db_ID.HeaderText = "ID";
            this.db_ID.Name = "db_ID";
            // 
            // db_Name
            // 
            this.db_Name.HeaderText = "Name";
            this.db_Name.Name = "db_Name";
            // 
            // db_phone
            // 
            this.db_phone.HeaderText = "Phone";
            this.db_phone.Name = "db_phone";
            // 
            // db_area
            // 
            this.db_area.HeaderText = "Area";
            this.db_area.Name = "db_area";
            // 
            // NumOrders
            // 
            this.NumOrders.HeaderText = "Number Of Orders";
            this.NumOrders.Name = "NumOrders";
            this.NumOrders.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_dbOrders);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_dbArea);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_dbPhone);
            this.panel1.Controls.Add(this.lbl_dbName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_dbID);
            this.panel1.Location = new System.Drawing.Point(291, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 318);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Number Of Orders Deliverd :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_dbOrders
            // 
            this.lbl_dbOrders.AutoSize = true;
            this.lbl_dbOrders.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dbOrders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dbOrders.Location = new System.Drawing.Point(355, 264);
            this.lbl_dbOrders.Name = "lbl_dbOrders";
            this.lbl_dbOrders.Size = new System.Drawing.Size(80, 37);
            this.lbl_dbOrders.TabIndex = 23;
            this.lbl_dbOrders.Text = "orders";
            this.lbl_dbOrders.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(152, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Area :";
            // 
            // lbl_dbArea
            // 
            this.lbl_dbArea.AutoSize = true;
            this.lbl_dbArea.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dbArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dbArea.Location = new System.Drawing.Point(245, 204);
            this.lbl_dbArea.Name = "lbl_dbArea";
            this.lbl_dbArea.Size = new System.Drawing.Size(68, 37);
            this.lbl_dbArea.TabIndex = 21;
            this.lbl_dbArea.Text = "Area";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(154, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 37);
            this.label10.TabIndex = 20;
            this.label10.Text = "Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(154, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 37);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone :";
            // 
            // lbl_dbPhone
            // 
            this.lbl_dbPhone.AutoSize = true;
            this.lbl_dbPhone.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dbPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dbPhone.Location = new System.Drawing.Point(247, 154);
            this.lbl_dbPhone.Name = "lbl_dbPhone";
            this.lbl_dbPhone.Size = new System.Drawing.Size(79, 37);
            this.lbl_dbPhone.TabIndex = 18;
            this.lbl_dbPhone.Text = "phone";
            // 
            // lbl_dbName
            // 
            this.lbl_dbName.AutoSize = true;
            this.lbl_dbName.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dbName.Location = new System.Drawing.Point(255, 102);
            this.lbl_dbName.Name = "lbl_dbName";
            this.lbl_dbName.Size = new System.Drawing.Size(73, 37);
            this.lbl_dbName.TabIndex = 17;
            this.lbl_dbName.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(154, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(44, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 43);
            this.label5.TabIndex = 15;
            this.label5.Text = "Best Delivey Boy In All Areas";
            // 
            // lbl_dbID
            // 
            this.lbl_dbID.AutoSize = true;
            this.lbl_dbID.Font = new System.Drawing.Font("Monotype Corsiva", 16.1194F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dbID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dbID.Location = new System.Drawing.Point(247, 53);
            this.lbl_dbID.Name = "lbl_dbID";
            this.lbl_dbID.Size = new System.Drawing.Size(49, 37);
            this.lbl_dbID.TabIndex = 14;
            this.lbl_dbID.Text = "ID";
            // 
            // DeliveryBoys_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_Area);
            this.Name = "DeliveryBoys_usercontrol";
            this.Size = new System.Drawing.Size(1076, 766);
            this.Load += new System.EventHandler(this.DeliveryBoys_usercontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Area;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_dbArea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_dbPhone;
        private System.Windows.Forms.Label lbl_dbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_dbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dbOrders;
    }
}
