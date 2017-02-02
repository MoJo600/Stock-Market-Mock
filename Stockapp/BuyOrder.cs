using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_app
{
    public partial class BuyOrder : Form, Order
    {
        public BuyOrder()
        {
            InitializeComponent();
        }
        public BuyOrder(BuyOrder j)
        {
            this.date = j.date;
            this.orderSize = j.orderSize;
            this.orderPrice = j.getPrice();

        }


         public string date;
         public double orderSize;
         private float orderPrice;

        public float getPrice()
        {
            return orderPrice;
        }
        public void setPrice(float b)
        {
            orderPrice = b;

        }

       


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BuyOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(comboBox1.SelectedItem == null) && !(textBox1.Text.Length == 0) && !(textBox2.Text.Length == 0))
            {
                int i = 0;
                string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

                switch (selected)
                {

                    case "Microsoft Corporation":
                        date = DateTime.Now.ToString("M/d/yyyy");
                        orderSize = Convert.ToDouble(textBox1.Text);
                        orderPrice = (float)Convert.ToDouble(textBox2.Text);
                        Container parent = (Container)this.MdiParent;
                        RealtimeData stock = (RealtimeData)parent.theStockMarket;
                        for (i = 0; i < stock.companies.Length; ++i)
                        {
                            if (stock.companies[i].getName().Equals("Microsoft"))
                                break;
                        }

                        stock.companies[i].addBuyOrder(this);
                        stock.companies[i].lastOrder = "BuyOrder";
                        stock.companies[i].lastUpdated = true;
                        for (int j = 0; j < stock.companies.Length; ++j)
                        {
                            if (j != i)
                                stock.companies[j].lastUpdated = false;
                        }
                        stock.notify();


                        break;
                    case "Apple Inc.":
                        date = DateTime.Now.ToString("M/d/yyyy");
                        orderSize = Convert.ToDouble(textBox1.Text);
                        orderPrice = (float)Convert.ToDouble(textBox2.Text);
                        parent = (Container)this.MdiParent;
                        stock = (RealtimeData)parent.theStockMarket;
                        for (i = 0; i < stock.companies.Length; ++i)
                        {
                            if (stock.companies[i].getName().Equals("Apple"))
                                break;
                        }

                        stock.companies[i].addBuyOrder(this);
                        stock.companies[i].lastOrder = "BuyOrder";
                        stock.companies[i].lastUpdated = true;
                        for (int j = 0; j < stock.companies.Length; ++j)
                        {
                            if (j != i)
                                stock.companies[j].lastUpdated = false;
                        }
                        stock.notify();

                        break;
                    case "Facebook":
                        date = DateTime.Now.ToString("M/d/yyyy");
                        orderSize = Convert.ToDouble(textBox1.Text);
                        orderPrice = (float)Convert.ToDouble(textBox2.Text);
                        parent = (Container)this.MdiParent;
                        stock = (RealtimeData)parent.theStockMarket;
                        for (i = 0; i < stock.companies.Length; ++i)
                        {
                            if (stock.companies[i].getName().Equals("Facebook"))
                                break;
                        }

                        stock.companies[i].addBuyOrder(this);
                        stock.companies[i].lastOrder = "BuyOrder";
                        stock.companies[i].lastUpdated = true;
                        for (int j = 0; j < stock.companies.Length; ++j)
                        {
                            if (j != i)
                                stock.companies[j].lastUpdated = false;
                        }
                        stock.notify();
                        break;
                    default:
                        MessageBox.Show("Your company selection was incomprehensible. Please try again.");
                        break;


                }

            }
            else MessageBox.Show("Please supply empty fields");

            this.Close();
        }
    }
}
