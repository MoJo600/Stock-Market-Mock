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
    public partial class MarketByOrder1 : Form, StockMarketDisplay
    {
        public MarketByOrder1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(10);

        }

        public void Update(StockMarket data)
        {

            RealtimeData stock = (RealtimeData)data;
            //stock.companies[0].orderBuys();
            //stock.companies[0].orderSells();
            SellOrder[] sellorderz = stock.companies[0].getCopySell();
            BuyOrder[] buyorderz = stock.companies[0].getCopyBuy();
            orderBuys(buyorderz);
            orderSells(sellorderz);


            
                for (int j = 0, i=0; j < buyorderz.Length || i<dataGridView1.Rows.Count ; ++i, ++j)
                {
                     
                    if (buyorderz[j] != null)
                    {

                        dataGridView1.Rows[i].Cells[0].Value = buyorderz[j].orderSize;
                        bidVolume = buyorderz[j].orderSize;
                        dataGridView1.Rows[i].Cells[1].Value = buyorderz[j].getPrice();
                        bidPrice=buyorderz[j].getPrice();

                    }

                }

                for (int j = 0, i = 0; j < sellorderz.Length || i < dataGridView1.Rows.Count; ++i, ++j)
                {

                    if (sellorderz[j] != null)
                    {

                        dataGridView1.Rows[i].Cells[2].Value = sellorderz[j].orderSize;
                        askVolume = sellorderz[j].orderSize;
                        dataGridView1.Rows[i].Cells[3].Value = sellorderz[j].getPrice();
                        askPrice = sellorderz[j].getPrice();

                    }

                }




        }
        string identity = "MicrosoftO";

        float bidPrice;
        double bidVolume;
        double askPrice;
        double askVolume;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MarketByOrder1_FormClosing(object sender, FormClosingEventArgs e) {

            Container parent = (Container)this.MdiParent;
            RealtimeData stock = (RealtimeData)parent.theStockMarket;
            stock.unregister(this);

        }

        public void orderBuys(BuyOrder[] buyorders)
        {

            BuyOrder highest = null;
            int mecase = 0;
            while (mecase < buyorders.Length)
            {
                int index = mecase;
                highest = buyorders[mecase];
                for (int i = mecase; i < buyorders.Length; ++i)
                {
                    if (buyorders[i] != null)
                    {
                        if (highest.getPrice() < buyorders[i].getPrice())
                        { highest = buyorders[i]; index = i; }
                    }

                }

                buyorders[index] = buyorders[mecase];
                buyorders[mecase] = highest;
                ++mecase;

            }




        }

        public void orderSells(SellOrder [] sellorders)
        {
            SellOrder lowest = null;
            int mecase = 0;
            while (mecase < sellorders.Length)
            {
                int index = mecase;
                lowest = sellorders[mecase];
                for (int i = mecase; i < sellorders.Length; ++i)
                {
                    if (sellorders[i] != null)
                    {
                        if (lowest.getPrice() > sellorders[i].getPrice())
                        { lowest = sellorders[i]; index = i; }
                    }

                }

                sellorders[index] = sellorders[mecase];
                sellorders[mecase] = lowest;
                ++mecase;

            }

        }











        private void MarketByOrder1_Load(object sender, EventArgs e)
        {

        }
    }
}
