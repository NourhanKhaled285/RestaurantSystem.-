namespace RestaurantProject
{
    partial class InoviceForm
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
            this.PnlInvoice = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblShip = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustInf = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.PnlInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlInvoice
            // 
            this.PnlInvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlInvoice.Controls.Add(this.listView1);
            this.PnlInvoice.Controls.Add(this.lblShip);
            this.PnlInvoice.Controls.Add(this.lbl_Total);
            this.PnlInvoice.Controls.Add(this.label2);
            this.PnlInvoice.Controls.Add(this.lblCustInf);
            this.PnlInvoice.Controls.Add(this.lblDate);
            this.PnlInvoice.Controls.Add(this.lblCompany);
            this.PnlInvoice.Location = new System.Drawing.Point(-1, 0);
            this.PnlInvoice.Name = "PnlInvoice";
            this.PnlInvoice.Size = new System.Drawing.Size(543, 632);
            this.PnlInvoice.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.name,
            this.quantity,
            this.uPrice,
            this.tPrice});
            this.listView1.Enabled = false;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 222);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 354);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 39;
            // 
            // name
            // 
            this.name.Text = "Meal";
            this.name.Width = 199;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uPrice
            // 
            this.uPrice.Text = "Unit Price";
            this.uPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tPrice
            // 
            this.tPrice.Text = "Total Price";
            this.tPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tPrice.Width = 63;
            // 
            // lblShip
            // 
            this.lblShip.Location = new System.Drawing.Point(279, 118);
            this.lblShip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(227, 93);
            this.lblShip.TabIndex = 19;
            this.lblShip.Text = "Shipment information";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(370, 580);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(150, 43);
            this.lbl_Total.TabIndex = 17;
            this.lbl_Total.Text = "Total price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 43);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total Price : ";
            // 
            // lblCustInf
            // 
            this.lblCustInf.Location = new System.Drawing.Point(40, 118);
            this.lblCustInf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustInf.Name = "lblCustInf";
            this.lblCustInf.Size = new System.Drawing.Size(227, 93);
            this.lblCustInf.TabIndex = 16;
            this.lblCustInf.Text = "Customer information";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(319, 46);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(187, 28);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.79104F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(10, 9);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(281, 78);
            this.lblCompany.TabIndex = 14;
            this.lblCompany.Text = "Restaurant";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InoviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 632);
            this.Controls.Add(this.PnlInvoice);
            this.Name = "InoviceForm";
            this.Text = "InoviceForm";
            this.Load += new System.EventHandler(this.InoviceForm_Load);
            this.PnlInvoice.ResumeLayout(false);
            this.PnlInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlInvoice;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader uPrice;
        private System.Windows.Forms.ColumnHeader tPrice;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustInf;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCompany;

    }
}