using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProject
{
    public partial class Transaction : Form
    {
        public DataAccess db { get; set; }
        public Transaction()
        {
            
            InitializeComponent();
            db = new DataAccess();
            PopulateGridView();
        }

        int currentMonth;
        int currentYear;
        int currentDay;

        

        private void PopulateGridView(string query= " SELECT * FROM TransactionTbl AS t JOIN InventoryTbl AS p ON t.pid = p.id JOIN CategoryTbl AS c ON p.CategoryId = c.id JOIN EmployeeTbl AS e ON t.SalesmanId=e.id WHERE DAY(SellDate) < 30") 
        {
                var ds = this.db.ExecuteQuery(query);
                this.DGVTransaction.AutoGenerateColumns = false;
                this.DGVTransaction.DataSource = ds.Tables[0];

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var query = " SELECT * FROM TransactionTbl AS t JOIN InventoryTbl AS p ON t.pid = p.id JOIN CategoryTbl AS c ON p.CategoryId = c.id JOIN EmployeeTbl AS e ON t.SalesmanId=e.id WHERE ProductName LIKE '%" + this.txtSearch.Text + "%' OR name LIKE '%" + this.txtSearch.Text + "%' OR SellDate LIKE '%" + this.txtSearch.Text + "%' OR EmpName LIKE '%" + this.txtSearch.Text + "%' AND DAY(SellDate)=" + currentDay + "  AND MONTH(SellDate)=" + currentMonth + " AND YEAR(SellDate) = " + currentYear + "";
            PopulateGridView(query);
        }


        public void SetTime()
        {
                currentDay= DTPTransaction.Value.Day;
                currentMonth = DTPTransaction.Value.Month;
                currentYear = DTPTransaction.Value.Year;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SetTime();
            string query = "SELECT * FROM TransactionTbl AS t JOIN InventoryTbl AS p ON t.pid = p.id JOIN CategoryTbl AS c ON p.CategoryId = c.id JOIN EmployeeTbl AS e ON t.SalesmanId=e.id WHERE DAY(SellDate)=" + currentDay + "  AND MONTH(SellDate)=" + currentMonth + " AND YEAR(SellDate) = " + currentYear + "";
            PopulateGridView(query);
        }
    }
}
