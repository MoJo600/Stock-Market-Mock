using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_app
{
    public class RealtimeData : StockMarket
    {
        string tradingDate;
        public company[] companies;
        StockMarketDisplay[] displays;
        public RealtimeData()
        {
            
            companies =new company[3];
            for (int i = 0; i < 3; ++i)
            {
                companies[i] = new company();
            }

            companies[0].setName("Microsoft");
            companies[1].setName("Apple");
            companies[2].setName("Facebook");

            tradingDate = DateTime.Now.ToString("M/d/yyyy");

            displays = new StockMarketDisplay[7];

            


        }

        public void stockIndex()
        {


        }

        public override void register(StockMarketDisplay dis)
        {
            
            for (int i = 0; i < displays.Length; ++i)
            {
                if (displays[i] == null)
                { displays[i] = dis; break; 
                
                
                }

            }




        }

        public override void unregister(StockMarketDisplay dis)
        {

            for (int i = 0; i < displays.Length; ++i)
            {
                if (displays[i]==dis)
                { displays[i] = null; break; }

            }

        }

        public override void notify()
        {
            int j = 0;
            for (int i = 0; i < displays.Length; ++i) {
                if (displays[i] != null)
                {
                    ++j;
                    displays[i].Update(this);
                }
            }
        }

    }
}
