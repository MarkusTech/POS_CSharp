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

namespace POSales
{
    public partial class Dashboard : Form
    {
        SqlConnection cn = new SqlConnection();        
        DBConnect dbcon = new DBConnect();

        public Dashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string sdate = DateTime.Now.ToShortDateString();
            lblDalySale.Text = dbcon.ExtractData("SELECT ISNULL(SUM(total),0) AS total FROM tbCart WHERE status LIKE 'Sold' AND sdate BETWEEN '"+sdate+ "' AND '" + sdate + "'").ToString("#,##0.00");
            lblTotalProduct.Text = dbcon.ExtractData("SELECT COUNT(*) FROM tbProduct").ToString("#,##0");
            lblStockOnHand.Text = dbcon.ExtractData("SELECT ISNULL(SUM(qty), 0) AS qty FROM tbProduct").ToString("#,##0");
            lblCriticalItems.Text = dbcon.ExtractData("SELECT COUNT(*) FROM vwCriticalItems").ToString("#,##0"); 
        }

    }
}
