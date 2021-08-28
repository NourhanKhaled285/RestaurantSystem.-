using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace RestaurantProject
{
    class RecommendedPanels : Panel
    {
        public Label lblFoodName;
        public Label lblPrice;
        public Label lblsoldHeader;
        public Label lblsold;

      public  Button PurchaseFromMenu;
      
        public PictureBox pbThumbnail;
        public Label lblpriceHeader;
        Main_Menu temp1;

        public RecommendedPanels (food f, Main_Menu m)
	{
              temp1 = m;
            lblFoodName = new Label();
            this.Controls.Add(lblFoodName);

            pbThumbnail = new PictureBox();
            this.Controls.Add(pbThumbnail);

          

            lblPrice = new Label();
            this.Controls.Add(lblPrice);

            lblsoldHeader = new Label();
            this.Controls.Add(lblsoldHeader);

            lblsold = new Label();
            this.Controls.Add(lblsold);

            PurchaseFromMenu = new Button();
            this.Controls.Add(PurchaseFromMenu);

         


            this.Size = new Size(343, 685);
            this.BorderStyle = BorderStyle.FixedSingle;
            //0
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Size = new Size(179, 43);
            this.lblFoodName.Text = f.name;
            this.lblFoodName.BackColor = Color.Transparent;
            this.lblFoodName.Font = new Font("Monotype Corsiva", (float)16, FontStyle.Italic);

            //1
            this.pbThumbnail.Image = Image.FromFile(f.image);
            this.pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbThumbnail.Size = new Size(337, 202);
            this.pbThumbnail.BackColor = Color.Transparent;

        
            //2
            this.lblPrice.AutoSize = true;
            this.lblPrice.Size = new Size(179, 43);
            this.lblPrice.Text = f.price.ToString();
            this.lblPrice.BackColor = Color.Transparent;
            this.lblPrice.Font = new Font("Monotype Corsiva", (float)16, FontStyle.Italic);

            //3
            this.lblsoldHeader.AutoSize = true;
            this.lblsoldHeader.Size = new Size(179, 43);
            this.lblsoldHeader.Text = "*Meal Has Been Sold For*";
            this.lblsoldHeader.BackColor = Color.Transparent;
            this.lblsoldHeader.Font = new Font("Monotype Corsiva", (float)16, FontStyle.Italic);

            //4
            this.lblsold.AutoSize = true;
            this.lblsold.Size = new Size(179, 43);
            this.lblsold.Text = f.sold.ToString() + " Times ";
            this.lblsold.BackColor = Color.Transparent;
            this.lblsold.Font = new Font("Monotype Corsiva", (float)16, FontStyle.Italic);

            //5
             this.PurchaseFromMenu.Text = "Purchase From Menu";
          //  this.PurchaseFromMenu.Name = (int.Parse(f.id) - 1).ToString();
            this.PurchaseFromMenu.AutoSize = true;
            this.PurchaseFromMenu.TextAlign = ContentAlignment.MiddleRight;
           // this.btnAddCart.Size = new Size(100, 25);
         //   this.PurchaseFromMenu.Image = P;
            this.PurchaseFromMenu.Font = new Font("Monotype Corsiva", (float)14, FontStyle.Italic);
            this.PurchaseFromMenu.FlatStyle = FlatStyle.Flat;
            this.PurchaseFromMenu.BackColor = Color.Snow;
            this.PurchaseFromMenu.Click += new EventHandler(m.butonClick);
            this.PurchaseFromMenu.AutoSize = true;
            this.PurchaseFromMenu.ImageAlign = ContentAlignment.MiddleLeft;
          


          //6
            lblpriceHeader = new Label();

            this.lblpriceHeader.AutoSize = true;
            this.lblpriceHeader.Text = "Price (LE):";
            this.lblpriceHeader.BackColor = Color.Transparent;
            this.lblpriceHeader.Font = new Font("Monotype Corsiva", (float)16, FontStyle.Italic);
            this.Visible = true;
            this.Controls.Add(lblpriceHeader);

            this.Controls[0].Location = new Point(37, 226);
            this.Controls[0].BringToFront();//name
            this.Controls[1].Location = new Point(3, 3);
            this.Controls[1].BringToFront();//pic
            this.Controls[2].Location = new Point(223, 299);
            this.Controls[2].BringToFront();
            this.Visible = true;
            this.Controls[3].Location = new Point(20, 388);
            this.Controls[3].BringToFront();
            this.Controls[4].Location = new Point(115, 444);
            this.Controls[4].BringToFront();

            this.Controls[5].Location = new Point(72, 566);
            this.Controls[6].Location = new Point(32, 299);
            this.Controls[6].BringToFront();
            this.Visible = true;

	}


       

    }
}
