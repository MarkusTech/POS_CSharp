using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSales
{
    class DBConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string con;
        public string myConnection()
        {
            con = "data source = WMR\\SQLEXPRESS;database=POSDB;integrated security = true";
            return con;
        }

        public DataTable getTable(string qury)
        {
            cn.ConnectionString = myConnection();
            cm = new SqlCommand(qury, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void ExecuteQuery(String sql)
        {
            try
            {
                cn.ConnectionString = myConnection();
                cn.Open();
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public String getPassword(string username)
        {
            string password = "";
            cn.ConnectionString = myConnection();
            cn.Open();
            cm = new SqlCommand("SELECT password FROM tbUser WHERE username = '"+ username + "'", cn);
            dr= cm.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                password = dr["password"].ToString();
            }
            dr.Close();
            cn.Close();
            return password;
        }

        public double ExtractData(string sql)
        {
          
            cn = new SqlConnection();
            cn.ConnectionString = myConnection();
            cn.Open();
            cm = new SqlCommand(sql, cn);
            double data = double.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return data;

        }
    }
}
