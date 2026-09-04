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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharpProject
{
    public partial class OwnerNewProduct : Form
    {
        public DataAccess db { get; set; }
        public OwnerNewProduct()
        {
            db= new DataAccess();
            InitializeComponent();
            PopulateGridView();
            PopulateComboBox();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO OwnerReqTbl(ProductName,CategoryId,ProductsCompany) VALUES('"+txtProduct.Text+"','"+CboxCategory.SelectedValue+"','"+txtProductsCompany.Text+"')";
            if (IsNull()) 
            {
                db.ExecuteDMLQuery(query);
                PopulateGridView();
            }
            
        }

        private bool IsNull() 
        {
            if (CboxCategory.Text == "" || txtProduct.Text == "" || txtProductsCompany.Text == "")
            {
                MessageBox.Show("Field is empty");
                return false;
            }
            else 
            {
                return true;
            }

        }
        private void PopulateGridView(string query= "select *from OwnerReqTbl ot, CategoryTbl c where ot.CategoryId=c.id") 
        {
            var ds = this.db.ExecuteQuery(query);
            this.DGVRequestedProduct.AutoGenerateColumns = false;
            this.DGVRequestedProduct.DataSource = ds.Tables[0];
        }

        private void CboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PopulateComboBox() 
        {
            string query = "select id,name from CategoryTbl";
            var ds=db.ExecuteQuery(query);
            CboxCategory.DataSource = ds.Tables[0];
            CboxCategory.DisplayMember = "name";
            CboxCategory.ValueMember = "id";
            


        }

        private void DGVRequestedProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            this.Hide();
            inventory.Show();

        }
    }
}
