namespace CSharpProject
{
    partial class ManagerNewProduct
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
            this.BtnNewProduct = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVNewProduct = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductCompany = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.LblProductName = new System.Windows.Forms.Label();
            this.LblCategoryName = new System.Windows.Forms.Label();
            this.LblProductQuantity = new System.Windows.Forms.Label();
            this.LblProductCompany = new System.Windows.Forms.Label();
            this.txtBuyingPrice = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.LblBuyingPrice = new System.Windows.Forms.Label();
            this.LblSellingPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNewProduct);
            this.panel1.Controls.Add(this.BtnInventory);
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 436);
            this.panel1.TabIndex = 1;
            // 
            // BtnNewProduct
            // 
            this.BtnNewProduct.Location = new System.Drawing.Point(3, 307);
            this.BtnNewProduct.Name = "BtnNewProduct";
            this.BtnNewProduct.Size = new System.Drawing.Size(144, 33);
            this.BtnNewProduct.TabIndex = 6;
            this.BtnNewProduct.Text = "New Product";
            this.BtnNewProduct.UseVisualStyleBackColor = true;
            // 
            // BtnInventory
            // 
            this.BtnInventory.Location = new System.Drawing.Point(3, 50);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(144, 33);
            this.BtnInventory.TabIndex = 5;
            this.BtnInventory.Text = "Inventory";
            this.BtnInventory.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVNewProduct);
            this.panel2.Location = new System.Drawing.Point(168, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 190);
            this.panel2.TabIndex = 2;
            // 
            // DGVNewProduct
            // 
            this.DGVNewProduct.AllowUserToAddRows = false;
            this.DGVNewProduct.AllowUserToDeleteRows = false;
            this.DGVNewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.CategoryName,
            this.ProductsCompany});
            this.DGVNewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVNewProduct.Location = new System.Drawing.Point(0, 0);
            this.DGVNewProduct.Name = "DGVNewProduct";
            this.DGVNewProduct.ReadOnly = true;
            this.DGVNewProduct.Size = new System.Drawing.Size(620, 190);
            this.DGVNewProduct.TabIndex = 0;
            this.DGVNewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNewProduct_CellClick);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(430, 27);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(430, 53);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(100, 20);
            this.txtProductCategory.TabIndex = 4;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(430, 81);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtProductQuantity.TabIndex = 5;
            // 
            // txtProductCompany
            // 
            this.txtProductCompany.Location = new System.Drawing.Point(430, 109);
            this.txtProductCompany.Name = "txtProductCompany";
            this.txtProductCompany.Size = new System.Drawing.Size(100, 20);
            this.txtProductCompany.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(430, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(334, 30);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(72, 13);
            this.LblProductName.TabIndex = 8;
            this.LblProductName.Text = "ProductName";
            // 
            // LblCategoryName
            // 
            this.LblCategoryName.AutoSize = true;
            this.LblCategoryName.Location = new System.Drawing.Point(334, 56);
            this.LblCategoryName.Name = "LblCategoryName";
            this.LblCategoryName.Size = new System.Drawing.Size(80, 13);
            this.LblCategoryName.TabIndex = 9;
            this.LblCategoryName.Text = "Category Name";
            // 
            // LblProductQuantity
            // 
            this.LblProductQuantity.AutoSize = true;
            this.LblProductQuantity.Location = new System.Drawing.Point(334, 81);
            this.LblProductQuantity.Name = "LblProductQuantity";
            this.LblProductQuantity.Size = new System.Drawing.Size(86, 13);
            this.LblProductQuantity.TabIndex = 10;
            this.LblProductQuantity.Text = "Product Quantity";
            // 
            // LblProductCompany
            // 
            this.LblProductCompany.AutoSize = true;
            this.LblProductCompany.Location = new System.Drawing.Point(334, 109);
            this.LblProductCompany.Name = "LblProductCompany";
            this.LblProductCompany.Size = new System.Drawing.Size(91, 13);
            this.LblProductCompany.TabIndex = 11;
            this.LblProductCompany.Text = "Product Company";
            // 
            // txtBuyingPrice
            // 
            this.txtBuyingPrice.Location = new System.Drawing.Point(430, 135);
            this.txtBuyingPrice.Name = "txtBuyingPrice";
            this.txtBuyingPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBuyingPrice.TabIndex = 12;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(430, 161);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSellingPrice.TabIndex = 13;
            // 
            // LblBuyingPrice
            // 
            this.LblBuyingPrice.AutoSize = true;
            this.LblBuyingPrice.Location = new System.Drawing.Point(334, 138);
            this.LblBuyingPrice.Name = "LblBuyingPrice";
            this.LblBuyingPrice.Size = new System.Drawing.Size(66, 13);
            this.LblBuyingPrice.TabIndex = 14;
            this.LblBuyingPrice.Text = "Buying Price";
            // 
            // LblSellingPrice
            // 
            this.LblSellingPrice.AutoSize = true;
            this.LblSellingPrice.Location = new System.Drawing.Point(335, 164);
            this.LblSellingPrice.Name = "LblSellingPrice";
            this.LblSellingPrice.Size = new System.Drawing.Size(65, 13);
            this.LblSellingPrice.TabIndex = 15;
            this.LblSellingPrice.Text = "Selling Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "New Product List";
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
            this.ProductsCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductsCompany.DataPropertyName = "ProductsCompany";
            this.ProductsCompany.HeaderText = "Products Company";
            this.ProductsCompany.Name = "ProductsCompany";
            this.ProductsCompany.ReadOnly = true;
            // 
            // ManagerNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSellingPrice);
            this.Controls.Add(this.LblBuyingPrice);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txtBuyingPrice);
            this.Controls.Add(this.LblProductCompany);
            this.Controls.Add(this.LblProductQuantity);
            this.Controls.Add(this.LblCategoryName);
            this.Controls.Add(this.LblProductName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductCompany);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerNewProduct";
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnNewProduct;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVNewProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCategory;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductCompany;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Label LblCategoryName;
        private System.Windows.Forms.Label LblProductQuantity;
        private System.Windows.Forms.Label LblProductCompany;
        private System.Windows.Forms.TextBox txtBuyingPrice;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Label LblBuyingPrice;
        private System.Windows.Forms.Label LblSellingPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsCompany;
    }
}