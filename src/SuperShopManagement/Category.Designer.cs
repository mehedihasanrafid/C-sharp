namespace CSharpProject
{
    partial class Category
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
            this.BtnRequestedProduct = new System.Windows.Forms.Button();
            this.BtnManagerInfo = new System.Windows.Forms.Button();
            this.BtnDashBoard = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSalesmanInfo = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblAddEmployee = new System.Windows.Forms.Label();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVCategory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnRequestedProduct);
            this.panel2.Controls.Add(this.BtnManagerInfo);
            this.panel2.Controls.Add(this.BtnDashBoard);
            this.panel2.Controls.Add(this.BtnLogout);
            this.panel2.Controls.Add(this.BtnSalesmanInfo);
            this.panel2.Controls.Add(this.BtnInventory);
            this.panel2.Controls.Add(this.BtnCategory);
            this.panel2.Controls.Add(this.BtnAddEmployee);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 436);
            this.panel2.TabIndex = 4;
            // 
            // BtnRequestedProduct
            // 
            this.BtnRequestedProduct.Location = new System.Drawing.Point(3, 346);
            this.BtnRequestedProduct.Name = "BtnRequestedProduct";
            this.BtnRequestedProduct.Size = new System.Drawing.Size(144, 33);
            this.BtnRequestedProduct.TabIndex = 7;
            this.BtnRequestedProduct.Text = "Requested Product";
            this.BtnRequestedProduct.UseVisualStyleBackColor = true;
            this.BtnRequestedProduct.Click += new System.EventHandler(this.BtnRequestedProduct_Click);
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
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(219, 94);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(121, 20);
            this.txtCategory.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(113, 97);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name";
            // 
            // LblAddEmployee
            // 
            this.LblAddEmployee.AutoSize = true;
            this.LblAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddEmployee.Location = new System.Drawing.Point(157, 26);
            this.LblAddEmployee.Name = "LblAddEmployee";
            this.LblAddEmployee.Size = new System.Drawing.Size(81, 20);
            this.LblAddEmployee.TabIndex = 9;
            this.LblAddEmployee.Text = "Category";
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnAddCategory.Location = new System.Drawing.Point(149, 139);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(100, 35);
            this.BtnAddCategory.TabIndex = 10;
            this.BtnAddCategory.Text = "Add Category";
            this.BtnAddCategory.UseVisualStyleBackColor = false;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnInsertEmployee_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnAddCategory);
            this.panel3.Controls.Add(this.LblAddEmployee);
            this.panel3.Controls.Add(this.LblName);
            this.panel3.Controls.Add(this.txtCategory);
            this.panel3.Location = new System.Drawing.Point(201, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 190);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVCategory);
            this.panel1.Location = new System.Drawing.Point(189, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 233);
            this.panel1.TabIndex = 5;
            // 
            // DGVCategory
            // 
            this.DGVCategory.AllowUserToAddRows = false;
            this.DGVCategory.AllowUserToDeleteRows = false;
            this.DGVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.DGVCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCategory.Location = new System.Drawing.Point(0, 0);
            this.DGVCategory.Name = "DGVCategory";
            this.DGVCategory.ReadOnly = true;
            this.DGVCategory.Size = new System.Drawing.Size(371, 233);
            this.DGVCategory.TabIndex = 0;
            this.DGVCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Category ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "CategoryName";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Category";
            this.Text = "Category";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnRequestedProduct;
        private System.Windows.Forms.Button BtnManagerInfo;
        private System.Windows.Forms.Button BtnDashBoard;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSalesmanInfo;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblAddEmployee;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}