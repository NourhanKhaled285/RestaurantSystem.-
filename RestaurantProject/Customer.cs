using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace RestaurantProject
{

    [XmlType("item")]

    public class item
    {
        [XmlElement("foodname")]

        public string name;
        [XmlElement("foodprice")]

        public double price;
        [XmlElement("foodquantity")]

        public int quantity;

        public item()
        {

        }
    }



    [XmlType("order")]
    public class Order
    {
        [XmlElement("area")]

        public string area;
        [XmlElement("item")]

        public List<item> items = new List<item>();

        public Order()
        {

        }

    }
    
    
    
    
    
    
    [XmlType("orders")]

    public class Orders
    {
         [XmlElement("order")]

            public List<Order> order = new List<Order>();

         public Orders()
         {

         }

    }


    [ XmlType("customer")]

   public   class Customer
    {
        [XmlElement("phonenum")]

      public  int phone;
        [XmlElement("orders")]

        public Orders orders = new Orders(); 
        [XmlElement("totalprice")]

        public double totalprice;
        [XmlElement("discount")]

        public double discount;
        [XmlElement("numoforders")]

        public int numoforders;

        public Customer()
        {

        }

    }

    [XmlRoot("table")]
    public class customers

    {

                  [XmlElement("customer")]

    public    List<Customer> Allcustomers = new List<Customer>();


    }
}
