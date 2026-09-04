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
    public partial class ManagerNewProduct : Form
    {
        public DataAccess db { get; set; }
        public ManagerNewProduct()
        {
            InitializeComponent();
            db = new DataAccess();
            PopulateGridView();
        }
        private bool Isvalid() 
        {
            if (txtProductCategory.Text == "" || txtProductCompany.Text == "" || txtProductName.Text == "" || txtProductQuantity.Text == "" || txtBuyingPrice.Text == "" || txtSellingPrice.Text == "")
            {
                MessageBox.Show("Field is empty");
                return false;
            }
            else if (!int.TryParse(txtBuyingPrice.Text, out _) || !int.TryParse(txtSellingPrice.Text, out _))
            {
                MessageBox.Show("Price must me a number");
                return false;
            }
            else 
            {
                return true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string query= "INSERT INTO InventoryTbl(ProductName,CategoryId,ProductCompany,BuyingPrice,SellingPrice,Date,Quantity) " +
                "VALUES('" + txtProductName.Text + "','" + GetCategoryId() + "','" + txtProductCompany.Text +"','"+txtBuyingPrice.Text+"','"+txtSellingPrice.Text+"','"+DateTime.Now+"','"+txtProductQuantity.Text+"')";
            if (Isvalid()) 
            {
                db.ExecuteDMLQuery(query);
                MessageBox.Show("Product Succesfully Added to Inventory");
                RemoveProduct();
            }
        }

        private void PopulateGridView() 
        {
            string query = "select *from OwnerReqTbl ot, CategoryTbl c where ot.CategoryId=c.id";
            var ds=db.ExecuteQuery(query);
            this.DGVNewProduct.AutoGenerateColumns = false;
            this.DGVNewProduct.DataSource = ds.Tables[0];
            
        }

        private void DGVNewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtProductName.Text = this.DGVNewProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            this.txtProductCategory.Text = this.DGVNewProduct.CurrentRow.Cells["CategoryName"].Value.ToString();
            this.txtProductCompany.Text = this.DGVNewProduct.CurrentRow.Cells["ProductsCompany"].Value.ToString();
            
        }

        private int GetCategoryId() 
        {
            string query = "select id from CategoryTbl where name='" + txtProductCategory.Text + "'";
            var ds = db.ExecuteQueryTable(query);
            int s = Convert.ToInt32(ds.Rows[0][0]);
            return s;
        }

        private void RemoveProduct() 
        {
            string query = "DELETE FROM OwnerReqTbl WHERE ProductName = '"+txtProductName.Text+"' AND ProductsCompany= '"+txtProductCompany.Text+ "' AND CategoryId='" + GetCategoryId()+"'";
            var count=db.ExecuteDMLQuery(query);
            if (count > 0) 
            {
                MessageBox.Show("removed from tbl");
            }
            PopulateGridView();

        }
    }
}
