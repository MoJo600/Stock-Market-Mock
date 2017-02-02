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
    public partial class StockSum : Form, StockMarketDisplay
    {
        public StockSum()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(2);
            dataGridView1.Rows[0].Cells[0].Value = "Microsoft Corporation";
            dataGridView1.Rows[1].Cells[0].Value="Apple Inc.";
            dataGridView1.Rows[2].Cells[0].Value = "Facebook";
            dataGridView1.Rows[0].Cells[2].Value = 35.6;
            dataGridView1.Rows[1].Cells[2].Value = 104.3;
            dataGridView1.Rows[2].Cells[2].Value = 58.2;
            dataGridView1.Rows[0].Cells[1].Value = "MSFT";
            dataGridView1.Rows[1].Cells[1].Value = "AAPL";
            dataGridView1.Rows[2].Cells[1].Value = "FB";
        
         
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 3; j < 8; ++j)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                }

            }

            //DataGridViewImageCell img = new DataGridViewImageCell();
           // Image myim = Image.FromFile(@"C:\Users\Troy\Documents\3352A\BMP\down.bmp");
            Bitmap bit = new Bitmap(Properties.Resources.noChange);
            dataGridView1.Rows[0].Cells[5].Value = bit;
            dataGridView1.Rows[1].Cells[5].Value = bit;
            dataGridView1.Rows[2].Cells[5].Value = bit;

            

        }

        string identity = "StockSum";

        public void Update(StockMarket g)
        {

            RealtimeData stock = (RealtimeData)g;
            //verfifying for all companies
            SellOrder[] sellordsM = stock.companies[0].sellorders;
            BuyOrder[] buyordsM = stock.companies[0].buyorders;
            SellOrder[] sellordsA = stock.companies[1].sellorders;
            BuyOrder[] buyordsA = stock.companies[1].buyorders;
            SellOrder[] sellordsF = stock.companies[2].sellorders;
            BuyOrder[] buyordsF = stock.companies[2].buyorders;

            int index;
            for (index = 0; index < stock.companies.Length; ++index)
            {
                if (stock.companies[index].lastUpdated == true)
                    break;

            }
            float lM;

           
                lM = verifyOrdersM(stock.companies[index].buyorders, stock.companies[index].sellorders, stock, index);
                double volumeM = stock.companies[index].getVolume();

                if (lM != 0)
                {
                    dataGridView1.Rows[index].Cells[3].Value = lM;
                    dataGridView1.Rows[index].Cells[4].Value = (float)(lM - 35.6);
                    float rawp = (float)((lM - 35.6) / 35.6);
                    float percentage = (float)((float)((lM - 35.6)/35.6)*100);
                    dataGridView1.Rows[index].Cells[6].Value = percentage;
                    dataGridView1.Rows[index].Cells[7].Value = volumeM;
                    if (rawp < 0)
                    {
                        Bitmap bit = new Bitmap(Properties.Resources.down);
                        dataGridView1.Rows[index].Cells[5].Value = bit;
                    }
                    if (rawp == 0)
                    {
                        Bitmap bit = new Bitmap(Properties.Resources.noChange);
                        dataGridView1.Rows[index].Cells[5].Value = bit;

                    }
                    if (rawp > 0)
                    {

                        Bitmap bit = new Bitmap(Properties.Resources.up);
                        dataGridView1.Rows[index].Cells[5].Value = bit;
                    }

                    //add function here that does operations;
                }



            
            


            }

            
            
    

            
           
            

        


        public float verifyOrdersM(BuyOrder[] buyords, SellOrder[] sellords, StockMarket stock, int k ){

            RealtimeData stocky = (RealtimeData)stock;

            float lastprice = 0;
            int initializer = 0;

            if (stocky.companies[k].lastOrder.Equals("SellOrder"))
            {
                int determinant = 0;
                for (determinant = 0; determinant < sellords.Length; ++determinant)
                {
                    if (sellords[determinant] == null)
                        if (determinant > 0)
                            break;
                        else return 0;

                }
                --determinant;
                for (int i = 0; i < buyords.Length; ++i)
                {
                    if (buyords[i] != null)
                    {
                        if (sellords[determinant].orderSize == buyords[i].orderSize && sellords[determinant].getPrice() == buyords[i].getPrice())
                        {
                            stocky.companies[k].setLastPrice(sellords[determinant].getPrice());
                            lastprice = sellords[determinant].getPrice();
                            ++initializer;

                        }
                    }
                }
                if (initializer > 0)
                    stocky.companies[k].successfulO.Add(sellords[determinant].orderSize);


            }
            else if(stocky.companies[k].lastOrder.Equals("BuyOrder")){
                int determinant = 0; initializer = 0;
                for (determinant = 0; determinant < buyords.Length; ++determinant)
                {
                    if (buyords[determinant] == null)
                        if (determinant > 0)
                            break;
                        else return 0;
                }
                --determinant;
                for (int i = 0; i < sellords.Length; ++i)
                {
                    if (sellords[i] != null)
                    {
                        if (buyords[determinant].orderSize == sellords[i].orderSize && buyords[determinant].getPrice() == sellords[i].getPrice())
                        {
                            stocky.companies[k].setLastPrice(buyords[determinant].getPrice());
                            lastprice = buyords[determinant].getPrice();
                            ++initializer;
                        }
                    }
                }

                if (initializer > 0)
                    stocky.companies[k].successfulO.Add(buyords[determinant].orderSize);
            }

            return lastprice;


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StockSum_Load(object sender, EventArgs e)
        {

        }
    }
}
