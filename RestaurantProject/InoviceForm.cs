using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantProject
{
    public partial class InoviceForm : Form
    {
        public InoviceForm(string price, string discount, List<DataGridViewRow> list,DeliveryBoy boy)
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
            if (Main_Menu.premium)
            {
                lblCustInf.Text = "Bill to :  0" + Main_Menu.CustomerPhone.ToString() + Environment.NewLine + "Premium Customer  " + Environment.NewLine + "  discount" + Main_Menu.Discount_Percent + " %";
            }
            else
                lblCustInf.Text = "Bill to :  0" + Main_Menu.CustomerPhone.ToString() + Environment.NewLine;

            lblShip.Text = "Ship To: " + Environment.NewLine+ Main_Menu.Full_Address+ Environment.NewLine+"Deliver Boy :"+boy.name + Environment.NewLine+ boy.phone;
            foreach(DataGridViewRow r in list)
            {
                ListViewItem l_item = new ListViewItem();

                l_item.Text=r.Cells[0].Value.ToString();
                l_item.SubItems.Add(r.Cells[1].Value.ToString());
                l_item.SubItems.Add(r.Cells[2].Value.ToString());
                l_item.SubItems.Add(r.Cells[3].Value.ToString());
                l_item.SubItems.Add(r.Cells[4].Value.ToString());
             //   l_item.SubItems.Add(r.Cells["Total Price"].Value.ToString());

                listView1.Items.Add(l_item);
            }

            lbl_Total.Text = price + ".LE";

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void InoviceForm_Load(object sender, EventArgs e)
        {
            using (var bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height))
            {
                this.PnlInvoice.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Resources\Invoices\");
                bitmap.Save(Application.StartupPath + @"\Resources\Invoices\" + Main_Menu.CustomerPhone + ".png");
               
            }
        }

        private void lblCompany_Click(object sender, EventArgs e)
        {

        }
    }
}
