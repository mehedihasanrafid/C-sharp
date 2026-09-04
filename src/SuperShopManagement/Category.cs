using System;
using System.Collections;
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
    public partial class Category : Form
    {
        public DataAccess db { get; set; }
        public Category()
        {
            InitializeComponent();
            this.db= new DataAccess();
            PopulateGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnInsertEmployee_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO CategoryTbl(name) VALUES('"+txtCategory.Text+"')";
            if (txtCategory.Text != "")
            {
                db.ExecuteDMLQuery(sql);
                PopulateGridView();


            }
            else 
            {
                MessageBox.Show("Please insert a category name");
            }
        }

        private void PopulateGridView(string query = "select *from CategoryTbl;") 
        {
            var ds = this.db.ExecuteQuery(query);
            this.DGVCategory.AutoGenerateColumns = false;
            this.DGVCategory.DataSource = ds.Tables[0];
        }

        private void BtnRequestedProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
