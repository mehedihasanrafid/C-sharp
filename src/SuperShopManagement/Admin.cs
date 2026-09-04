using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CSharpProject
{
    public partial class Admin : BaseForm
    {
        public Admin()
        {
            InitializeComponent();
            SetTime();
            SaleAndProfitThisMonth();
            SaleAndProfitThisYear();
            CostOfThisMonth();
            CostOfThisYear();
            SellerOfTheMonth();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MonthlySale monthlySale = new MonthlySale();
            this.Hide();
            monthlySale.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            this.Hide();
            addEmployee.Show();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            this.Hide();
            category.Show();
        }

        

        public void SetTime() 
        {
            if (DTPdashbord.Value.Month <= DateTime.Now.Month || DTPdashbord.Value.Year <= DateTime.Now.Year)
            {
                currentMonth = DTPdashbord.Value.Month;
                currentYear = DTPdashbord.Value.Year;

            }
            
        }

        private void SaleAndProfitThisMonth()
        {
            string query = "SELECT * FROM TransactionTbl AS t JOIN InventoryTbl AS p ON t.pid = p.id JOIN CategoryTbl AS c ON p.CategoryId = c.id WHERE MONTH(SellDate) =  " + currentMonth + "  AND YEAR(SellDate) = " + currentYear + "";
            this.BtnMonthlyTotalSale.Text = "Sale Of This Month: " + CalculateTotalSale(query) + " Tk";
            this.BtnMonthlyProfit.Text = "Profit Of This Month :" + CalculateProfit(query) + " Tk";
           
        }
        private void SaleAndProfitThisYear()
        {
            string query = "SELECT * FROM TransactionTbl AS t JOIN InventoryTbl AS p ON t.pid = p.id JOIN CategoryTbl AS c ON p.CategoryId = c.id WHERE YEAR(SellDate) = " + currentYear + "";
            this.BtnYearlySale.Text ="Sale Of This Year :" + CalculateTotalSale(query) + " Tk";
            this.BtnYearlyProfit.Text = "Profit Of This Year : " + CalculateProfit(query) + " Tk";
            
        }
        private void CostOfThisMonth()
        {
            string query = "SELECT * FROM InventoryTbl AS i JOIN CategoryTbl AS c ON i.CategoryId = c.id  WHERE MONTH(Date) = "+currentMonth+" AND YEAR(Date) ="+currentYear+"";
            this.BtnMonthlyCost.Text = "Cost Of This Month :" + CalculateCost(query) + " Tk";
        }
        private void CostOfThisYear()
        {
            string query = "SELECT * FROM InventoryTbl AS i JOIN CategoryTbl AS c ON i.CategoryId = c.id  WHERE YEAR(Date) =" + currentYear + "";
            this.BtnYearlyCost.Text = "Cost Of This Year :" + CalculateCost(query) + " Tk";
        }
        private void SellerOfTheMonth() 
        {
            string query = @"SELECT e.id, e.EmpName,COUNT(*) AS TotalSales,SUM(p.SellingPrice * t.SellQuantity) AS TotalSaleAmount FROM EmployeeTbl AS e JOIN TransactionTbl AS t ON e.id = t.SalesmanId
                             JOIN InventoryTbl AS p ON t.pid = p.id JOIN CategoryTbl AS c ON p.CategoryId = c.id 
                             WHERE MONTH(t.SellDate) = "+currentMonth+" AND YEAR(t.SellDate) = "+currentYear+" GROUP BY e.id,e.EmpName ";

            this.BtnSellerOfTheMonth.Text = "Seller Of The Month  :" + BestSellerOfTheMonth(query);
        }


        private string BestSellerOfTheMonth(string query)
        {
            string BestSeller="";
            int TotalSale = 0;
            int amount = 0;
            var dt = db.ExecuteQueryTable(query);
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["TotalSales"]) > TotalSale)
                {
                    BestSeller = Convert.ToString(row["EmpName"]);
                    TotalSale = Convert.ToInt32(row["TotalSales"]);
                    amount = Convert.ToInt32(row["TotalSaleAmount"]);
                }
                if (Convert.ToInt32(row["TotalSales"]) == TotalSale && amount < Convert.ToInt32(row["TotalSaleAmount"])) 
                {
                        BestSeller = Convert.ToString(row["EmpName"]);
                        TotalSale = Convert.ToInt32(row["TotalSales"]);
                        amount = Convert.ToInt32(row["TotalSaleAmount"]);
                }
                

            }
            return BestSeller;

        }
        private int CalculateProfit(string query) 
        {
            int profit = 0;
            var dt = db.ExecuteQueryTable(query);
            foreach (DataRow row in dt.Rows)
            {
                int sellingPrice = Convert.ToInt32(row["SellingPrice"]);
                int quantity = Convert.ToInt32(row["SellQuantity"]);
                int buyingPrice = Convert.ToInt32(row["BuyingPrice"]);
                profit += (sellingPrice - buyingPrice) * quantity;
            }
            return profit;
        }


        private void BtnMonthlyCost_Click(object sender, EventArgs e)
        {
            MonthlyCost monthlyCost = new MonthlyCost();
            this.Hide();
            monthlyCost.Show();
        }
        private void BtnYearlySale_Click(object sender, EventArgs e)
        {
            YearlySale yearlySale = new YearlySale();
            this.Hide();
            yearlySale.Show();  
        }
        private void BtnYearlyCost_Click(object sender, EventArgs e)
        {
            YearlyCost yearlyCost = new YearlyCost();
            this.Hide();
            yearlyCost.Show();  
        }
        private void BtnShowResult_Click(object sender, EventArgs e)
        {
            SetTime();
            SaleAndProfitThisMonth();
            SaleAndProfitThisYear();
            CostOfThisMonth();
            CostOfThisYear();
            SellerOfTheMonth();

        }
        private void DTPdashbord_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            this.Hide();
            transaction.Show();
        }
    }
}
