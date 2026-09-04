using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProject
{
    public class BaseForm : Form
    {
        public DataAccess db { get; set; }
        public BaseForm() 
        {
           db = new DataAccess();
        }

        public static int currentMonth;
        public static int currentYear;
        protected int CalculateTotalSale(string query)
        {
            int total = 0;
            var dt = db.ExecuteQueryTable(query);
            foreach (DataRow row in dt.Rows)
            {
                int price = Convert.ToInt32(row["SellingPrice"]);
                int quantity = Convert.ToInt32(row["SellQuantity"]);
                total += price * quantity;
            }
            return total;
        }

        protected int CalculateCost(string query)
        {
            int cost = 0;
            var dt = db.ExecuteQueryTable(query);
            foreach (DataRow row in dt.Rows)
            {
                int buyingPrice = Convert.ToInt32(row["BuyingPrice"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                cost += buyingPrice * quantity;
            }
            return cost;
        }
    }
}
