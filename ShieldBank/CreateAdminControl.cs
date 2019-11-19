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
    public partial class CreateAdminControl : UserControl
    {
        SqlConnection con = AdminProps.con;
        public CreateAdminControl()
        {
            InitializeComponent();
        }

        private void CreateAdminControl_Load(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            lblSuccess.Text = "";
            pbTransact.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCreateAEmail.Text = "";
            txtCreateAFName.Text = "";
            txtCreateALName.Text = "";
            txtCreateAPassword.Text = "";
            txtCreateAPhone.Text = "";
            txtCreateAUsername.Text = "";
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            string fName = txtCreateAFName.Text;
            string lName = txtCreateALName.Text;
            string email = txtCreateAEmail.Text;
            string phone = txtCreateAPhone.Text;
            string type = AdminTypeCombo.Text;
            string username = txtCreateAUsername.Text;
            string password = txtCreateAPassword.Text;
            string hashedPassword = AdminProps.SHA1(password + AdminProps.salt);

            if (fName == "" || lName == "" || email == "" || phone == "" || username == "" || password == "" || type == "")
            {
                lblWarning.Text = "Field Cannot Be Empty";
            }
            else
            {
                timerCreate.Start();
                pbTransact.Show();
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            txtCreateAUsername.Text = AdminProps.AdminPrefix;  
        }

        private void timerCreate_Tick(object sender, EventArgs e)
        {
            timerCreate.Stop();
            pbTransact.Hide();

            string fName = txtCreateAFName.Text;
            string lName = txtCreateALName.Text;
            string email = txtCreateAEmail.Text;
            string phone = txtCreateAPhone.Text;
            string type = AdminTypeCombo.Text;
            string username = txtCreateAUsername.Text;
            string password = txtCreateAPassword.Text;
            string hashedPassword = AdminProps.SHA1(password + AdminProps.salt);

            string query = "insert into Administrators values(@fName, @lName, @email, @phone, @username, @hashed, @type, @created)";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@fName", fName);
            command.Parameters.AddWithValue("@lName", lName);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@hashed", hashedPassword);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@created", AdminProps.CreatedAt);

            try
            {

                con.Open();
                int check = command.ExecuteNonQuery();
                if (check >= 0)
                {
                    lblWarning.Text = "";
                    lblSuccess.Text = "Admin created successfully";
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred during the write operation:" + ex.Message);
                con.Close();
            }
        }
    }
}
