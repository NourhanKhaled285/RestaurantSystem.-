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
    class FactoryPanels : Panel
    {

     
        public Label lblFoodName;
        public Label lblFoodDescription;
        public Label lblPrice;
        public Button btnAddCart;
        public ComboBox cbQuantity;
        public PictureBox pbThumbnail;
        public Label lblpriceHeader;
        Main_Menu temp1;

        public FactoryPanels(food f, Main_Menu m)
        {
            temp1 = m;
            lblFoodName = new Label();
            this.Controls.Add(lblFoodName);

            pbThumbnail = new PictureBox();
            this.Controls.Add(pbThumbnail);

            cbQuantity = new ComboBox();
            this.Controls.Add(cbQuantity);

            lblPrice = new Label();
            this.Controls.Add(lblPrice);

            btnAddCart = new Button();
            this.Controls.Add(btnAddCart);

            lblFoodDescription = new Label();
            this.Controls.Add(lblFoodDescription);


            this.Size = new Size(997, 141);
            this.BorderStyle = BorderStyle.FixedSingle;

            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Size = new Size(179, 43);
            this.lblFoodName.Text = f.name;
            this.lblFoodName.BackColor = Color.Transparent;
            this.lblFoodName.Font = new Font("Monotype Corsiva", (float)16, FontStyle.Italic);


            this.pbThumbnail.Image = Image.FromFile(f.image);
            this.pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbThumbnail.Size = new Size(191, 162);
            this.pbThumbnail.BackColor = Color.Transparent;

            for (int h = 1; h <= f.quantity; h++)
            {
                this.cbQuantity.Items.Add(h.ToString());
            }
            this.cbQuantity.SelectedIndex = -1;
            this.cbQuantity.SelectedIndexChanged += new EventHandler(m.cbChange);
            this.cbQuantity.Size = new Size(121, 34);
            this.cbQuantity.IntegralHeight = false;
            this.cbQuantity.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lblPrice.AutoSize = true;
            this.lblPrice.Size = new Size(179, 43);
            this.lblPrice.Text = f.price.ToString();
            this.lblPrice.BackColor = Color.Transparent;
            this.lblPrice.Font = new Font("Monotype Corsiva", (float)16, FontStyle.Italic);

           // this.btnAddCart.Text = "Add To Cart";
            this.btnAddCart.Name = (int.Parse(f.id) - 1).ToString();
            this.btnAddCart.AutoSize = true;
            this.btnAddCart.TextAlign = ContentAlignment.MiddleRight;
           // this.btnAddCart.Size = new Size(100, 25);
            this.btnAddCart.Image = Properties.Resources.addcart;
            this.btnAddCart.Font = new Font("Monotype Corsiva", (float)14, FontStyle.Italic);
            this.btnAddCart.FlatStyle = FlatStyle.Flat;
            this.btnAddCart.BackColor = Color.Snow;
            this.btnAddCart.Click += new EventHandler(m.butonClick);
            this.btnAddCart.AutoSize = true;
            this.btnAddCart.ImageAlign = ContentAlignment.MiddleLeft;
            if (f.quantity == 0)
            {
                this.btnAddCart.Enabled = false;
                this.cbQuantity.Visible = false;
            }


            this.lblFoodDescription.AutoSize = true;
            //this.lblFoodDescription.Size = new Size(179, 43);
            this.lblFoodDescription.Text = f.description;
            this.lblFoodDescription.BackColor = Color.Transparent;
            this.lblFoodDescription.Font = new Font("Monotype Corsiva", (float)12, FontStyle.Italic);



            lblpriceHeader = new Label();
            this.lblpriceHeader.AutoSize = true;
            this.lblpriceHeader.Text = "Price (LE):";
            this.lblpriceHeader.BackColor = Color.Transparent;
            this.lblpriceHeader.Font = new Font("Monotype Corsiva", (float)16, FontStyle.Italic);
            this.Controls.Add(lblpriceHeader);

            this.Controls[0].Location = new Point(224, 3);
            this.Controls[0].BringToFront();//name
            this.Controls[1].Location = new Point(13, 3);
            this.Controls[1].BringToFront();//pic
            this.Controls[2].Location = new Point(860, 44);
            this.Controls[2].BringToFront();//combobox
            this.Visible = true;
            this.Controls[3].Location = new Point(697, 12);
            this.Controls[3].BringToFront();//price
            this.Controls[4].Location = new Point(900, 84);//Button
            this.Controls[5].Location = new Point(224, 55);
            this.Controls[5].BringToFront();//price
            this.Controls[6].Location = new Point(555, 12);
            this.Controls[6].BringToFront();//price
            this.Visible = true;

        }

    }
}