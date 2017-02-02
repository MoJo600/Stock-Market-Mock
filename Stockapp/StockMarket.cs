using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_app
{
    public abstract class StockMarket
    {
        StockMarketDisplay[] meArray = new StockMarketDisplay[10];

        abstract public void register(StockMarketDisplay g);

        abstract public void unregister(StockMarketDisplay u);

        abstract public void notify();

    }
}
