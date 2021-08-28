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
    public partial class Main_Menu : UserControl
    {
        public static int Discount_Percent;
        public int rowIndex = 0;
        ComboBox comboBox;
        public static Menu MenuArray = new Menu();
        public static Menu RecArray = new Menu();
        public double total = 0;
        food selectedFood = new food();
        public static int CustomerPhone = 0;
        public static string area = " ";
        public static string Full_Address = " ";
        public int AvaliableQuantity;
        public int selected = 0;
        public int sold;
        public static bool premium = false;
        public DeliverySoldMeals Sold_in_Areas = new DeliverySoldMeals();
        Chartusercontrol chartuser = new Chartusercontrol();

        List<FactoryPanels> containsall = new List<FactoryPanels>();
        List<RecommendedPanels> containsRec = new List<RecommendedPanels>();

        public Main_Menu()
        {
            InitializeComponent();
            DeserializeMenu();

          
            AddRecommendedMeals();
            lbl_discount.Text = "0";
            lbl_discount.Text = "0";
            lbl_Finalprice.Text = "0";
            Sold_in_Areas.deserialize();

        }
        public List<string> allAreas()
        {
            List<string> list = new List<string>();

            foreach (string s in cmb_Area.Items)
            {
                list.Add(s);
            }
            return list;

        }

        public void serializeData()
        {
           

          string path = Path.Combine(Application.StartupPath, @"C:\Users\lenovo\Documents\Visual Studio 2013\Projects\RestaurantProject\RestaurantProject\bin\Debug\Menu.xml");
          //  string path = Path.Combine(Application.StartupPath, @" F:\lectures and labs second year\2nd term\files organization\file project\RestaurantProject\RestaurantProject\Menu.xml");
            XmlSerializer xs = new XmlSerializer(MenuArray.GetType());

            FileStream fs = new FileStream("menu file.xml", FileMode.Create);
            xs.Serialize(fs, MenuArray);
            fs.Close();

        }
        public void DeserializeMenu()
        {
            Grd_Menu.Rows.Clear();

            containsall.Clear();
            containsRec.Clear();

            flowLayoutPanel1.Controls.Clear();
            flowpnlRec.Controls.Clear();
            flwPrevPanal.Controls.Clear();

            try
            {


               // string path = Path.Combine(Application.StartupPath, @"F:\lectures and labs second year\2nd term\files organization\file project\RestaurantProject\RestaurantProject\Menu.xml");
                string path = Path.Combine(Application.StartupPath, @"C:\Users\lenovo\Documents\Visual Studio 2013\Projects\RestaurantProject\RestaurantProject\bin\Debug\Menu.xml");
                XmlSerializer xs = new XmlSerializer(MenuArray.GetType());
                FileStream fs = new FileStream("menu file.xml", FileMode.Open);
                MenuArray = (Menu)xs.Deserialize(fs);
                fs.Close();



                for (int i = 0; i < MenuArray.menuLst.Count; i++)
                {
                    string Id = MenuArray.menuLst[i].id;
                    string name = MenuArray.menuLst[i].name;
                    float price = MenuArray.menuLst[i].price;
                    string description = MenuArray.menuLst[i].description;
                    AvaliableQuantity = MenuArray.menuLst[i].quantity;
                    sold = MenuArray.menuLst[i].sold;

                    FactoryPanels container = new FactoryPanels(MenuArray.menuLst[i], this);

                    containsall.Add(container);



                    Grd_Menu.Rows.Add(new string[] { Id, name, price.ToString(), description });
                    DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)Grd_Menu.Rows[i].Cells[4];
                    comboCell.Items.Clear();
                    for (int j = 1; j <= AvaliableQuantity; j++)
                    {
                        comboCell.Items.Add(j.ToString());
                    }

                    for (int h = 0; h < Grd_Menu.Rows.Count; h++)
                    {
                        Grd_Menu.Rows[h].Cells[5].Value = false;

                    }
                    rowIndex++;
                }




                foreach (FactoryPanels p in containsall)
                {

                    flowLayoutPanel1.Controls.Add(p);

                }
                lbl_discount.Text = "0";
              

            }
            catch (FileNotFoundException ex)
            {


            }

        }

        public void AddRecommendedMeals()
        {

            flowpnlRec.Controls.Clear();
            RecArray.menuLst.Clear();
            for (int i = 0; i < MenuArray.menuLst.Count; i++)
            {
                RecArray.menuLst.Add(MenuArray.menuLst[i]);
            }
            for (int i = 1; i < RecArray.menuLst.Count; i++)
            {
                for (int j = 0; j < (RecArray.menuLst.Count - 1); j++)
                {
                    if (RecArray.menuLst[j].sold < RecArray.menuLst[j + 1].sold)
                    {
                        food temp = RecArray.menuLst[j];
                        RecArray.menuLst[j] = RecArray.menuLst[j + 1];
                        RecArray.menuLst[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
             

                RecommendedPanels container = new RecommendedPanels(RecArray.menuLst[i], this);

                containsRec.Add(container);
            }
            foreach (RecommendedPanels p in containsRec)
            {
                flowpnlRec.Controls.Add(p);
            }


        }
        public void cbChange(object sender, EventArgs e)
        {
            comboBox = (ComboBox)sender;

            selected = Convert.ToInt32(comboBox.SelectedIndex + 1);


        }

        public void butonClick(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            //   MessageBox.Show("You have clicked button number " + btn.Name);
            int quantity = MenuArray.menuLst[int.Parse(btn.Name)].quantity;
            if (selected <= quantity)
            {
                string id = MenuArray.menuLst[int.Parse(btn.Name)].id;
                string name = MenuArray.menuLst[int.Parse(btn.Name)].name;
                double price = Convert.ToDouble(MenuArray.menuLst[int.Parse(btn.Name)].price);

                //   quantity = quantity - selected;
                //   MenuArray.menuLst[Convert.ToInt32(btn.Name)].quantity = quantity;
                double TotalPrice = Convert.ToInt32(selected) * Convert.ToDouble(price);
                total += TotalPrice;
                lbl_Total.Text = total.ToString();

                Grd_Cart.Rows.Add(new string[] { id, name, selected.ToString(), price.ToString(), TotalPrice.ToString() });
                MessageBox.Show(name + "  is added with quantity : " + selected.ToString());

                int combocount = containsall[int.Parse(btn.Name)].cbQuantity.Items.Count - 1;
                for (int i = 0; i < selected; i++)
                {
                    containsall[int.Parse(btn.Name)].cbQuantity.Items.RemoveAt(combocount);
                    combocount--;
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            int k = 0;



            foreach (DataGridViewRow row in Grd_Menu.Rows)
            {
                //    DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)Grd_Menu.Rows[i].Cells[4];

                int quantity;
                // DataGridViewRow row = Grd_Menu.Rows[i];
                if (Convert.ToBoolean(row.Cells[5].Value))
                {
                    string id = (row.Cells[0].Value).ToString();
                    string name = row.Cells[1].Value.ToString();
                    double price = Convert.ToDouble(row.Cells[2].Value);
                    quantity = Convert.ToInt32(row.Cells[4].Value);
                    int Currentquantity = MenuArray.menuLst[k].quantity;

                    Currentquantity -= quantity;


                    double TotalPrice = Convert.ToInt32(quantity) * Convert.ToDouble(price);
                    total += TotalPrice;

                    Grd_Cart.Rows.Add(new string[] { id, name, quantity.ToString(), price.ToString(), TotalPrice.ToString() });
                    MessageBox.Show(name + "  is added with quantity : " + quantity.ToString());

                    MenuArray.menuLst[k].quantity = Currentquantity;

                    k++;
                }

            }

            lbl_Total.Text = total.ToString();
            serializeData();
            DeserializeMenu();

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmb_Area.SelectedIndex != -1 && txt_Address.Text != null)
                {
                    CustomerPhone = Convert.ToInt32(txt_Phone.Text);
                    area = cmb_Area.SelectedItem.ToString();
                    Full_Address = txt_Address.Text + "," + area;
                    tab_Menu.SelectedIndex =
                    (tab_Menu.SelectedIndex + 1) % tab_Menu.TabCount;

                    pervious(CustomerPhone);


                }
                else MessageBox.Show(" Please select your Area ");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(" please enter a valid phone number ");
            }
        }


        public void ConfirmCustomerOrder()
        {


            for (int i = 0; i < Grd_Cart.RowCount; i++)
            {
                for (int j = 0; j < MenuArray.menuLst.Count; j++)
                {
                    if (Grd_Cart.Rows[i].Cells[1].Value.ToString() == MenuArray.menuLst[j].id)
                    {
                        MenuArray.menuLst[j].sold++;
                    }
                }

            }


            for (int i = 0; i < Grd_Cart.Rows.Count; i++)
            {
                int Rowquantity = Convert.ToInt32(Grd_Cart.Rows[i].Cells[2].Value);
                int id = Convert.ToInt32(Grd_Cart.Rows[i].Cells[0].Value);

                MenuArray.menuLst[id - 1].quantity -= Rowquantity;

            }


            lbl_Finalprice.Text = lbl_Total.Text;
            int count = 0;
            double totalprice = 0;
            double disc = 0;
            if (!File.Exists("customer info.xml"))
            {

                XmlWriter w = XmlWriter.Create("customer info.xml");


                w.WriteStartDocument();
                w.WriteStartElement("table");
                //   w.WriteAttributeString("name", "customers");

                w.WriteStartElement("customer");

                w.WriteStartElement("phonenum");
                w.WriteString(CustomerPhone.ToString());
                w.WriteEndElement();


                w.WriteStartElement("orders");
                w.WriteStartElement("order");

                w.WriteStartElement("area");
                w.WriteString(Full_Address);
                w.WriteEndElement();
                for (int o = 0; o < Grd_Cart.RowCount; o++)
                {
                    w.WriteStartElement("item");
                    w.WriteStartElement("foodname");
                    w.WriteString((Grd_Cart.Rows[o].Cells[1].Value).ToString());
                    w.WriteEndElement();
                    w.WriteStartElement("foodprice");
                    w.WriteString((Grd_Cart.Rows[o].Cells[3].Value).ToString());
                    w.WriteEndElement();
                    w.WriteStartElement("foodquantity");
                    w.WriteString((Grd_Cart.Rows[o].Cells[2].Value).ToString());
                    w.WriteEndElement();

                    w.WriteEndElement();

                    totalprice = totalprice + int.Parse((Grd_Cart.Rows[o].Cells[4].Value).ToString());




                    //  Grd_Cart.Rows[o].Cells[4].Value = totalprice.ToString();     //lapel total price
                }

                w.WriteEndElement();
                w.WriteEndElement();

                w.WriteStartElement("totalprice");
                w.WriteString(totalprice.ToString());
                w.WriteEndElement();


                w.WriteStartElement("discount");
                w.WriteString("0");
                w.WriteEndElement();

                w.WriteStartElement("numoforders");
                w.WriteString((count + 1).ToString());
                w.WriteEndElement();

                w.WriteEndElement();
                w.WriteEndElement();

                w.WriteEndDocument();

                MessageBox.Show("add sucsessfuly");

                w.Close();

            }



            else
            {

                XmlElement child7;
                bool b = false;
                XmlDocument doc = new XmlDocument();
                doc.Load("customer info.xml");

                XmlNodeList list = doc.GetElementsByTagName("customer");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList ch = list[i].ChildNodes;
                    if (CustomerPhone == Convert.ToInt32(ch[0].InnerText))
                    {

                        b = true;
                        int sum = int.Parse(ch[4].InnerText) + 1;
                        ch[4].InnerText = (sum).ToString();
                        child7 = doc.CreateElement("order");
                        XmlElement child32 = doc.CreateElement("area");
                        child32.InnerText = Full_Address;
                        child7.AppendChild(child32);

                        for (int o = 0; o < Grd_Cart.RowCount; o++)
                        {


                            XmlElement child33 = doc.CreateElement("item");

                            XmlElement child9 = doc.CreateElement("foodname");

                            child9.InnerText = (Grd_Cart.Rows[o].Cells[1].Value).ToString();

                            child33.AppendChild(child9);

                            XmlElement child8 = doc.CreateElement("foodprice");

                            child8.InnerText = (Grd_Cart.Rows[o].Cells[3].Value).ToString();

                            child33.AppendChild(child8);



                            XmlElement foodQty = doc.CreateElement("foodquantity");

                            foodQty.InnerText = (Grd_Cart.Rows[o].Cells[2].Value).ToString();

                            child33.AppendChild(foodQty);


                            child7.AppendChild(child33);


                            totalprice = totalprice + int.Parse((Grd_Cart.Rows[o].Cells[4].Value).ToString());
                            /**** lbl_Total.Text = totalporice.ToString();***/
                            Grd_Cart.Rows[o].Cells[4].Value = totalprice.ToString();
                        }


                        ch[1].AppendChild(child7);
                        if (int.Parse(ch[4].InnerText) >= 3 && int.Parse(ch[4].InnerText) < 5)
                        {
                            premium = true;
                            Discount_Percent = 10;
                            int total = int.Parse(lbl_Total.Text);
                            double Discounted_Price = Convert.ToDouble((lbl_Total.Text)) * (0.10);
                            lbl_discount.Text = Convert.ToString(Discounted_Price);
                            double final_price = total - Discounted_Price;
                            lbl_Finalprice.Text = final_price.ToString();


                            disc = ((totalprice) * (0.10));
                            ch[3].InnerText = (float.Parse(ch[3].InnerText) + disc).ToString();

                            pnl_premium.Visible = true;
                            lbl_premium.Visible = true;

                        }
                        else if (int.Parse(ch[4].InnerText) >= 5)
                        {
                            premium = true;

                            Discount_Percent = 20;

                            int total = int.Parse(lbl_Total.Text);
                            double Discounted_Price = Convert.ToDouble(lbl_Total.Text) * (0.20);
                            lbl_discount.Text = Convert.ToString(Discounted_Price);
                            double final_price = total - Discounted_Price;

                            lbl_Finalprice.Text = Convert.ToString(final_price);
                            disc = ((totalprice) * (0.20));
                            ch[3].InnerText = (float.Parse(ch[3].InnerText) + disc).ToString();


                            pnl_premium.Visible = true;
                            lbl_premium.Visible = true;
                        }


                        ch[2].InnerText = (double.Parse(ch[2].InnerText) + (totalprice - disc)).ToString();

                        //  MessageBox.Show("add sucsessfuly");
                        doc.Save("customer Info.xml");


                    }
                }

                if (b == false)
                {
                    count++;
                    XmlElement p = doc.CreateElement("customer");
                    XmlElement child;



                    child = doc.CreateElement("phonenum");
                    child.InnerText = CustomerPhone.ToString();
                    p.AppendChild(child);
                    XmlElement child2 = doc.CreateElement("orders");
                    child7 = doc.CreateElement("order");
                    XmlElement child32 = doc.CreateElement("area");
                    child32.InnerText = Full_Address;
                    child7.AppendChild(child32);
                    for (int o = 0; o < Grd_Cart.RowCount; o++)
                    {
                        XmlElement child33 = doc.CreateElement("item");

                        XmlElement child9 = doc.CreateElement("foodname");
                        child9.InnerText = (Grd_Cart.Rows[o].Cells[1].Value).ToString();
                        child33.AppendChild(child9);

                        XmlElement child8 = doc.CreateElement("foodprice");
                        child8.InnerText = (Grd_Cart.Rows[o].Cells[3].Value).ToString();
                        child33.AppendChild(child8);



                        XmlElement foodQty = doc.CreateElement("foodquantity");
                        foodQty.InnerText = (Grd_Cart.Rows[o].Cells[2].Value).ToString();
                        child33.AppendChild(foodQty);

                        child7.AppendChild(child33);

                        totalprice = totalprice + int.Parse((Grd_Cart.Rows[o].Cells[4].Value).ToString());
                        /**** lbl_Total.Text = totalporice.ToString();***/
                        //  Grd_Cart.Rows[o].Cells[4].Value = totalprice.ToString();



                    }
                    child2.AppendChild(child7);
                    p.AppendChild(child2);
                    child = doc.CreateElement("totalprice");
                    child.InnerText = totalprice.ToString();
                    p.AppendChild(child);

                    child = doc.CreateElement("discount");
                    child.InnerText = "0";
                    p.AppendChild(child);

                    child = doc.CreateElement("numoforders");
                    child.InnerText = count.ToString();
                    p.AppendChild(child);

                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(p);

                    // MessageBox.Show("add sucsessfuly");

                    doc.Save("customer info.xml");

                }

            }
        }




        private void btn_Order_Click(object sender, EventArgs e)
        {
            if ((txt_Phone.Text == "Phone Number") && cmb_Area.SelectedIndex == -1)
            {

                MessageBox.Show("please Enter your Details to checkout your order ");

            }
            else
            {
                ConfirmCustomerOrder();

            }

            DeliveryBoyxml xml = new DeliveryBoyxml();
            List<DeliveryBoy> deliveryBoysList = xml.GetDeliveryBoysinArea(area);

            DeliveryBoy Orderdb = xml.order2(area);
            lbl_dbID.Text = Orderdb.id;
            lbl_dbName.Text = Orderdb.name;
            lbl_dbPhone.Text = Orderdb.phone;

            pnl_db.Visible = true;
            MessageBox.Show("Checked out successfully");

            for (int i = 0; i < Grd_Cart.Rows.Count; i++)
            {
                int id = Convert.ToInt32(Grd_Cart.Rows[i].Cells[0].Value);
                string food_Name = Grd_Cart.Rows[i].Cells[1].Value.ToString();
                int purchased = Convert.ToInt32(Grd_Cart.Rows[i].Cells[2].Value);

                MenuArray.menuLst[id - 1].sold += purchased;
                Sold_in_Areas.update_Sold_In_Area(area, food_Name, purchased);

            }


            List<DataGridViewRow> cartItems = new List<DataGridViewRow>();
            foreach (DataGridViewRow item in Grd_Cart.Rows)
            {
                DataGridViewRow r = (DataGridViewRow)item.Clone();

                for (int i = 0; i < item.Cells.Count; i++)
                {
                    r.Cells[i].Value = item.Cells[i].Value;
                }
                cartItems.Add(r);



            }

            Grd_Cart.Rows.Clear();


            InoviceForm f = new InoviceForm(lbl_Finalprice.Text, lbl_discount.Text, cartItems, Orderdb);
            f.Show();
            serializeData();
            DeserializeMenu();
            chartuser.BoysChartRefresher();
            AddRecommendedMeals();

        }

        public TabPage menutab
        {
            get { return tab_Menu.SelectedTab = tabMenu; }
        }

        public TabPage carttab
        {
            get { return tab_Menu.SelectedTab = tabCart; }
        }
        public TabPage usertab
        {
            get { return tab_Menu.SelectedTab = tabCust_Info; }
        }

        public TabPage recommendedTab
        {
            get { return tab_Menu.SelectedTab = tab_rec; }
        }

        public TabPage previseTab
        {
            get { return tab_Menu.SelectedTab = tab_prev; }
        }

        private void txt_Phone_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Phone.TextLength == 0)
                txt_Phone.Text = "Phone Number";
            if (txt_Phone.TextLength != 0)
                txt_Phone.Text = txt_Phone.Text;
        }

        private void txt_Phone_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Phone.Text == "Phone Number")
                txt_Phone.Text = null;

        }

        private void Grd_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {

                    total = total - Convert.ToInt32(Grd_Cart.Rows[e.RowIndex].Cells[4].Value);
                    lbl_Total.Text = total.ToString();
                    int RemovedID = Convert.ToInt32(Grd_Cart.Rows[e.RowIndex].Cells[0].Value);
                    int returnedQty = Convert.ToInt32(Grd_Cart.Rows[e.RowIndex].Cells[2].Value);

                    for (int i = 0; i < returnedQty; i++)
                    {
                        int currentQty = containsall[RemovedID - 1].cbQuantity.Items.Count;

                        containsall[RemovedID - 1].cbQuantity.Items.Add(currentQty + 1);

                    }
                    Grd_Cart.Rows.RemoveAt(e.RowIndex);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Grd_Cart.Rows.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void pervious(int mobile)
        {



            Label Title = new Label();
            Title.AutoSize = true;
            Title.Size = new Size(770, 150);
            Title.BackColor = Color.Tomato;
            Title.Margin = new Padding(250, 0, 5, 10);
            Title.Font = new Font("Monotype Corsiva", (float)18, FontStyle.Bold);
            Title.Text = "Orders Information";
            flwPrevPanal.Controls.Add(Title);
            flwPrevPanal.Visible = true;

            Label Info = new Label();
            Info.AutoSize = true;
            Info.Size = new Size(770, 150);
            Info.BackColor = Color.Tomato;
            Info.Margin = new Padding(250, 0, 5, 0);
            Info.Font = new Font("Monotype Corsiva", (float)18, FontStyle.Italic);




            customers Customers = new customers();
            XmlSerializer xs = new XmlSerializer(Customers.GetType());
            FileStream fs = new FileStream("customer info.xml", FileMode.Open);
            Customers = (customers)xs.Deserialize(fs);
            fs.Close();



            foreach (Customer c in Customers.Allcustomers)
            {
                if (c.phone == mobile)
                {
                    string phone = c.phone.ToString();
                    string totalPrice = c.totalprice.ToString();
                    string discount = c.discount.ToString();
                    string numOfOrders = c.numoforders.ToString();
                    Info.Text ="Phone number : " + phone + "\n Total price : " + totalPrice + "$  \n Discount :  " + discount + "$  \n No Of your Order : " + numOfOrders + "  ";
                    Info.Visible = true;
                    flwPrevPanal.Controls.Add(Info);
                    flwPrevPanal.Visible = true;
                    flwPrevPanal.AutoScroll = true;
                    int i = 1;
                    foreach (Order o in c.orders.order)
                    {

                        Label Arealbl = new Label();

                        Arealbl.AutoSize = false;
                        Arealbl.Size = new Size(760, 65);
                        Arealbl.BackColor = Color.BurlyWood;
                        Arealbl.Margin = new Padding(5, 15, 5, 0);
                        Arealbl.Font = new Font("Monotype Corsiva", (float)14, FontStyle.Italic);

                        string area = o.area;
                        Arealbl.Text = " Order #" + i + "\n Order Address: " + area;
                        Arealbl.Visible = true;
                        flwPrevPanal.Controls.Add(Arealbl);

                        i++;
                        foreach (item ITEM in o.items)
                        {

                            string name = ITEM.name;
                            string price = ITEM.price.ToString();
                            string quantity = ITEM.quantity.ToString();

                            Label Iteamlbl = new Label();
                            Iteamlbl.AutoSize = true;
                            Iteamlbl.Size = new Size(760, 70);
                            Iteamlbl.BackColor = Color.Transparent;
                            Iteamlbl.Margin = new Padding(5, 0, 5, 10);
                            Iteamlbl.Font = new Font("Monotype Corsiva", (float)12, FontStyle.Italic);
                            Iteamlbl.Text = "\n The Order Is : " + name + "         Costs :" + price + " $    Quantity of it: :\t " + quantity + "  ";
                            Iteamlbl.Visible = true;
                            flwPrevPanal.Controls.Add(Iteamlbl);


                        }

                    }



                }

            }




            //XmlDocument doc = new XmlDocument();
            //doc.Load("customer info.xml");
            //XmlNodeList list = doc.GetElementsByTagName("customer");

            //for (int i = 0; i < list.Count; i++)
            //{
            //   XmlNodeList customer = list[i].ChildNodes;
            //    if (int.Parse( customer[0].InnerText) == mobile)
            //    {
            //        XmlNode Orders = customer[1];
            //        XmlNodeList order = Orders.ChildNodes;
            //       // XmlNodeList Orders = doc.GetElementsByTagName("order");
            //        for (int j = 0; j < order.Count; j++)
            //        {
            //            //XmlNodeList order = Orders[j].ChildNodes;
            //            string area = order[0].InnerText;
            //            Arealbl.Text = area;
            //            Arealbl.Visible = true;
            //            flwPrevPanal.Controls.Add(Arealbl);
            //            //XmlNodeList Items = doc.GetElementsByTagName("item");
            //            XmlNodeList Items = order[1].ChildNodes;
            //            for (int k = 0; k < Items.Count; k++)
            //            {
            //                XmlNodeList item = Items[k].ChildNodes;
            //                string name = item[0].InnerText;
            //                string price = item[1].InnerText;
            //                string quantity = item[2].InnerText;
            //                Iteamlbl.Text = name + "\t" + price + "\t" + quantity;
            //                Iteamlbl.Visible = true;
            //                flwPrevPanal.Controls.Add(Iteamlbl);

            //            }

            //        }
            //        string totalPrice = customer[3].InnerText;
            //        string discount = customer[4].InnerText;
            //        string numOfOrders = customer[5].InnerText;
            //        Info.Text = totalPrice + "\n" + discount + "\n" + numOfOrders;
            //        Info.Visible = true;
            //        flwPrevPanal.Controls.Add(Info);
            //        flwPrevPanal.Visible = true;

            //    }

            //}

        }




        private void flwPrevPanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowpnl_rec_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txt_Address_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_Address_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Address.Text == "Address")
                txt_Address.Text = null;
        }

        private void txt_Address_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Address.TextLength == 0)
                txt_Address.Text = "Address";
            if (txt_Address.TextLength != 0)
                txt_Address.Text = txt_Address.Text;
        }
    }
}
