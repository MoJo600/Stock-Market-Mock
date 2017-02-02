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
    public partial class MarketByPrice1 : Form, StockMarketDisplay
    {
        public MarketByPrice1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(10);
        }


        string identity = "MicrosoftP";

        int bidNumber;
        float bidTotalVolume;
        double bitTotalPrice;
        int askNumber;
        float askTotalVolume;
        float askTotalPrice;


        private void MarketByPrice1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Update(StockMarket data)
        {

            RealtimeData stock = (RealtimeData)data;
            SellOrder[] sellorderz = stock.companies[0].sellorders;
            BuyOrder[] buyorderz = stock.companies[0].buyorders;

            int secret = 0;
            if (stock.companies[0].lastOrder.Equals("BuyOrder"))
            {

                BuyOrder mybuy = stock.companies[0].getLastBuyOrder();
                    for (int k = 0; k < dataGridView1.Rows.Count; ++k)
                    {
                        if (dataGridView1.Rows[k].Cells[2].Value != null && mybuy != null)
                        {
                            if ((float)dataGridView1.Rows[k].Cells[2].Value == (float)mybuy.getPrice())
                            {
                                ++secret;
                                dataGridView1.Rows[k].Cells[0].Value = (int)dataGridView1.Rows[k].Cells[0].Value + 1;
                                dataGridView1.Rows[k].Cells[1].Value = (double)dataGridView1.Rows[k].Cells[1].Value + (float)mybuy.orderSize;
                            }
                        }
                    }
                    if (secret == 0 && mybuy != null) 
                        addToViewBuy(mybuy.getPrice(), mybuy.orderSize);
                    secret = 0;
                    orderBuyView();
            }

            else
            {
                secret = 0;
                SellOrder mysell = stock.companies[0].getLastSellOrder();
                    for (int k = 0; k < dataGridView1.Rows.Count; ++k)
                    {
                        if (dataGridView1.Rows[k].Cells[4].Value != null && mysell != null)
                        {
                            if ((float)dataGridView1.Rows[k].Cells[4].Value == mysell.getPrice())
                            {
                                ++secret;
                                dataGridView1.Rows[k].Cells[5].Value = (int)dataGridView1.Rows[k].Cells[5].Value + 1;
                                dataGridView1.Rows[k].Cells[3].Value = (double)dataGridView1.Rows[k].Cells[3].Value + mysell.orderSize;
                            }
                        }
                    }
                    if (secret == 0 && mysell != null)
                        addToViewSell(mysell.getPrice(), mysell.orderSize);
                    secret = 0;
                    orderSellView();
                
            }




        }

        public void addToViewBuy(float price, double size)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[2].Value == null || dataGridView1.Rows[i].Cells[2].Value == string.Empty)
                {
                    dataGridView1.Rows[i].Cells[0].Value = 1;
                    dataGridView1.Rows[i].Cells[1].Value = size;
                    dataGridView1.Rows[i].Cells[2].Value = price;
                    break;

                }

            }

        }

        public void orderBuyView()
        {
            float highest = 0 ;
            double orderss = 0;
            int mecase = 0;
            while (mecase < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[mecase].Cells[2].Value != null)
                {
                    highest = (float)dataGridView1.Rows[mecase].Cells[2].Value;
                    orderss = (double)dataGridView1.Rows[mecase].Cells[1].Value;
                }
                
                int index = mecase;
                if (dataGridView1.Rows[mecase].Cells[2].Value != null)
                {
                    highest = (float)dataGridView1.Rows[mecase].Cells[2].Value;
                    for (int i = mecase; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value != null)
                        {
                            if (highest < (float)dataGridView1.Rows[i].Cells[2].Value)
                            {
                                highest = (float)dataGridView1.Rows[i].Cells[2].Value; index = i;
                                orderss = (double)dataGridView1.Rows[i].Cells[1].Value;
                            }
                        }

                    }

                    dataGridView1.Rows[index].Cells[2].Value = dataGridView1.Rows[mecase].Cells[2].Value;
                    dataGridView1.Rows[index].Cells[1].Value = dataGridView1.Rows[mecase].Cells[1].Value;
                    if (mecase != index)
                    {
                        dataGridView1.Rows[mecase].Cells[2].Value = highest;
                        dataGridView1.Rows[mecase].Cells[1].Value = orderss;
                    }

                }
                ++mecase;

            }



        }


        public void orderSellView()
        {

            float highest = 0;
            double orderss = 0;
            int mecase = 0;
            while (mecase < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[mecase].Cells[4].Value != null)
                {
                    highest = (float)dataGridView1.Rows[mecase].Cells[4].Value;
                    orderss = (double)dataGridView1.Rows[mecase].Cells[3].Value;
                }

                int index = mecase;
                if (dataGridView1.Rows[mecase].Cells[4].Value != null)
                {
                    highest = (float)dataGridView1.Rows[mecase].Cells[4].Value;
                    for (int i = mecase; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells[4].Value != null)
                        {
                            if (highest < (float)dataGridView1.Rows[i].Cells[4].Value)
                            {
                                highest = (float)dataGridView1.Rows[i].Cells[4].Value; index = i;
                                orderss = (double)dataGridView1.Rows[i].Cells[3].Value;
                            }
                        }

                    }

                    dataGridView1.Rows[index].Cells[4].Value = dataGridView1.Rows[mecase].Cells[4].Value;
                    dataGridView1.Rows[index].Cells[3].Value = dataGridView1.Rows[mecase].Cells[3].Value;
                    if (mecase != index)
                    {
                        dataGridView1.Rows[mecase].Cells[4].Value = highest;
                        dataGridView1.Rows[mecase].Cells[3].Value = orderss;
                    }

                }
                ++mecase;

            }





        }





        public void addToViewSell(float price, double size)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[4].Value == null || dataGridView1.Rows[i].Cells[2].Value == string.Empty)
                {
                    dataGridView1.Rows[i].Cells[5].Value = 1;
                    dataGridView1.Rows[i].Cells[3].Value = size;
                    dataGridView1.Rows[i].Cells[4].Value = price;
                    break;

                }

            }
            
        }


    }

}
