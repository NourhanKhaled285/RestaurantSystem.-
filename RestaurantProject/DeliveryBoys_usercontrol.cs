using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantProject
{
    public partial class DeliveryBoys_usercontrol : UserControl
    {

        DeliveryBoyxml xml = new DeliveryBoyxml();

        public DeliveryBoys_usercontrol()
        {
            InitializeComponent();
        }

        private void cmb_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
             dataGridView1.Rows.Clear();
            String area = cmb_Area.SelectedItem.ToString();
          List<DeliveryBoy>list=  xml.GetDeliveryBoysinArea(area);
          for (int i = 0; i < list.Count; i++)
          {
              DeliveryBoy a = list[i];
              dataGridView1.Rows.Add(new string[] { a.id, a.name, a.phone, a.area, a.NumberofOrders.ToString() });
          
          }
          MessageBox.Show("Best Delivery Boy --> "+xml.BestDeliveryBoy(area).name);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DeliveryBoys_usercontrol_Load(object sender, EventArgs e)
        {
            
            DeliveryBoy best = xml.BestDeliveryBoy_AllAreas();
            lbl_dbID.Text = best.id;
            lbl_dbName.Text = best.name;
            lbl_dbPhone.Text = best.phone;
            lbl_dbArea.Text = best.area;
            lbl_dbOrders.Text = best.NumberofOrders.ToString();

            
        }
    }
}
