namespace CSharpProject
{
    partial class MonthlySale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVMonthlySale = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblTotalSale = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonthlySale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVMonthlySale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 257);
            this.panel1.TabIndex = 0;
            // 
            // DGVMonthlySale
            // 
            this.DGVMonthlySale.AllowUserToAddRows = false;
            this.DGVMonthlySale.AllowUserToDeleteRows = false;
            this.DGVMonthlySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMonthlySale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductCompany,
            this.name,
            this.SellingPrice,
            this.SellQuantity,
            this.Total,
            this.SellDate});
            this.DGVMonthlySale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMonthlySale.Location = new System.Drawing.Point(0, 0);
            this.DGVMonthlySale.Name = "DGVMonthlySale";
            this.DGVMonthlySale.ReadOnly = true;
            this.DGVMonthlySale.Size = new System.Drawing.Size(800, 257);
            this.DGVMonthlySale.TabIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductCompany
            // 
            this.ProductCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCompany.DataPropertyName = "ProductCompany";
            this.ProductCompany.HeaderText = "Product Company";
            this.ProductCompany.Name = "ProductCompany";
            this.ProductCompany.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Category";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // SellQuantity
            // 
            this.SellQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellQuantity.DataPropertyName = "SellQuantity";
            this.SellQuantity.HeaderText = "Sell Quantity";
            this.SellQuantity.Name = "SellQuantity";
            this.SellQuantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // SellDate
            // 
            this.SellDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellDate.DataPropertyName = "SellDate";
            this.SellDate.HeaderText = "Sell Date";
            this.SellDate.Name = "SellDate";
            this.SellDate.ReadOnly = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "<- Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblTotalSale
            // 
            this.LblTotalSale.AutoSize = true;
            this.LblTotalSale.Location = new System.Drawing.Point(350, 53);
            this.LblTotalSale.Name = "LblTotalSale";
            this.LblTotalSale.Size = new System.Drawing.Size(55, 13);
            this.LblTotalSale.TabIndex = 2;
            this.LblTotalSale.Text = "Total Sale";
            // 
            // MonthlySale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTotalSale);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel1);
            this.Name = "MonthlySale";
            this.Text = "MonthlySale";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonthlySale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVMonthlySale;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellDate;
        private System.Windows.Forms.Label LblTotalSale;
    }
}