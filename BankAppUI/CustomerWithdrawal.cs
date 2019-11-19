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
    public partial class CustomerWithdrawal : Form
    {
        public double Amount { get; set; }
        public CustomerWithdrawal()
        {
            InitializeComponent();
        }

        private void CustomerWithdrawal_Load(object sender, EventArgs e)
        {
            lblBal.Text = "$ " + CustomerFunctions.AcctBal;
            btnWithdrawal.Text = "Withdraw";
            btnHome.Text = "Home";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CustomerInterface customerInterface = new CustomerInterface();
            this.Hide();
            customerInterface.Show();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerFunctions.con.Open();

                Amount = double.Parse(txtDepositAmnt.Text);

                if ((CustomerFunctions.AcctBal - Amount >= 0 && CustomerFunctions.AcctType == "Current") || (CustomerFunctions.AcctBal - Amount >= 1000 && CustomerFunctions.AcctType == "Savings"))
                {
                    CustomerFunctions.AcctBal -= Amount;

                    string qry = "UPDATE Customer SET CustomerAccountBalance = '" + CustomerFunctions.AcctBal + "' WHERE CustomerID = '"
                        + CustomerFunctions.CustomerID + "'";

                    string qury = "insert into [Transaction] values('" + btnWithdrawal.Text + "', '" + -Amount + "', '" + DateTime.Now + "', '" + CustomerFunctions.CustomerID + "')";

                    SqlCommand cmd = new SqlCommand(qry, CustomerFunctions.con);
                    SqlCommand comd = new SqlCommand(qury, CustomerFunctions.con);

                    int j = cmd.ExecuteNonQuery();
                    int i = comd.ExecuteNonQuery();

                    if (j >= 0 && i >= 0)
                    {
                        MessageBox.Show("Withdrawal successful");
                        lblBal.Text = "$ " + CustomerFunctions.AcctBal;
                        CustomerFunctions.con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient Balance");
                    CustomerFunctions.con.Close();
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("The following error occured: " + ex.Message);
                CustomerFunctions.con.Close();
            }
        }
    }
}
