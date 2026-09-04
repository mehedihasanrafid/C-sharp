namespace CSharpProject
{
    partial class OwnerNewProduct
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
            this.LblNewProduct = new System.Windows.Forms.Label();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.LblPrroductsCompany = new System.Windows.Forms.Label();
            this.LblProduct = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.txtProductsCompany = new System.Windows.Forms.TextBox();
            this.CboxCategory = new System.Windows.Forms.ComboBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGVRequestedProduct = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequestedProduct)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 436);
            this.panel2.TabIndex = 5;
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
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
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
            this.panel1.Controls.Add(this.LblNewProduct);
            this.panel1.Controls.Add(this.BtnAddProduct);
            this.panel1.Controls.Add(this.LblPrroductsCompany);
            this.panel1.Controls.Add(this.LblProduct);
            this.panel1.Controls.Add(this.LblCategory);
            this.panel1.Controls.Add(this.txtProductsCompany);
            this.panel1.Controls.Add(this.CboxCategory);
            this.panel1.Controls.Add(this.txtProduct);
            this.panel1.Location = new System.Drawing.Point(170, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 209);
            this.panel1.TabIndex = 6;
            // 
            // LblNewProduct
            // 
            this.LblNewProduct.AutoSize = true;
            this.LblNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewProduct.Location = new System.Drawing.Point(209, 7);
            this.LblNewProduct.Name = "LblNewProduct";
            this.LblNewProduct.Size = new System.Drawing.Size(110, 20);
            this.LblNewProduct.TabIndex = 12;
            this.LblNewProduct.Text = "New Product";
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnAddProduct.Location = new System.Drawing.Point(260, 149);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(100, 35);
            this.BtnAddProduct.TabIndex = 11;
            this.BtnAddProduct.Text = "Add";
            this.BtnAddProduct.UseVisualStyleBackColor = false;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // LblPrroductsCompany
            // 
            this.LblPrroductsCompany.AutoSize = true;
            this.LblPrroductsCompany.Location = new System.Drawing.Point(154, 108);
            this.LblPrroductsCompany.Name = "LblPrroductsCompany";
            this.LblPrroductsCompany.Size = new System.Drawing.Size(96, 13);
            this.LblPrroductsCompany.TabIndex = 5;
            this.LblPrroductsCompany.Text = "Products Company";
            // 
            // LblProduct
            // 
            this.LblProduct.AutoSize = true;
            this.LblProduct.Location = new System.Drawing.Point(154, 82);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(44, 13);
            this.LblProduct.TabIndex = 4;
            this.LblProduct.Text = "Product";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(154, 55);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(49, 13);
            this.LblCategory.TabIndex = 3;
            this.LblCategory.Text = "Category";
            // 
            // txtProductsCompany
            // 
            this.txtProductsCompany.Location = new System.Drawing.Point(260, 108);
            this.txtProductsCompany.Name = "txtProductsCompany";
            this.txtProductsCompany.Size = new System.Drawing.Size(121, 20);
            this.txtProductsCompany.TabIndex = 2;
            // 
            // CboxCategory
            // 
            this.CboxCategory.FormattingEnabled = true;
            this.CboxCategory.Location = new System.Drawing.Point(260, 52);
            this.CboxCategory.Name = "CboxCategory";
            this.CboxCategory.Size = new System.Drawing.Size(121, 21);
            this.CboxCategory.TabIndex = 1;
            this.CboxCategory.SelectedIndexChanged += new System.EventHandler(this.CboxCategory_SelectedIndexChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(260, 79);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(121, 20);
            this.txtProduct.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGVRequestedProduct);
            this.panel3.Location = new System.Drawing.Point(170, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 207);
            this.panel3.TabIndex = 7;
            // 
            // DGVRequestedProduct
            // 
            this.DGVRequestedProduct.AllowUserToAddRows = false;
            this.DGVRequestedProduct.AllowUserToDeleteRows = false;
            this.DGVRequestedProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRequestedProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProductName,
            this.CategoryName,
            this.ProductsCompany});
            this.DGVRequestedProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRequestedProduct.Location = new System.Drawing.Point(0, 0);
            this.DGVRequestedProduct.Name = "DGVRequestedProduct";
            this.DGVRequestedProduct.ReadOnly = true;
            this.DGVRequestedProduct.Size = new System.Drawing.Size(600, 207);
            this.DGVRequestedProduct.TabIndex = 0;
            this.DGVRequestedProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRequestedProduct_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // ProductsCompany
            // 
            this.ProductsCompany.DataPropertyName = "ProductsCompany";
            this.ProductsCompany.HeaderText = "Products Company";
            this.ProductsCompany.Name = "ProductsCompany";
            this.ProductsCompany.ReadOnly = true;
            // 
            // OwnerNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "OwnerNewProduct";
            this.Text = "RequestedProduct";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequestedProduct)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label LblPrroductsCompany;
        private System.Windows.Forms.Label LblProduct;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.TextBox txtProductsCompany;
        private System.Windows.Forms.ComboBox CboxCategory;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Label LblNewProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DGVRequestedProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsCompany;
    }
}