﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_app
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new PlaceBid());
            //Application.Run(new SellOrder());
          //  Application.Run(new StockSum());
            Application.Run(new Container());
            //Application.Run(new StockSum());
        }
    }
}