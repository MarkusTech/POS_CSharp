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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        MainForm main;
        public string username;
        string name;
        string role;
        string accstatus;
        public UserAccount(MainForm mn)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            main = mn;
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void Clear()
        {
            txtName.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            txtUsername.Clear();
            cbRole.Text = "";
            txtUsername.Focus();
        }

        private void btnAccSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("Password did not March!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("Insert into tbUser(username, password, role, name) Values (@username, @password, @role, @name)", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                cm.Parameters.AddWithValue("@role", cbRole.Text);
                cm.Parameters.AddWithValue("@name", txtName.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadUser();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnPassSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCurPass.Text != main._pass )
                {
                    MessageBox.Show("Current password did not martch!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(txtNPass.Text != txtRePass2.Text)
                {
                    MessageBox.Show("Confirm new password did not martch!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dbcon.ExecuteQuery("UPDATE tbUser SET password= '" + txtNPass.Text + "' WHERE username='" + lblUsername.Text + "'");
                MessageBox.Show("Password has been succefully changed!", "Changed Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            lblUsername.Text = main.lblUsername.Text;
        }

        private void btnPassCancel_Click(object sender, EventArgs e)
        {
            ClearCP();
        }

        public void ClearCP()
        {
            txtCurPass.Clear();
            txtNPass.Clear();
            txtRePass2.Clear();
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvUser.CurrentRow.Index;
            username = dgvUser[1, i].Value.ToString();
            name = dgvUser[2, i].Value.ToString(); 
            role = dgvUser[4, i].Value.ToString();
            accstatus = dgvUser[3, i].Value.ToString();
            if (lblUsername.Text == username)
            {
                btnRemove.Enabled = false;
                btnResetPass.Enabled = false;
                lblAccNote.Text = "To change your password, go to change password tag.";

            }
            else
            {
                btnRemove.Enabled = true;
                btnResetPass.Enabled = true;
                lblAccNote.Text = "To change the password for " + username + ", click Reset Password.";
            }
            gbUser.Text = "Password For " + username;
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("You chose to remove this account from this Point Of Sales System's user list. \n\n Are you sure you want to remove '" + username + "' \\ '" + role + "'", "User Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                dbcon.ExecuteQuery("DELETE FROM tbUser WHERE username = '" + username + "'");
                MessageBox.Show("Account has been successfully deleted");
                LoadUser();
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            ResetPassword reset = new ResetPassword(this);
            reset.ShowDialog();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            UserProperties properties = new UserProperties(this);
            properties.Text = name +"\\"+ username +" Properties";
            properties.txtName.Text = name;
            properties.cbRole.Text = role;
            properties.cbActivate.Text = accstatus;
            properties.username = username;
            properties.ShowDialog();
        }
    }
}
