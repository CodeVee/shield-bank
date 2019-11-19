using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShieldBank
{
    public partial class Login : Form
    {
        SqlConnection con = AdminProps.con;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblNotFound.Text = "";
            lblEmptyUsername.Text = "";
            pbLoading.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            if (username == "")
            {
                lblNotFound.Text = "";
                lblEmptyUsername.Text = "Username can't be Empty";
            }
            else if (password == "")
            {
                lblNotFound.Text = "Password can't be Empty";
                lblEmptyUsername.Text = "";
            }
            else
            {
                pbLoading.Show();
                timer1.Start();
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            
            lbltxt.Text = "";
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);
            panelUser.BackColor = Color.FromArgb(78, 184, 206);
            iconUser.Image = Properties.Resources.icons8_user_male_26px_6;

            txtPassword.ForeColor = Color.White;
            panelPass.BackColor = Color.White;
            iconPass.Image = Properties.Resources.icons8_password_24px_2;
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            
            lbltxt2.Text = "";
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            panelPass.BackColor = Color.FromArgb(78, 184, 206);
            iconPass.Image = Properties.Resources.icons8_password_24px_3;

            txtUsername.ForeColor = Color.White;
            panelUser.BackColor = Color.White;
            iconUser.Image = Properties.Resources.icons8_user_male_26px_1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            pbLoading.Hide();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string encrypt = AdminProps.SHA1(password + AdminProps.salt);
            string prefix = "";
            bool admin = false;

            try
            {
                prefix = username.Substring(0, 10);

                if (prefix == AdminProps.AdminPrefix)
                {
                    admin = true;
                }
            }
            catch (Exception)
            {


            }

            if (admin)
            {
                string query = "SELECT AdminID, AdminType, AdminFirstName, AdminLastName FROM Administrators WHERE " +
                    "AdminUsername = @username AND AdminPassword = @hash";
                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@hash", encrypt);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        AdminProps.AdminId = reader.GetInt32(0);
                        AdminProps.AdminType = reader.GetString(1);
                        AdminProps.AdminNames = reader.GetString(2) + " " + reader.GetString(3);
                        AdminProps.con.Close();

                        if (AdminProps.AdminType == "Super")
                        {
                            SuperAdminDashboard superAdmin = new SuperAdminDashboard();
                            superAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            AdminDashboard adm = new AdminDashboard();
                            adm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        lblNotFound.Text = "Invalid Login Details";
                        lblEmptyUsername.Text = "";
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    con.Close();
                }
            }

            if (!admin)
            {
                string query = "SELECT CustomerID, CustomerFirstName, CustomerLastName, CustomerPassword FROM Customers WHERE " +
                    "CustomerUsername = @username AND CustomerPassword = @hash";
                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@hash", encrypt);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        AdminProps.ID = reader.GetInt32(0);
                        AdminProps.FirstName = reader.GetString(1);
                        AdminProps.LastName = reader.GetString(2);
                        AdminProps.Password = reader.GetString(3);
                        con.Close();

                        CustomerDashboard customerDashboard = new CustomerDashboard();
                        customerDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblNotFound.Text = "Invalid Login Details";
                        lblEmptyUsername.Text = "";
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    con.Close();
                }
            }
        }
    }
}
