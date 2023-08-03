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
    public partial class SupplierModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point Of Sales";
        Supplier supplier;
        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            supplier = sp;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtAddress.Clear();
            txtConPerson.Clear();
            txtEmail.Clear();
            txtFaxNo.Clear();
            txtPhone.Clear();
            txtSupplier.Clear();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtSupplier.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save this record? click yes to confirm.", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Insert into tbSupplier (supplier, address, contactperson, phone, email, fax) values (@supplier, @address, @contactperson, @phone, @email, @fax) ", cn);
                    cm.Parameters.AddWithValue("@supplier", txtSupplier.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtConPerson.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFaxNo.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    supplier.LoadSupplier();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, stitle);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Update this record? click yes to confirm.", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Update tbSupplier set supplier=@supplier, address=@address, contactperson=@contactperson, phone=@phone, email=@email, fax=@fax where id=@id ", cn);
                    cm.Parameters.AddWithValue("@id", lblId.Text);
                    cm.Parameters.AddWithValue("@supplier", txtSupplier.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtConPerson.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFaxNo.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void SupplierModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
