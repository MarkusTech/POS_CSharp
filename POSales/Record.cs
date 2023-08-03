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
    public partial class Record : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Record()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadCriticalItems();
            LoadInventoryList();
        }

        public void LoadTopSelling()
        {
            int i = 0;
            dgvTopSelling.Rows.Clear();
            cn.Open();

            //Sort By Total Amount
            if (cbTopSell.Text == "Sort By Qty")
            {
                cm = new SqlCommand("SELECT TOP 10 pcode, pdesc, isnull(sum(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwTopSelling WHERE sdate BETWEEN '" + dtFromTopSell.Value.ToString() + "' AND '" + dtToTopSell.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", cn);
            }
            else if (cbTopSell.Text == "Sort By Total Amount")
            {
                cm = new SqlCommand("SELECT TOP 10 pcode, pdesc, isnull(sum(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwTopSelling WHERE sdate BETWEEN '" + dtFromTopSell.Value.ToString() + "' AND '" + dtToTopSell.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY total DESC", cn);
            }
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvTopSelling.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
            }
            dr.Close();
            cn.Close();
        }

        public void LoadSoldItems()
        {
            try
            {
                dgvSoldItems.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT c.pcode, p.pdesc, c.price, sum(c.qty) as qty, SUM(c.disc) AS disc, SUM(c.total) AS total FROM tbCart AS c INNER JOIN tbProduct AS p ON c.pcode=p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dtFromSoldItems.Value.ToString() + "' AND '" + dtToSoldItems.Value.ToString() + "' GROUP BY c.pcode, p.pdesc, c.price",cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvSoldItems.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                cn.Close();

                cn.Open();
                cm = new SqlCommand("SELECT ISNULL(SUM(total),0) FROM tbCart WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dtFromSoldItems.Value.ToString() + "' AND '" + dtToSoldItems.Value.ToString() + "'", cn);
                lblTotal.Text = double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void LoadCriticalItems()
        {
            try
            {
                dgvCriticalItems.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM vwCriticalItems",cn);
                dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    i++;
                    dgvCriticalItems.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void LoadInventoryList()
        {
            try
            {
                dgvInventoryList.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM vwInventoryList", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvInventoryList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void LoadCancelItems()
        {
            int i = 0;
            dgvCancel.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwCancelItems WHERE sdate BETWEEN '" + dtFromCancel.Value.ToString() + "' AND '" + dtToCancel.Value.ToString() + "'", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvCancel.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),  DateTime.Parse(dr[6].ToString()).ToShortDateString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadStockInHist()
        {
            int i = 0;
            dgvStockIn.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn WHERE cast(sdate AS date) BETWEEN '" + dtFromStockIn.Value.ToString() + "' AND '" + dtToStockIn.Value.ToString() + "' AND status LIKE 'Done'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnLoadTopSell_Click(object sender, EventArgs e)
        {
            if(cbTopSell.Text== "Select sort type")
            {
                MessageBox.Show("Please select sort type from the dropdown list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTopSell.Focus();
                return;
            }
            LoadTopSelling();
        }

        private void btnLoadSoldItems_Click(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        private void btnPrintSoldItems_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            string param = "From : " + dtFromSoldItems.Value.ToString() + " To : " + dtToSoldItems.Value.ToString();
            report.LoadSoldItems("SELECT c.pcode, p.pdesc, c.price, sum(c.qty) as qty, SUM(c.disc) AS disc, SUM(c.total) AS total FROM tbCart AS c INNER JOIN tbProduct AS p ON c.pcode=p.pcode WHERE status LIKE 'Sold' AND sdate BETWEEN '" + dtFromSoldItems.Value.ToString() + "' AND '" + dtToSoldItems.Value.ToString() + "' GROUP BY c.pcode, p.pdesc, c.price",param);
            report.ShowDialog();
        }

        private void btnLoadCancel_Click(object sender, EventArgs e)
        {
            LoadCancelItems();
        }

        private void btnLoadStockIn_Click(object sender, EventArgs e)
        {
            LoadStockInHist();
        }

        private void btnPrintTopSell_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            string param = "From : " + dtFromTopSell.Value.ToString() + " To : " + dtToTopSell.Value.ToString();
            if (cbTopSell.Text == "Sort By Qty")
            {
                report.LoadTopSelling("SELECT TOP 10 pcode, pdesc, isnull(sum(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwTopSelling WHERE sdate BETWEEN '" + dtFromTopSell.Value.ToString() + "' AND '" + dtToTopSell.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", param, "TOP SELLING ITEMS SORT BY QTY");
            }
            else if (cbTopSell.Text == "Sort By Total Amount")
            {
                report.LoadTopSelling("SELECT TOP 10 pcode, pdesc, isnull(sum(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwTopSelling WHERE sdate BETWEEN '" + dtFromTopSell.Value.ToString() + "' AND '" + dtToTopSell.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY total DESC", param, "TOP SELLING ITEMS SORY BY TOTAL AMOUNT");
            }
            report.ShowDialog();
        }

        private void btnPrintInventoryList_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            report.LoadInventory("SELECT * FROM vwInventoryList");
            report.ShowDialog();
        }

        private void btnPrintCancel_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            string param = "From : " + dtFromCancel.Value.ToString() + " To : " + dtToCancel.Value.ToString();
            report.LoadCancelledOrder("SELECT * FROM vwCancelItems WHERE sdate BETWEEN '" + dtFromCancel.Value.ToString() + "' AND '" + dtToCancel.Value.ToString() + "'", param);
            report.ShowDialog();
        }

        private void btnPrintStockIn_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            string param = "From : " + dtFromStockIn.Value.ToString() + " To : " + dtToStockIn.Value.ToString();
            report.LoadStockInHist("SELECT * FROM vwStockIn WHERE cast(sdate AS date) BETWEEN '" + dtFromStockIn.Value.ToString() + "' AND '" + dtToStockIn.Value.ToString() + "' AND status LIKE 'Done'", param);
            report.ShowDialog();
        }
    }
}
