using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProject
{
    public partial class Form1 : Form
    {
        private DataAccess db { get; set; }
       public Form1() 
        {
            InitializeComponent();
            this.db = new DataAccess();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassTb.Text == "" || UnameTb.Text == "")
            {
                MessageBox.Show("Field must be filled up");
            }
            else
            {

                string sql = "SELECT Type FROM UserTbl WHERE pass='" + PassTb.Text.Trim() + "' AND Uname='" + UnameTb.Text.Trim() + "'";
                var ds = this.db.ExecuteQueryTable(sql);

                if (ds.Rows.Count > 0)
                {
                    string usertype = ds.Rows[0][0].ToString();

                    if (usertype == "Admin")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (usertype == "Manager")
                    {
                        ManagerNewProduct manager = new ManagerNewProduct();
                        manager.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }

        }
    }
}
