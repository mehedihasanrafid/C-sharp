namespace CSharpProject
{
    partial class Admin
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
            this.BtnRequestedProduct = new System.Windows.Forms.Button();
            this.BtnManagerInfo = new System.Windows.Forms.Button();
            this.BtnDashBoard = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSalesmanInfo = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnShowResult = new System.Windows.Forms.Button();
            this.DTPdashbord = new System.Windows.Forms.DateTimePicker();
            this.BtnSellerOfTheMonth = new System.Windows.Forms.Button();
            this.BtnMonthlyCost = new System.Windows.Forms.Button();
            this.BtnYearlyCost = new System.Windows.Forms.Button();
            this.BtnYearlyProfit = new System.Windows.Forms.Button();
            this.BtnMonthlyProfit = new System.Windows.Forms.Button();
            this.BtnYearlySale = new System.Windows.Forms.Button();
            this.BtnMonthlyTotalSale = new System.Windows.Forms.Button();
            this.BtnTransaction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 436);
            this.panel1.TabIndex = 0;
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
            this.BtnLogout.Click += new System.EventHandler(this.button5_Click);
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
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(3, 151);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(144, 33);
            this.BtnAddEmployee.TabIndex = 0;
            this.BtnAddEmployee.Text = "Add Employee";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnShowResult);
            this.panel2.Controls.Add(this.DTPdashbord);
            this.panel2.Controls.Add(this.BtnSellerOfTheMonth);
            this.panel2.Controls.Add(this.BtnMonthlyCost);
            this.panel2.Controls.Add(this.BtnYearlyCost);
            this.panel2.Controls.Add(this.BtnYearlyProfit);
            this.panel2.Controls.Add(this.BtnMonthlyProfit);
            this.panel2.Controls.Add(this.BtnYearlySale);
            this.panel2.Controls.Add(this.BtnMonthlyTotalSale);
            this.panel2.Location = new System.Drawing.Point(243, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 426);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnShowResult
            // 
            this.BtnShowResult.Location = new System.Drawing.Point(188, 55);
            this.BtnShowResult.Name = "BtnShowResult";
            this.BtnShowResult.Size = new System.Drawing.Size(94, 23);
            this.BtnShowResult.TabIndex = 8;
            this.BtnShowResult.Text = "Show Results";
            this.BtnShowResult.UseVisualStyleBackColor = true;
            this.BtnShowResult.Click += new System.EventHandler(this.BtnShowResult_Click);
            // 
            // DTPdashbord
            // 
            this.DTPdashbord.Location = new System.Drawing.Point(143, 29);
            this.DTPdashbord.Name = "DTPdashbord";
            this.DTPdashbord.Size = new System.Drawing.Size(200, 20);
            this.DTPdashbord.TabIndex = 7;
            this.DTPdashbord.ValueChanged += new System.EventHandler(this.DTPdashbord_ValueChanged);
            // 
            // BtnSellerOfTheMonth
            // 
            this.BtnSellerOfTheMonth.Location = new System.Drawing.Point(35, 365);
            this.BtnSellerOfTheMonth.Name = "BtnSellerOfTheMonth";
            this.BtnSellerOfTheMonth.Size = new System.Drawing.Size(173, 58);
            this.BtnSellerOfTheMonth.TabIndex = 6;
            this.BtnSellerOfTheMonth.Text = "Best Sellar of the Month";
            this.BtnSellerOfTheMonth.UseVisualStyleBackColor = true;
            // 
            // BtnMonthlyCost
            // 
            this.BtnMonthlyCost.Location = new System.Drawing.Point(35, 216);
            this.BtnMonthlyCost.Name = "BtnMonthlyCost";
            this.BtnMonthlyCost.Size = new System.Drawing.Size(173, 58);
            this.BtnMonthlyCost.TabIndex = 5;
            this.BtnMonthlyCost.Text = "Monthly Cost";
            this.BtnMonthlyCost.UseVisualStyleBackColor = true;
            this.BtnMonthlyCost.Click += new System.EventHandler(this.BtnMonthlyCost_Click);
            // 
            // BtnYearlyCost
            // 
            this.BtnYearlyCost.Location = new System.Drawing.Point(256, 216);
            this.BtnYearlyCost.Name = "BtnYearlyCost";
            this.BtnYearlyCost.Size = new System.Drawing.Size(173, 58);
            this.BtnYearlyCost.TabIndex = 4;
            this.BtnYearlyCost.Text = "Yearly Cost";
            this.BtnYearlyCost.UseVisualStyleBackColor = true;
            this.BtnYearlyCost.Click += new System.EventHandler(this.BtnYearlyCost_Click);
            // 
            // BtnYearlyProfit
            // 
            this.BtnYearlyProfit.Location = new System.Drawing.Point(256, 294);
            this.BtnYearlyProfit.Name = "BtnYearlyProfit";
            this.BtnYearlyProfit.Size = new System.Drawing.Size(173, 58);
            this.BtnYearlyProfit.TabIndex = 3;
            this.BtnYearlyProfit.Text = "Yearly Profit ";
            this.BtnYearlyProfit.UseVisualStyleBackColor = true;
            // 
            // BtnMonthlyProfit
            // 
            this.BtnMonthlyProfit.Location = new System.Drawing.Point(35, 294);
            this.BtnMonthlyProfit.Name = "BtnMonthlyProfit";
            this.BtnMonthlyProfit.Size = new System.Drawing.Size(173, 58);
            this.BtnMonthlyProfit.TabIndex = 2;
            this.BtnMonthlyProfit.Text = "Monthly Profit ";
            this.BtnMonthlyProfit.UseVisualStyleBackColor = true;
            // 
            // BtnYearlySale
            // 
            this.BtnYearlySale.Location = new System.Drawing.Point(256, 138);
            this.BtnYearlySale.Name = "BtnYearlySale";
            this.BtnYearlySale.Size = new System.Drawing.Size(173, 58);
            this.BtnYearlySale.TabIndex = 1;
            this.BtnYearlySale.Text = "Yearly Sale";
            this.BtnYearlySale.UseVisualStyleBackColor = true;
            this.BtnYearlySale.Click += new System.EventHandler(this.BtnYearlySale_Click);
            // 
            // BtnMonthlyTotalSale
            // 
            this.BtnMonthlyTotalSale.Location = new System.Drawing.Point(35, 138);
            this.BtnMonthlyTotalSale.Name = "BtnMonthlyTotalSale";
            this.BtnMonthlyTotalSale.Size = new System.Drawing.Size(173, 58);
            this.BtnMonthlyTotalSale.TabIndex = 0;
            this.BtnMonthlyTotalSale.Text = "Monthly Sale";
            this.BtnMonthlyTotalSale.UseVisualStyleBackColor = true;
            this.BtnMonthlyTotalSale.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.Location = new System.Drawing.Point(3, 102);
            this.BtnTransaction.Name = "BtnTransaction";
            this.BtnTransaction.Size = new System.Drawing.Size(144, 33);
            this.BtnTransaction.TabIndex = 8;
            this.BtnTransaction.Text = "Transaction";
            this.BtnTransaction.UseVisualStyleBackColor = true;
            this.BtnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Button BtnDashBoard;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSalesmanInfo;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMonthlyProfit;
        private System.Windows.Forms.Button BtnYearlySale;
        private System.Windows.Forms.Button BtnMonthlyTotalSale;
        private System.Windows.Forms.Button BtnYearlyProfit;
        private System.Windows.Forms.Button BtnManagerInfo;
        private System.Windows.Forms.Button BtnMonthlyCost;
        private System.Windows.Forms.Button BtnYearlyCost;
        private System.Windows.Forms.Button BtnRequestedProduct;
        private System.Windows.Forms.Button BtnSellerOfTheMonth;
        private System.Windows.Forms.DateTimePicker DTPdashbord;
        private System.Windows.Forms.Button BtnShowResult;
        private System.Windows.Forms.Button BtnTransaction;
    }
}