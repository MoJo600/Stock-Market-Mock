namespace Stock_app
{
    partial class Container
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.marketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockStateSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketByOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftCorpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appleIncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketByPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftCorpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.appleIncToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // marketToolStripMenuItem
            // 
            this.marketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginTradingToolStripMenuItem,
            this.stopTradingToolStripMenuItem,
            this.toolStripMenuItem2});
            this.marketToolStripMenuItem.Name = "marketToolStripMenuItem";
            this.marketToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.marketToolStripMenuItem.Text = "Market<<Closed>>";
            this.marketToolStripMenuItem.Click += new System.EventHandler(this.marketToolStripMenuItem_Click);
            // 
            // beginTradingToolStripMenuItem
            // 
            this.beginTradingToolStripMenuItem.Name = "beginTradingToolStripMenuItem";
            this.beginTradingToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.beginTradingToolStripMenuItem.Text = "Begin Trading";
            this.beginTradingToolStripMenuItem.Click += new System.EventHandler(this.beginTradingToolStripMenuItem_Click);
            // 
            // stopTradingToolStripMenuItem
            // 
            this.stopTradingToolStripMenuItem.Name = "stopTradingToolStripMenuItem";
            this.stopTradingToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.stopTradingToolStripMenuItem.Text = "Stop Trading";
            this.stopTradingToolStripMenuItem.Click += new System.EventHandler(this.stopTradingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 30);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockStateSummaryToolStripMenuItem,
            this.marketByOrderToolStripMenuItem,
            this.marketByPriceToolStripMenuItem});
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.watchToolStripMenuItem.Text = "Watch";
            this.watchToolStripMenuItem.Click += new System.EventHandler(this.watchToolStripMenuItem_Click);
            // 
            // stockStateSummaryToolStripMenuItem
            // 
            this.stockStateSummaryToolStripMenuItem.Name = "stockStateSummaryToolStripMenuItem";
            this.stockStateSummaryToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.stockStateSummaryToolStripMenuItem.Text = "Stock State Summary";
            this.stockStateSummaryToolStripMenuItem.Click += new System.EventHandler(this.stockStateSummaryToolStripMenuItem_Click);
            // 
            // marketByOrderToolStripMenuItem
            // 
            this.marketByOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftCorpToolStripMenuItem,
            this.appleIncToolStripMenuItem,
            this.facebookToolStripMenuItem});
            this.marketByOrderToolStripMenuItem.Name = "marketByOrderToolStripMenuItem";
            this.marketByOrderToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.marketByOrderToolStripMenuItem.Text = "Market By Order";
            // 
            // microsoftCorpToolStripMenuItem
            // 
            this.microsoftCorpToolStripMenuItem.Name = "microsoftCorpToolStripMenuItem";
            this.microsoftCorpToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.microsoftCorpToolStripMenuItem.Text = "Microsoft Corp.";
            this.microsoftCorpToolStripMenuItem.Click += new System.EventHandler(this.microsoftCorpToolStripMenuItem_Click);
            // 
            // appleIncToolStripMenuItem
            // 
            this.appleIncToolStripMenuItem.Name = "appleIncToolStripMenuItem";
            this.appleIncToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.appleIncToolStripMenuItem.Text = "Apple Inc.";
            this.appleIncToolStripMenuItem.Click += new System.EventHandler(this.appleIncToolStripMenuItem_Click);
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // marketByPriceToolStripMenuItem
            // 
            this.marketByPriceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftCorpToolStripMenuItem1,
            this.appleIncToolStripMenuItem1,
            this.facebookToolStripMenuItem1});
            this.marketByPriceToolStripMenuItem.Name = "marketByPriceToolStripMenuItem";
            this.marketByPriceToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.marketByPriceToolStripMenuItem.Text = "Market By Price";
            // 
            // microsoftCorpToolStripMenuItem1
            // 
            this.microsoftCorpToolStripMenuItem1.Name = "microsoftCorpToolStripMenuItem1";
            this.microsoftCorpToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.microsoftCorpToolStripMenuItem1.Text = "Microsoft Corp.";
            this.microsoftCorpToolStripMenuItem1.Click += new System.EventHandler(this.microsoftCorpToolStripMenuItem1_Click);
            // 
            // appleIncToolStripMenuItem1
            // 
            this.appleIncToolStripMenuItem1.Name = "appleIncToolStripMenuItem1";
            this.appleIncToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.appleIncToolStripMenuItem1.Text = "Apple Inc.";
            this.appleIncToolStripMenuItem1.Click += new System.EventHandler(this.appleIncToolStripMenuItem1_Click);
            // 
            // facebookToolStripMenuItem1
            // 
            this.facebookToolStripMenuItem1.Name = "facebookToolStripMenuItem1";
            this.facebookToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.facebookToolStripMenuItem1.Text = "Facebook ";
            this.facebookToolStripMenuItem1.Click += new System.EventHandler(this.facebookToolStripMenuItem1_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bidToolStripMenuItem,
            this.askToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // bidToolStripMenuItem
            // 
            this.bidToolStripMenuItem.Name = "bidToolStripMenuItem";
            this.bidToolStripMenuItem.Size = new System.Drawing.Size(113, 30);
            this.bidToolStripMenuItem.Text = "Bid";
            this.bidToolStripMenuItem.Click += new System.EventHandler(this.bidToolStripMenuItem_Click);
            // 
            // askToolStripMenuItem
            // 
            this.askToolStripMenuItem.Name = "askToolStripMenuItem";
            this.askToolStripMenuItem.Size = new System.Drawing.Size(113, 30);
            this.askToolStripMenuItem.Text = "Ask";
            this.askToolStripMenuItem.Click += new System.EventHandler(this.askToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalTileToolStripMenuItem,
            this.verticalTileToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.windowsToolStripMenuItem.Text = "Windows";
            this.windowsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalTileToolStripMenuItem
            // 
            this.horizontalTileToolStripMenuItem.Name = "horizontalTileToolStripMenuItem";
            this.horizontalTileToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.horizontalTileToolStripMenuItem.Text = "Horizontal Tile";
            this.horizontalTileToolStripMenuItem.Click += new System.EventHandler(this.horizontalTileToolStripMenuItem_Click);
            // 
            // verticalTileToolStripMenuItem
            // 
            this.verticalTileToolStripMenuItem.Name = "verticalTileToolStripMenuItem";
            this.verticalTileToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.verticalTileToolStripMenuItem.Text = "Vertical Tile";
            this.verticalTileToolStripMenuItem.Click += new System.EventHandler(this.verticalTileToolStripMenuItem_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 431);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Container";
            this.Text = "Container";
            this.Load += new System.EventHandler(this.Container_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem marketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginTradingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTradingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stockStateSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketByOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftCorpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appleIncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketByPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftCorpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem appleIncToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askToolStripMenuItem;
    }
}