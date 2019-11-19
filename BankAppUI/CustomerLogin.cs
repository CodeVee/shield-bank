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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {
            txtCustomerLogin.Text = "Customer Login";
            btnCustomerLogin.Text = "Login";
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            string username = txtCustomerUsername.Text;
            string password = txtCustomerPassword.Text;
            string qry = "SELECT * FROM Customer WHERE CustomerUsername='" + username + "' AND CustomerPassword='" + password + "'";

            SqlCommand cmd = new SqlCommand(qry, AdminFunctions.con);


            try
            {
                AdminFunctions.con.Open();
                SqlDataReader i = cmd.ExecuteReader();

                if (i.Read())
                {
                    MessageBox.Show("Login Successful");
                    CustomerFunctions.CustomerID = int.Parse(i.GetValue(0).ToString());
                    CustomerFunctions.FirstName = i.GetValue(1).ToString();
                    CustomerFunctions.LastName = i.GetValue(2).ToString();
                    CustomerFunctions.AcctNo = i.GetValue(5).ToString();
                    CustomerFunctions.AcctType = i.GetValue(6).ToString();
                    CustomerFunctions.AcctBal = double.Parse(i.GetValue(7).ToString());

                    AdminFunctions.con.Close();
                    this.Hide();
                    CustomerInterface customer = new CustomerInterface();
                    customer.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details");
                    AdminFunctions.con.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred during the read operation:" + ex.Message);
            }
        }
    }
}
