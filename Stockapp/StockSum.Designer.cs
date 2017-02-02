namespace Stock_app
{
    partial class StockSum
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curve = new System.Windows.Forms.DataGridViewImageColumn();
            this.Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Company,
            this.symbol,
            this.OpenPrice,
            this.LastSale,
            this.ChangeNet,
            this.Curve,
            this.Change,
            this.ShareVol});
            this.dataGridView1.Location = new System.Drawing.Point(19, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // symbol
            // 
            this.symbol.HeaderText = "Symbol";
            this.symbol.Name = "symbol";
            // 
            // OpenPrice
            // 
            this.OpenPrice.HeaderText = "Open Price";
            this.OpenPrice.Name = "OpenPrice";
            // 
            // LastSale
            // 
            this.LastSale.HeaderText = "Last Sale";
            this.LastSale.Name = "LastSale";
            // 
            // ChangeNet
            // 
            this.ChangeNet.HeaderText = "Change Net";
            this.ChangeNet.Name = "ChangeNet";
            // 
            // Curve
            // 
            this.Curve.HeaderText = "";
            this.Curve.Name = "Curve";
            this.Curve.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Curve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Change
            // 
            this.Change.HeaderText = "Change %";
            this.Change.Name = "Change";
            // 
            // ShareVol
            // 
            this.ShareVol.HeaderText = "Share Volume";
            this.ShareVol.Name = "ShareVol";
            // 
            // StockSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 508);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockSum";
            this.ShowIcon = false;
            this.Text = "Stock State Summary";
            this.Load += new System.EventHandler(this.StockSum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeNet;
        private System.Windows.Forms.DataGridViewImageColumn Curve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareVol;
    }
}