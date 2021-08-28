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


namespace RestaurantProject
{
    public partial class Chartusercontrol : UserControl
    {


        public Chartusercontrol()
        {
            InitializeComponent();

            DeliveryChartRefresher(Main_Menu.area);
            BoysChartRefresher();

        }

        private void BarChart_Click(object sender, EventArgs e)
        {

        }


        public void DeliveryChartRefresher(string area)
        {

            BarChart.Series["Delivery"].Points.Clear();
            PieChart.Series["Delivery"].Points.Clear();
            BarChart.Titles.Clear();


            BarChart.Titles.Add("Deliveries of waffles : " + area);

            if (DeliverySoldMeals.Areas_Menu.ContainsKey(area))
            {

                List<FoodData> t = DeliverySoldMeals.Areas_Menu[area];

                foreach (FoodData value in t)
                {
                    BarChart.Series["Delivery"].Points.AddXY(value.FoodName, value.purchase_count);
                    PieChart.Series["Delivery"].Points.AddXY(value.FoodName, value.purchase_count);
                    PieChart.Series["Delivery"]["PieLabelStyle"] = "Disabled";

                }




            }


        }

        public  void BoysChartRefresher()
        {
            boysChart.Series["NumOfOrders"].Points.Clear();
            XmlDocument doc = new XmlDocument();

            doc.Load("DeliveryBoy.xml");
            XmlNodeList list = doc.GetElementsByTagName("DeliveryBoy");

            boysChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList childerns = list[i].ChildNodes;


                string name = childerns[1].Name;
                string namevalue = childerns[1].InnerText; ;
             

                string numberodorders = childerns[4].Name;
                string nuvalue = childerns[4].InnerText;
                int NumberOfOrders = int.Parse(nuvalue);


                boysChart.Series["NumOfOrders"].Points.AddXY( namevalue,nuvalue);

                


            }




        }

        private void Chartusercontrol_Load(object sender, EventArgs e)
        {

        }

        private void PieChart_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Area_SelectedIndexChanged(object sender, EventArgs e)

        {

            string area = cmb_Area.SelectedItem.ToString();

            DeliveryChartRefresher(area);

        }

        private void cmb_Area_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string area = cmb_Area.SelectedItem.ToString();

            DeliveryChartRefresher(area);
        }





    }
}
