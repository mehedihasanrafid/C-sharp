namespace CSharpProject
{
    partial class Inventory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnNewProduct = new System.Windows.Forms.Button();
            this.BtnManagerInfo = new System.Windows.Forms.Button();
            this.BtnDashBoard = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSalesmanInfo = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVInventory = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnNewProduct);
            this.panel2.Controls.Add(this.BtnManagerInfo);
            this.panel2.Controls.Add(this.BtnDashBoard);
            this.panel2.Controls.Add(this.BtnLogout);
            this.panel2.Controls.Add(this.BtnSalesmanInfo);
            this.panel2.Controls.Add(this.BtnInventory);
            this.panel2.Controls.Add(this.BtnCategory);
            this.panel2.Controls.Add(this.BtnAddEmployee);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 436);
            this.panel2.TabIndex = 2;
            // 
            // BtnNewProduct
            // 
            this.BtnNewProduct.Location = new System.Drawing.Point(3, 346);
            this.BtnNewProduct.Name = "BtnNewProduct";
            this.BtnNewProduct.Size = new System.Drawing.Size(144, 33);
            this.BtnNewProduct.TabIndex = 7;
            this.BtnNewProduct.Text = "New Product";
            this.BtnNewProduct.UseVisualStyleBackColor = true;
            // 
            // BtnManagerInfo
            // 
            this.BtnManagerInfo.Location = new System.Drawing.Point(3, 307);
            this.BtnManagerInfo.Name = "BtnManagerInfo";
            this.BtnManagerInfo.Size = new System.Drawing.Size(144, 33);
            this.BtnManagerInfo.TabIndex = 6;
            this.BtnManagerInfo.Text = "ManagerInfo";
            this.BtnManagerInfo.UseVisualStyleBackColor = true;
            // 
            // BtnDashBoard
            // 
            this.BtnDashBoard.Location = new System.Drawing.Point(3, 50);
            this.BtnDashBoard.Name = "BtnDashBoard";
            this.BtnDashBoard.Size = new System.Drawing.Size(144, 33);
            this.BtnDashBoard.TabIndex = 5;
            this.BtnDashBoard.Text = "Dashboard";
            this.BtnDashBoard.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Red;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(3, 400);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(144, 33);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            // 
            // BtnSalesmanInfo
            // 
            this.BtnSalesmanInfo.Location = new System.Drawing.Point(3, 268);
            this.BtnSalesmanInfo.Name = "BtnSalesmanInfo";
            this.BtnSalesmanInfo.Size = new System.Drawing.Size(144, 33);
            this.BtnSalesmanInfo.TabIndex = 3;
            this.BtnSalesmanInfo.Text = "SalesmanInfo ";
            this.BtnSalesmanInfo.UseVisualStyleBackColor = true;
            // 
            // BtnInventory
            // 
            this.BtnInventory.Location = new System.Drawing.Point(3, 229);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(144, 33);
            this.BtnInventory.TabIndex = 2;
            this.BtnInventory.Text = "Inventory";
            this.BtnInventory.UseVisualStyleBackColor = true;
            // 
            // BtnCategory
            // 
            this.BtnCategory.Location = new System.Drawing.Point(3, 190);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(144, 33);
            this.BtnCategory.TabIndex = 1;
            this.BtnCategory.Text = "Category";
            this.BtnCategory.UseVisualStyleBackColor = true;
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(3, 151);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(144, 33);
            this.BtnAddEmployee.TabIndex = 0;
            this.BtnAddEmployee.Text = "Add Employee";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVInventory);
            this.panel1.Location = new System.Drawing.Point(168, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 285);
            this.panel1.TabIndex = 3;
            // 
            // DGVInventory
            // 
            this.DGVInventory.AllowUserToAddRows = false;
            this.DGVInventory.AllowUserToDeleteRows = false;
            this.DGVInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProductName,
            this.CategoryName,
            this.ProductCompany,
            this.BuyingPrice,
            this.SellingPrice,
            this.Date,
            this.Quantity});
            this.DGVInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVInventory.Location = new System.Drawing.Point(0, 0);
            this.DGVInventory.Name = "DGVInventory";
            this.DGVInventory.ReadOnly = true;
            this.DGVInventory.Size = new System.Drawing.Size(828, 285);
            this.DGVInventory.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(485, 95);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(322, 95);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(138, 20);
            this.LblSearch.TabIndex = 5;
            this.LblSearch.Text = "Search Product ";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Product ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryName.DataPropertyName = "name";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // ProductCompany
            // 
            this.ProductCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCompany.DataPropertyName = "ProductCompany";
            this.ProductCompany.HeaderText = "Products Company";
            this.ProductCompany.Name = "ProductCompany";
            this.ProductCompany.ReadOnly = true;
            // 
            // BuyingPrice
            // 
            this.BuyingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BuyingPrice.DataPropertyName = "BuyingPrice";
            this.BuyingPrice.HeaderText = "Buying Price";
            this.BuyingPrice.Name = "BuyingPrice";
            this.BuyingPrice.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Purchase Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 70;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 468);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnNewProduct;
        private System.Windows.Forms.Button BtnManagerInfo;
        private System.Windows.Forms.Button BtnDashBoard;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSalesmanInfo;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVInventory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}