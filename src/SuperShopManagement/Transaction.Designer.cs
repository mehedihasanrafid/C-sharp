namespace CSharpProject
{
    partial class Transaction
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
            this.BtnTransaction = new System.Windows.Forms.Button();
            this.BtnRequestedProduct = new System.Windows.Forms.Button();
            this.BtnManagerInfo = new System.Windows.Forms.Button();
            this.BtnDashBoard = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSalesmanInfo = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVTransaction = new System.Windows.Forms.DataGridView();
            this.Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DTPTransaction = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnTransaction);
            this.panel1.Controls.Add(this.BtnRequestedProduct);
            this.panel1.Controls.Add(this.BtnManagerInfo);
            this.panel1.Controls.Add(this.BtnDashBoard);
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnSalesmanInfo);
            this.panel1.Controls.Add(this.BtnInventory);
            this.panel1.Controls.Add(this.BtnCategory);
            this.panel1.Controls.Add(this.BtnAddEmployee);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 436);
            this.panel1.TabIndex = 1;
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.Location = new System.Drawing.Point(3, 102);
            this.BtnTransaction.Name = "BtnTransaction";
            this.BtnTransaction.Size = new System.Drawing.Size(144, 33);
            this.BtnTransaction.TabIndex = 8;
            this.BtnTransaction.Text = "Transaction";
            this.BtnTransaction.UseVisualStyleBackColor = true;
            // 
            // BtnRequestedProduct
            // 
            this.BtnRequestedProduct.Location = new System.Drawing.Point(3, 346);
            this.BtnRequestedProduct.Name = "BtnRequestedProduct";
            this.BtnRequestedProduct.Size = new System.Drawing.Size(144, 33);
            this.BtnRequestedProduct.TabIndex = 7;
            this.BtnRequestedProduct.Text = "Requested Product";
            this.BtnRequestedProduct.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVTransaction);
            this.panel2.Location = new System.Drawing.Point(168, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 271);
            this.panel2.TabIndex = 2;
            // 
            // DGVTransaction
            // 
            this.DGVTransaction.AllowUserToAddRows = false;
            this.DGVTransaction.AllowUserToDeleteRows = false;
            this.DGVTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pid,
            this.ProductName,
            this.name,
            this.SellQuantity,
            this.SellingPrice,
            this.SellDate,
            this.SalesmanId,
            this.EmpName});
            this.DGVTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTransaction.Location = new System.Drawing.Point(0, 0);
            this.DGVTransaction.Name = "DGVTransaction";
            this.DGVTransaction.ReadOnly = true;
            this.DGVTransaction.Size = new System.Drawing.Size(904, 271);
            this.DGVTransaction.TabIndex = 0;
            // 
            // Pid
            // 
            this.Pid.DataPropertyName = "Pid";
            this.Pid.HeaderText = "Product ID";
            this.Pid.Name = "Pid";
            this.Pid.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Category";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // SellQuantity
            // 
            this.SellQuantity.DataPropertyName = "SellQuantity";
            this.SellQuantity.HeaderText = "Quantity";
            this.SellQuantity.Name = "SellQuantity";
            this.SellQuantity.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // SellDate
            // 
            this.SellDate.DataPropertyName = "SellDate";
            this.SellDate.HeaderText = "Date";
            this.SellDate.Name = "SellDate";
            this.SellDate.ReadOnly = true;
            // 
            // SalesmanId
            // 
            this.SalesmanId.DataPropertyName = "SalesmanId";
            this.SalesmanId.HeaderText = "Salesman Id";
            this.SalesmanId.Name = "SalesmanId";
            this.SalesmanId.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Salesman";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(446, 119);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // DTPTransaction
            // 
            this.DTPTransaction.Location = new System.Drawing.Point(837, 119);
            this.DTPTransaction.Name = "DTPTransaction";
            this.DTPTransaction.Size = new System.Drawing.Size(200, 20);
            this.DTPTransaction.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(748, 114);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(67, 35);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 490);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DTPTransaction);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnTransaction;
        private System.Windows.Forms.Button BtnRequestedProduct;
        private System.Windows.Forms.Button BtnManagerInfo;
        private System.Windows.Forms.Button BtnDashBoard;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSalesmanInfo;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker DTPTransaction;
        private System.Windows.Forms.Button BtnSearch;
    }
}