using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace RestaurantProject
{
   [XmlType("food")]

  public  class food
    {
       
       [XmlElement("id")]

        public string id { get; set; }
       
       [XmlElement("name")]

        public string name { get; set; }
       
       [XmlElement("price")]

        public float price { get; set; }

       [XmlElement("description")]
      public string description { get; set; }

       [XmlElement("quantity")]
       public int quantity { get; set; }
    
       [XmlElement("image")]
        public string image { get; set; }

             [XmlElement("sold")]
         public int sold { get; set; }
      public food()
        { }

      
    }
}
