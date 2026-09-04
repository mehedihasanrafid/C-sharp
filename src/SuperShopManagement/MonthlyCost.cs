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
    public partial class MonthlyCost : BaseForm
    {
        public MonthlyCost()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Admin dasbord = new Admin();
            this.Hide();
            dasbord.Show();
            
        }

        private void PopulateGridView()
        {
            string query = "SELECT *  ,i.BuyingPrice * i.Quantity AS Total FROM InventoryTbl AS i JOIN CategoryTbl AS c ON i.CategoryId = c.id WHERE MONTH(Date) =" + currentMonth + "  AND YEAR(Date) = " + currentYear + "";
            var ds = db.ExecuteQuery(query);
            this.DGVMonthlySale.AutoGenerateColumns = false;
            this.DGVMonthlySale.DataSource = ds.Tables[0];
            LblTotalCost.Text = LblTotalCost.Text + CalculateCost(query).ToString();

        }


    }
}
