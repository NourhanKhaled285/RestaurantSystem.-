using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace RestaurantProject
{
      [Serializable, XmlRoot("menu")]

   public class Menu
    {
          [XmlElement("food")]

          public List<food> menuLst;

          public Menu()
          {

              menuLst = new List<food>();
          }

    }
}
