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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Category category;
        public CategoryModule(Category ct)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            category = ct;
        }

        public void Clear()
        {
            txtCategory.Clear();
            txtCategory.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbCategory(category)VALUES(@category)", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successful saved.", "Point Of Sales");
                    Clear();                    
                }
                category.LoadCategory();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update brand name
            if (MessageBox.Show("Are you sure you want to update this category?", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbCategory SET category = @category WHERE id LIKE'" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@category", txtCategory.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Category has been successfully updated.", "Point Of Sales");
                Clear();
                this.Dispose();// To close this form after update data
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CategoryModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
