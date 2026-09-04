using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection conn
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()
        {
            // Default Connection String (Windows Authentication with SQL Server Express)
            // Change Data Source to match your SQL Server instance name (e.g., .\\SQLEXPRESS or localhost)
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Csharp;Integrated Security=True;";
            
            // Alternative SA Authentication (uncomment if using SQL Server Authentication):
            // string connectionString = @"Data Source=KINGKONG;Initial Catalog=Csharp;User ID=sa;Password=#kingKong1;";

            this.conn = new SqlConnection(connectionString);
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.conn);
        }

        public DataSet ExecuteQuery(string query)
        {
            this.QueryText(query);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
        }

        public DataTable ExecuteQueryTable(string query)
        {
            this.QueryText(query);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string query)
        {
            this.QueryText(query);
            this.conn.Open();
            int u = this.Sqlcom.ExecuteNonQuery();
            this.conn.Close();
            return u;
        }
    }
}
