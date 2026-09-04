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
    public partial class AddEmployee : Form
    {
        private DataAccess db { get; set; }
        public AddEmployee()
        {
            InitializeComponent();
            this.db=new DataAccess();
            PopulateGridView();
        }

        string gender;
        private bool IsValid() 
        {
            if (txtName.Text == "" || txtContactNumber.Text == "" || (radioBtnMale.Text == "" && radioBtnFemale.Text == "") || birthdateDTP.Text == "")
            {
                return false;
            }
            else 
            {
                gender= radioBtnMale.Checked ? "Male" : "Female";
                return true;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnInsertEmployee_Click(object sender, EventArgs e)
        {
            if (IsValid()) 
            {
                string querry= "INSERT INTO EmployeeTbl(EmpName, Contact, Dob,Type,Salary,Gender) VALUES('"+txtName.Text+"', '"+txtContactNumber.Text+"', '"+birthdateDTP.Value.Date+"','"+CboxRank.Text+"','"+txtSalary.Text+"','"+gender+"')";
                string query2 = "INSERT INTO UserTbl(Uname,pass,Type) VALUES('" + txtName.Text + "','" + TxtInitialPass.Text + "','" + CboxRank.Text + "')";
                
                var count = this.db.ExecuteDMLQuery(querry);

                if (count > 0)
                {
                    this.db.ExecuteDMLQuery(query2);
                    MessageBox.Show("Employee Added Successfully");
                    this.PopulateGridView();
                    
                }
                else 
                {
                    MessageBox.Show("Employee Adding Failed");
                }
            }
            
        }

        public void PopulateGridView(string query="select *from EmployeeTbl;") 
        {
            var ds=this.db.ExecuteQuery(query);
            this.DGVEmployee.AutoGenerateColumns = false;
            this.DGVEmployee.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from EmployeeTbl where EmpName like '" + this.TxtSearch.Text + "%'";
            PopulateGridView(query);
        }

        private void CboxRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void birthdateDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblInitialPass_Click(object sender, EventArgs e)
        {





        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            this.Hide();
            category.Show();
            
        }

        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            OwnerNewProduct newProduct = new OwnerNewProduct();
            this.Hide();
            newProduct.Show();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            this.Hide();
            inventory.Show();
        }
    }
}
