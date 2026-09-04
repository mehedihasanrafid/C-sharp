namespace CSharpProject
{
    partial class MonthlyCost
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblTotalCost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVMonthlySale = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonthlySale)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "<- Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblTotalCost
            // 
            this.LblTotalCost.AutoSize = true;
            this.LblTotalCost.Location = new System.Drawing.Point(356, 82);
            this.LblTotalCost.Name = "LblTotalCost";
            this.LblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.LblTotalCost.TabIndex = 3;
            this.LblTotalCost.Text = "Total Cost";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVMonthlySale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 272);
            this.panel1.TabIndex = 4;
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
            this.Date,
            this.Quantity,
            this.BuyingPrice,
            this.Total});
            this.DGVMonthlySale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMonthlySale.Location = new System.Drawing.Point(0, 0);
            this.DGVMonthlySale.Name = "DGVMonthlySale";
            this.DGVMonthlySale.ReadOnly = true;
            this.DGVMonthlySale.Size = new System.Drawing.Size(800, 272);
            this.DGVMonthlySale.TabIndex = 1;
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
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Purchasing Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // BuyingPrice
            // 
            this.BuyingPrice.DataPropertyName = "BuyingPrice";
            this.BuyingPrice.HeaderText = "Buying Price";
            this.BuyingPrice.Name = "BuyingPrice";
            this.BuyingPrice.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // MonthlyCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTotalCost);
            this.Controls.Add(this.BtnBack);
            this.Name = "MonthlyCost";
            this.Text = "MonthlyCost";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonthlySale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblTotalCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVMonthlySale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}