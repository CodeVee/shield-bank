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

namespace BankAppUI
{
    public partial class AdminLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4F2UI6D;Initial Catalog=BankApp;Integrated Security=True");
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            txtAdminLogin.Text = "Administrator Login";
            btnAdminLogin.Text = "Login";
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtAdminUserName.Text;
            string password = txtAdminPassword.Text;
            string qry = "SELECT * FROM Admin WHERE AdminUsername='" +username+"' AND AdminPassword='"+password+"'";

            SqlCommand cmd = new SqlCommand(qry, con);
            

            try
            {
                con.Open();
                SqlDataReader i = cmd.ExecuteReader();
                
                if (i.Read())
                {
                    AdminFunctions.AdminId = int.Parse(i.GetValue(0).ToString());
                    AdminFunctions.AdminFirstNAme = i.GetValue(1).ToString();
                    AdminInterface adminInterface = new AdminInterface();
                    adminInterface.Show();
                    this.Hide();
                    
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details");
                    con.Close();
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred during the write operation:" + ex.Message);
            }
        }
    }
}
