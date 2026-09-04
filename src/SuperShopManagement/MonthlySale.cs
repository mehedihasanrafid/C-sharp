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
    public partial class MonthlySale : BaseForm
    {
        
        public MonthlySale()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Admin dashbord = new Admin();
            this.Hide();
            dashbord.Show();

        }

        private void PopulateGridView() 
        {
            string query = "SELECT *  ,p.SellingPrice * t.SellQuantity AS Total FROM TransactionTbl AS t JOIN InventoryTbl AS p ON t.pid = p.id JOIN CategoryTbl AS c ON p.CategoryId = c.id WHERE MONTH(SellDate) =" + currentMonth + "  AND YEAR(SellDate) = "+currentYear+"";
            var ds=db.ExecuteQuery(query);
            this.DGVMonthlySale.AutoGenerateColumns = false;
            this.DGVMonthlySale.DataSource = ds.Tables[0];
            LblTotalSale.Text = LblTotalSale.Text+ CalculateTotalSale(query).ToString();
            
        }
        



       
    }
}
