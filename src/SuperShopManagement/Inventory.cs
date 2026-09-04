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
    public partial class Inventory : Form
    {
        public DataAccess db { get; set; }
        public Inventory()
        {
            InitializeComponent();
            db = new DataAccess();
            PopulateGridView();
        }

        private void PopulateGridView(string query = "SELECT * FROM InventoryTbl AS i JOIN CategoryTbl AS c ON i.CategoryId = c.id") 
        {
            var ds = this.db.ExecuteQuery(query);
            this.DGVInventory.AutoGenerateColumns = false;
            this.DGVInventory.DataSource = ds.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = "SELECT * FROM InventoryTbl AS i JOIN CategoryTbl AS c ON i.CategoryId = c.id where ProductName like '" + this.txtSearch.Text + "%'";
            PopulateGridView(query);
        }
    }
}
