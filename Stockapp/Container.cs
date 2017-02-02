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
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            ordersToolStripMenuItem.Enabled = false;
            watchToolStripMenuItem.Enabled = false;
            windowsToolStripMenuItem.Enabled = false;
            stopTradingToolStripMenuItem.Enabled = false;
        }

        

        Boolean key = false;
        public StockMarket theStockMarket=null;


        private void marketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void turnOff()
        {
            
            Form[] children = this.MdiChildren;

            for (int i=0; i < children.Length; ++i)
            {
                
                children[i].Close();

            }



            ordersToolStripMenuItem.Enabled = false;
            watchToolStripMenuItem.Enabled = false;
            windowsToolStripMenuItem.Enabled = false;
            stopTradingToolStripMenuItem.Enabled = false;
            beginTradingToolStripMenuItem.Enabled = true;
            marketToolStripMenuItem.Text = "Market <<Closed>>";

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal); 
        }

        private void verticalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void beginTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marketToolStripMenuItem.Text = "Market <<Open>>";
            beginTradingToolStripMenuItem.Enabled = false;
            ordersToolStripMenuItem.Enabled = true;
            watchToolStripMenuItem.Enabled = true;
            windowsToolStripMenuItem.Enabled = true;
            stopTradingToolStripMenuItem.Enabled = true;
            key = true;
            theStockMarket = new RealtimeData();

            //beginTradingToolStripMenuItem.Visible = false;

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bidToolStripMenuItem_Click(object sender, EventArgs e)
        {


            BuyOrder newMDIChild = new BuyOrder();
            // Set the parent form of the child window. 
            newMDIChild.MdiParent = this;
            // Display the new form. 
            newMDIChild.Show();

           // newMDIChild = this.ActiveMdiChild;



        }

        private void askToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellOrder newMDIChild = new SellOrder();
            // Set the parent form of the child window. 
            newMDIChild.MdiParent = this;
            // Display the new form. 
            newMDIChild.Show(); 


        }

        private void microsoftCorpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarketByOrder1 newMDIChild = new MarketByOrder1();
            // Set the parent form of the child window. 
            newMDIChild.MdiParent = this;
            // Display the new form. 
            theStockMarket.register(newMDIChild);

            newMDIChild.Show();

            theStockMarket.register(newMDIChild);

        }

        private void appleIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarketByOrder2 newMDIChild = new MarketByOrder2();
            // Set the parent form of the child window. 
            newMDIChild.MdiParent = this;
            // Display the new form. 
            newMDIChild.Show();

            theStockMarket.register(newMDIChild);
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarketByOrder3 newMDIChild = new MarketByOrder3();
            // Set the parent form of the child window. 
            newMDIChild.MdiParent = this;
            // Display the new form. 
            newMDIChild.Show();

            theStockMarket.register(newMDIChild);
        }

        private void Container_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stopTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turnOff();

        }

        private void watchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockStateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StockSum newMDIChild = new StockSum();
            // Set the parent form of the child window. 
            newMDIChild.MdiParent = this;
            // Display the new form. 
            newMDIChild.Show();

            theStockMarket.register(newMDIChild);

        }

        private void microsoftCorpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MarketByPrice1 newMDIChild = new MarketByPrice1();
            // Set the parent form of the child window. 
            newMDIChild.MdiParent = this;
            // Display the new form. 
            newMDIChild.Show();

            theStockMarket.register(newMDIChild);
        }

        private void appleIncToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MarketByPrice2 newMDIChild = new MarketByPrice2();
            // Set the parent form of the child window. 
            newMDIChild.MdiParent = this;
            // Display the new form. 
            newMDIChild.Show();

            theStockMarket.register(newMDIChild);


        }

        private void facebookToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MarketByPrice3 newMDIChild = new MarketByPrice3();
            // Set the parent form of the child window. 
            newMDIChild.MdiParent = this;
            // Display the new form. 
            newMDIChild.Show();

            theStockMarket.register(newMDIChild);


        }
    }
}
