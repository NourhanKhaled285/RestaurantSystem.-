using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;


namespace RestaurantProject
{
        [Serializable]

    public class FoodData
    {
        public int purchase_count;

        public string FoodName;
        public FoodData()
        {
            purchase_count = 0;
            FoodName = "";
        }



        public FoodData(string FoodName)
        {
            this.FoodName = FoodName;
        }

    }

        [Serializable]

  public  class DeliverySoldMeals
    {


      //  Main_Menu m = new Main_Menu();


            public  static Dictionary<string, List<FoodData>> Areas_Menu = new Dictionary<string, List<FoodData>>();


            public List<FoodData> innerList = new List<FoodData>();


        List<string> areas;

        BinaryFormatter formatter;

        public DeliverySoldMeals()
        {
            areas = new List<string>();

        //  innerList = new List<FoodData>();
            formatter = new BinaryFormatter();

            if (!File.Exists("Chart.txt"))
            {
             //  areas = m.allAreas();

                XmlDocument doc = new XmlDocument();
                doc.Load("Delivery.xml");
                XmlNodeList list = doc.GetElementsByTagName("Area");

                XmlDocument menudoc = new XmlDocument();
                menudoc.Load("menu file.xml");
                XmlNodeList menulist = menudoc.GetElementsByTagName("name");


                foreach (XmlNode a in list)
                {
                    foreach (XmlNode n in menulist)
                    {
                        FoodData v = new FoodData(n.InnerText);
                        innerList.Add(new FoodData(n.InnerText));


                    }
                    Areas_Menu.Add(a.InnerText, new List<FoodData>(innerList));
                    innerList.Clear();
                }
            }

        }


        public void update_Sold_In_Area(string Area, string foodName, int purchasedNo)
        {
            if (Areas_Menu.ContainsKey(Area))
            {

                List<FoodData> temporary = Areas_Menu[Area];


                foreach (FoodData t in temporary)
                {
                    if (t.FoodName == foodName)
                    {
                        int prev = t.purchase_count;
                        int sold = prev + purchasedNo;
                        t.purchase_count = sold;
                        sold = 0;

                        break;
                    }
                }
                Areas_Menu[Area] = temporary;

                FileStream stream = new FileStream("Chart.txt", FileMode.Create);
                formatter.Serialize(stream, Areas_Menu);
                stream.Close();

            }

        }
            



        public void deserialize()
        {
            Areas_Menu.Clear();
            FileStream stream = new FileStream("Chart.txt", FileMode.Open);
            while (stream.Position != stream.Length)
            {
                Dictionary<string, List<FoodData>> temp = (Dictionary<string, List<FoodData>>)formatter.Deserialize(stream);
                for (int i = 0; i < temp.Count; i++)
                {
                    Areas_Menu.Add(temp.ElementAt(i).Key, temp.ElementAt(i).Value);
                }

            }
            stream.Close();
        }


    }
}
