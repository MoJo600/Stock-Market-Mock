using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_app
{
    public class company
    {

        string companyName;
        private double lastPrice;
        public string lastOrder= "None";
        public SellOrder[] sellorders;
        public BuyOrder[] buyorders;
        public Boolean lastUpdated;
        
        public List<double> successfulO= new List<double>();

        public class specialOrderEn
        {
            public specialOrderEn()
            {


            }

            public double volume=0;
            public double price=0;

        }

        public company()
        {

            sellorders= new SellOrder[20];
            buyorders = new BuyOrder[20];
           

        }

        public void setLastPrice(double c)
        {


        }


     
        public double getLastPrice()
        {

            return lastPrice;
        }


        public double getVolume()
        {

            double volume=0;

            for (int i = 0; i < successfulO.Count; ++i)
            {
                
                volume = volume + successfulO[i];

            }

            return volume;

        }

        public void setName(string b)
        {
            companyName = b;

        }

        public string getName()
        {
            return companyName;
        }

        public void addSellOrder(SellOrder s)
        {

            int i = 0;

            for (i = 0; i < sellorders.Length; i++)
            {
                if (sellorders[i] == null)
                    break;
            }

            sellorders[i] = new SellOrder(s);


        }

        public void addBuyOrder(BuyOrder s)
        {


            int i = 0;

            for (i = 0; i < buyorders.Length; i++)
            {
                if (buyorders[i] == null)
                    break;
            }

            buyorders[i] = new BuyOrder(s);

        }


        public BuyOrder getLastBuyOrder()
        {
            int i = 0;

            for (i = 0; i < buyorders.Length; ++i)
            {
                if (buyorders[i] == null)
                    break;

            }
            if ((i - 1) < 0)
                return null;

            return buyorders[i - 1];

        }

        public SellOrder getLastSellOrder()
        {

            int i = 0;

            for (i = 0; i < sellorders.Length; ++i)
            {
                if (sellorders[i] == null)
                    break;

            }
            if ((i - 1) < 0)
                return null;

            
            return sellorders[i - 1];


        }


        public BuyOrder[] getCopyBuy()
        {

            BuyOrder[] newbuyords = new BuyOrder[20];

            for (int i = 0; i < buyorders.Length; ++i)
            {

                if (buyorders[i] != null)
                {
                    newbuyords[i] = new BuyOrder();
                    newbuyords[i].setPrice(buyorders[i].getPrice());
                    newbuyords[i].orderSize = buyorders[i].orderSize;
                }


            }

            return newbuyords;



        }


        public SellOrder[] getCopySell()
        {

            SellOrder[] newsellords = new SellOrder[20];

            for (int i = 0; i < sellorders.Length; ++i)
            {

                if (sellorders[i] != null)
                {
                    newsellords[i] = new SellOrder();
                    newsellords[i].setPrice(sellorders[i].getPrice());
                    newsellords[i].orderSize = sellorders[i].orderSize;
                }


            }

            return newsellords;



        }
        


    }
}
