using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace RestaurantProject
{
    public partial class MainForm : Form
    {

        //Main_Menu m = new Main_Menu();
        public MainForm()
        {
            InitializeComponent();
            main_Menu4.usertab.BringToFront();
            panel2.BringToFront();
           //  m.DeserializeMenu(); 
            
        }
      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string path = Path.Combine(Application.StartupPath, @"C:\Users\lenovo\Documents\Visual Studio 2013\Projects\RestaurantProject\RestaurantProject\bin\Debug\Menu.xml");
            XmlSerializer xs = new XmlSerializer(Main_Menu.MenuArray.GetType());

            FileStream fs = new FileStream(path, FileMode.Create);
            xs.Serialize(fs,Main_Menu. MenuArray);
            fs.Close();


            Application.Exit();


        }

      

        private void btn_menu_Click_1(object sender, EventArgs e)
        {
          

        }

     

        private void button2_Click(object sender, EventArgs e)
        {

        


        }

        private void myCart_usercontrol1_Load(object sender, EventArgs e)
        {

        }

        private void btn_info_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            deliveryBoys_usercontrol3.BringToFront();
        }

      

        private void btn_rec_Click(object sender, EventArgs e)
        {
          //  switch_usercontrol1.recommendedTab.BringToFront();
            panel2.BringToFront();
            deliveryBoys_usercontrol3.SendToBack();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void deliveryBoys_usercontrol1_Load(object sender, EventArgs e)
        {

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            main_Menu4.usertab.BringToFront();

         //   switch_usercontrol1.usertab.BringToFront();
            panel2.BringToFront();
            deliveryBoys_usercontrol3.SendToBack();
            chartusercontrol1.SendToBack();


        }

        private void btn_men_Click(object sender, EventArgs e)
        {
            main_Menu4.menutab.BringToFront();
           // switch_usercontrol1.menutab.Show();
            panel2.BringToFront();
            deliveryBoys_usercontrol3.SendToBack();
            chartusercontrol1.SendToBack();

        }

        private void btn_Mycart_Click(object sender, EventArgs e)
        {
            //switch_usercontrol1.carttab.BringToFront();
            main_Menu4.carttab.BringToFront();
            panel2.BringToFront();
            deliveryBoys_usercontrol3.SendToBack();
            chartusercontrol1.SendToBack();
        }

        private void btn_db_Click(object sender, EventArgs e)
        {
            deliveryBoys_usercontrol3.BringToFront();
            panel2.BringToFront();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            chartusercontrol1.BringToFront();
        }

        private void btn_recommended_Click(object sender, EventArgs e)
        {
            main_Menu4.recommendedTab.BringToFront();
            panel2.BringToFront();
            deliveryBoys_usercontrol3.SendToBack();
            chartusercontrol1.SendToBack();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            main_Menu4.previseTab.BringToFront();
            panel2.BringToFront();
            deliveryBoys_usercontrol3.SendToBack();
            chartusercontrol1.SendToBack();
        }

        private void main_Menu4_Load(object sender, EventArgs e)
        {

        }
    }
}
