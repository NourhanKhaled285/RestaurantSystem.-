using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace RestaurantProject
{
  public  class DeliveryBoy
    {
        public String id;
        public String name;
        public String phone;
        public String area;
        public int NumberofOrders;
        DeliveryBoyxml xml = new DeliveryBoyxml();
        Deliveryxml Dxml = new Deliveryxml();
        public DeliveryBoy()
        { }
        public DeliveryBoy(String id, String name, String phone, String area, string orders)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.area = area;
            this.NumberofOrders = Convert.ToInt32(orders);

        }
    
    }

  public  class DeliveryBoyxml
    {
        
        public DeliveryBoy BestDeliveryBoy_AllAreas()
        {
            DeliveryBoy BestDeliveryBoy = null;
            int count = 0;
            XmlDocument doc = new XmlDocument();
            string path = Path.Combine(Application.StartupPath, @"C:\Users\lenovo\Documents\Visual Studio 2013\Projects\RestaurantProject\RestaurantProject\bin\Debug\DeliveryBoy.xml");

            doc.Load("DeliveryBoy.xml");
            XmlNodeList list = doc.GetElementsByTagName("DeliveryBoy");
            List<DeliveryBoy> deliveryboys = new List<DeliveryBoy>();
            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList childerns = list[i].ChildNodes;

                string id = childerns[0].Name;
                string idvaluue = childerns[0].InnerText;

                string name = childerns[1].Name;
                string namevalue = childerns[1].InnerText; ;

                string phone = childerns[2].Name;
                string phonevalue = childerns[2].InnerText; ;

                string AreaCode = childerns[3].Name;
                string areacodevalue = childerns[3].InnerText;

                string numberodorders = childerns[4].Name;
                string nuvalue = childerns[4].InnerText;
                int NumberOfOrders = int.Parse(nuvalue);
                if (NumberOfOrders > count)
                {
                    BestDeliveryBoy = new DeliveryBoy(idvaluue, namevalue, phonevalue, areacodevalue, nuvalue);
                    count = NumberOfOrders;
                }

            }

            return BestDeliveryBoy;

        }

        public DeliveryBoy BestDeliveryBoy(String area)
        {
            List<DeliveryBoy> list = GetDeliveryBoysinArea(area);

            DeliveryBoy bestdeliveryboy = null;
            int orders = -1;
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].NumberofOrders > orders)
                {
                    orders = list[i].NumberofOrders;
                    bestdeliveryboy = list[i];
                }

            }
            return bestdeliveryboy;

        }
        public List<DeliveryBoy> GetDeliveryBoysinArea(String area)
        {
            DeliveryBoy d = new DeliveryBoy();

            XmlDocument doc = new XmlDocument();
            string path = Path.Combine(Application.StartupPath, @"C:\Users\lenovo\Documents\Visual Studio 2013\Projects\RestaurantProject\RestaurantProject\bin\Debug\DeliveryBoy.xml");

            doc.Load("DeliveryBoy.xml");
            XmlNodeList list = doc.GetElementsByTagName("DeliveryBoy");
            List<DeliveryBoy> deliveryboys = new List<DeliveryBoy>();
            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList childerns = list[i].ChildNodes;

                string id = childerns[0].Name;
                string idvaluue = childerns[0].InnerText;

                string name = childerns[1].Name;
                string namevalue = childerns[1].InnerText; ;

                string phone = childerns[2].Name;
                string phonevalue = childerns[2].InnerText; ;

                string AreaCode = childerns[3].Name;
                string areacodevalue = childerns[3].InnerText;

                string numberodorders = childerns[4].Name;
                string nuvalue = childerns[4].InnerText;

                if (areacodevalue.Equals(area))
                {

                    d = new DeliveryBoy(idvaluue, namevalue, phonevalue, areacodevalue, nuvalue);
                    deliveryboys.Add(d);
                }

            }
            return deliveryboys;
        }

        public List<string> GetDeliveryBoys_DELIVERY(String area)
        {
            string d = "";

            XmlDocument doc = new XmlDocument();
            doc.Load("Delivery.xml");
            XmlNodeList list = doc.GetElementsByTagName("Delivery");

            List<string> deliveryboys_ID = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;

                if (childerns[0].InnerText == area)
                    for (int j = 1; j < childerns.Count; j++)
                    {
                        if (childerns[j].InnerText.Length > 3)
                            return deliveryboys_ID;

                        string AreaCode = childerns[j].Name;
                        string areacodevalue = childerns[j].InnerText;

                        d = areacodevalue;
                        deliveryboys_ID.Add(d);
                    }
            }
            return deliveryboys_ID;
        }

        public DeliveryBoy order2(string area)
        {
            DeliveryBoyxml d = new DeliveryBoyxml();
            List<string> IDs = d.GetDeliveryBoys_DELIVERY(area);

            Random random = new Random();
            int r = random.Next(IDs.Count);
            string id = IDs[r];

            List<DeliveryBoy> list_deliveryBoys = d.GetDeliveryBoysinArea(area);

            for (int i = 0; i < list_deliveryBoys.Count; i++)
            {
                DeliveryBoy db = list_deliveryBoys[i];
                if (db.id == id)
                {
                    int orders = db.NumberofOrders + 1;
                    XmlDocument doc = new XmlDocument();

                    doc.Load("DeliveryBoy.xml");

                    XmlNodeList list2 = doc.GetElementsByTagName("DeliveryBoy");

                    for (int j = 0; j < list2.Count; j++)
                    {

                        XmlNodeList childerns = list2[i].ChildNodes;

                        string idd = childerns[0].Name;
                        string iddvaluue = childerns[0].InnerText;

                        string name = childerns[1].Name;
                        string namevalue = childerns[1].InnerText; ;

                        string phone = childerns[2].Name;
                        string phonevalue = childerns[2].InnerText; ;

                        string AreaCode = childerns[3].Name;
                        string areacodevalue = childerns[3].InnerText;

                        string numberodorders = childerns[4].Name;
                        string nuvalue = childerns[4].InnerText;

                        if (iddvaluue.Equals(db.id) && namevalue.Equals(db.name) && phonevalue.Equals(db.phone))
                        {

                            XmlElement root = doc.DocumentElement;

                            childerns[4].InnerText = orders.ToString();

                            doc.Save("DeliveryBoy.xml");
                            break;
                        }

                    }
                    return db;
                }
            }
            return null;
        }
      
      public DeliveryBoy order(string area)
        {
            List<DeliveryBoy> list = GetDeliveryBoysinArea(area);

            Random random = new Random();
            int r = random.Next(list.Count);

            DeliveryBoy db = list[r];
        //    MessageBox.Show(db.name + "  elly hywasl el order");
            db.NumberofOrders++;
            string orders = db.NumberofOrders.ToString();

            XmlDocument doc = new XmlDocument();

            string path = Path.Combine(Application.StartupPath, @"C:\Users\lenovo\Documents\Visual Studio 2013\Projects\RestaurantProject\RestaurantProject\bin\Debug\DeliveryBoy.xml");

            doc.Load(path);
            XmlNodeList list2 = doc.GetElementsByTagName("DeliveryBoy");

            for (int i = 0; i < list2.Count; i++)
            {

                XmlNodeList childerns = list2[i].ChildNodes;

                string id = childerns[0].Name;
                string idvaluue = childerns[0].InnerText;

                string name = childerns[1].Name;
                string namevalue = childerns[1].InnerText; ;

                string phone = childerns[2].Name;
                string phonevalue = childerns[2].InnerText; ;

                string AreaCode = childerns[3].Name;
                string areacodevalue = childerns[3].InnerText;

                string numberodorders = childerns[4].Name;
                string nuvalue = childerns[4].InnerText;

                if (idvaluue.Equals(db.id) && namevalue.Equals(db.name) && phonevalue.Equals(db.phone))
                {

                    XmlElement root = doc.DocumentElement;


                    childerns[4].InnerText = orders;

                    doc.Save("DeliveryBoy.xml");
                    break;
                }

            }
       //     MessageBox.Show("done");
            return db;
        }
    }
   
    
    
    
  public  class Deliveryxml
    {
        bool exist = false;

       
        public void GetArea(string area)
        {      

      //  string path = Path.Combine(Application.StartupPath, @"C:\Users\lenovo\Documents\Visual Studio 2013\Projects\RestaurantProject\RestaurantProject\bin\Debug\Menu.xml");

            XmlDocument doc = new XmlDocument();
            if (File.Exists("Delivery.xml"))
            {
                doc.Load("Delivery.xml");

                XmlNodeList list = doc.GetElementsByTagName("Delivery");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childerns = list[i].ChildNodes;
                    String areaa = childerns[0].Name;
                    string areaavalue = childerns[0].InnerText;
                    if (areaavalue == area)
                    {
                        exist = true;
                        break;
                    }
                }
            }
            }
          
      
        }
    }
