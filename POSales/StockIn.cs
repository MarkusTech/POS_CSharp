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
    public partial class StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point Of Sales";
        MainForm main;
        public StockIn(MainForm mn)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            main = mn;
            LoadSupplier();
            GetRefeNo();
            txtStockInBy.Text = main.lblUsername.Text;
        }

        public void GetRefeNo()
        {
            Random rnd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rnd.Next();
        }

        public void LoadSupplier()
        {
            cbSupplier.Items.Clear();
            cbSupplier.DataSource =dbcon.getTable("SELECT * FROM tbSupplier");
            cbSupplier.DisplayMember = "supplier";
        }

        public void ProductForSupplier(string pcode)
        {
            string supplier = "";
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn WHERE pcode LIKE '" + pcode + "'", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                supplier = dr["supplier"].ToString();
            }
            dr.Close();
            cn.Close();
            cbSupplier.Text = supplier;
        }

        public void LoadStockIn()
        {
            int i = 0;
            dgvStockIn.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn WHERE refno LIKE '" + txtRefNo.Text + "' AND status LIKE 'Pending'", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr["supplier"].ToString());

            }
            dr.Close();
            cn.Close();
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LinGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefeNo();
        }

        private void LinProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productStock = new ProductStockIn(this);
            productStock.ShowDialog();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStockIn.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this records?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for(int i=0; i<dgvStockIn.Rows.Count;i++)
                        {
                            //update product quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbProduct SET qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode LIKE '" + dgvStockIn.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //update stockin quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbStockIn SET qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + ", status='Done' WHERE id LIKE '" + dgvStockIn.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        Clear();
                        LoadStockIn();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Clear()
        {
            txtRefNo.Clear();
            txtStockInBy.Clear();
            dtStockIn.Value = DateTime.Now;
        }

        private void dgvStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStockIn.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbStockIn WHERE id='" + dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully removed", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                dgvInStockHistory.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM vwStockIn WHERE CAST(sdate as date) BETWEEN '"+dtFrom.Value.ToShortDateString()+ "' AND '" + dtTo.Value.ToShortDateString() + "' AND status LIKE 'Done'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvInStockHistory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString(), dr["supplier"].ToString());

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cbSupplier_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbSupplier WHERE supplier LIKE '" + cbSupplier.Text + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblId.Text = dr["id"].ToString();
                txtConPerson.Text = dr["contactperson"].ToString();
                txtAddress.Text = dr["address"].ToString();

            }
            dr.Close();
            cn.Close();
        }
    }
}
