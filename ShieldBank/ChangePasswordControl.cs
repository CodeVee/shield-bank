using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShieldBank
{
    public partial class ChangePasswordControl : UserControl
    {

        string salt = AdminProps.salt;
        SqlConnection con = AdminProps.con;
        public ChangePasswordControl()
        {
            InitializeComponent();
        }

        private void lblSuccess_Click(object sender, EventArgs e)
        {

        }

        private void ChangePasswordControl_Load(object sender, EventArgs e)
        {

            lblSuccess.Text = "";
            lblWarning.Text = "";
            pbUpdate.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "") lblWarning.Text = "Enter Your Old Password";
            else if (txtNewPassword.Text == "") lblWarning.Text = "Enter New Password";
            else
            {
                timerPass.Start();
                pbUpdate.Show();
            }
        }

        private void timerPass_Tick(object sender, EventArgs e)
        {
            timerPass.Stop();
            pbUpdate.Hide();

            string old = txtOldPassword.Text;
            string hashOld = AdminProps.SHA1(old + salt);

            if (hashOld == AdminProps.Password)
            {
                string newHashPass = AdminProps.SHA1(txtNewPassword.Text + salt);
                string query = "UPDATE Customers SET CustomerPassword = @hash WHERE CustomerID = @id";

                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@hash", newHashPass);
                com.Parameters.AddWithValue("@id", AdminProps.ID);

                try
                {
                    con.Open();

                    int done = com.ExecuteNonQuery();
                    if (done >= 0)
                    {
                        lblSuccess.Text = "Password Updated Successfully";
                        lblWarning.Text = "";
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                lblWarning.Text = "Incorrect Password";
            }
        }
    }
}
