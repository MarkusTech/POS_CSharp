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
    public partial class ProductStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point Of Sales";
        StockIn stockIn;
        public ProductStockIn(StockIn stk)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            stockIn = stk;
            LoadProduct();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT pcode, pdesc, qty FROM tbProduct WHERE pdesc LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                if(stockIn.txtStockInBy.Text == string.Empty)
                {
                    MessageBox.Show("Please enter stock in by name", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stockIn.txtStockInBy.Focus();
                    this.Dispose();                                        
                }

                if (MessageBox.Show("Add this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    addStockIn(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                    MessageBox.Show("Successfully added", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        public void addStockIn(string pcode)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tbStockIn (refno, pcode, sdate, stockinby, supplierid)VALUES (@refno, @pcode, @sdate, @stockinby, @supplierid)", cn);
                cm.Parameters.AddWithValue("@refno", stockIn.txtRefNo.Text);
                cm.Parameters.AddWithValue("@pcode", pcode);
                cm.Parameters.AddWithValue("@sdate", stockIn.dtStockIn.Value);
                cm.Parameters.AddWithValue("@stockinby", stockIn.txtStockInBy.Text);
                cm.Parameters.AddWithValue("@supplierid", stockIn.lblId.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                stockIn.LoadStockIn();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void ProductStockIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
