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
    public partial class CustomerDeposit : Form
    {
        public double amount { get; set; }
        public CustomerDeposit()
        {
            InitializeComponent();
        }

        private void lblCreateFName_Click(object sender, EventArgs e)
        {

        }

        private void CustomerDeposit_Load(object sender, EventArgs e)
        {
            lblBal.Text = "$ " + CustomerFunctions.AcctBal;
            btnDeposit.Text = "Deposit";
            btnHome.Text = "Home";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {        
            try
            {
                CustomerFunctions.con.Open();

                amount = double.Parse(txtDepositAmnt.Text);
                CustomerFunctions.AcctBal += amount;

                string qry = "UPDATE Customer SET CustomerAccountBalance = '" + CustomerFunctions.AcctBal + "' WHERE CustomerID = '"
                    + CustomerFunctions.CustomerID + "'";

                string qury = "insert into [Transaction] values('" + @btnDeposit.Text + "', '" + @amount + "', '" + DateTime.Now + "', '" + CustomerFunctions.CustomerID + "')";


                
                SqlCommand cmd = new SqlCommand(qry, CustomerFunctions.con);
                SqlCommand comd = new SqlCommand(qury, CustomerFunctions.con);

                //comd.Parameters.AddWithValue("");
                int j = cmd.ExecuteNonQuery();
                int i = comd.ExecuteNonQuery();

                if (j >= 0 && i >= 0)
                {
                    MessageBox.Show("Deposit successful");
                    lblBal.Text = "$ " + CustomerFunctions.AcctBal;
                    CustomerFunctions.con.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("The following error occured: " + ex.Message);
                CustomerFunctions.con.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CustomerInterface customerInterface = new CustomerInterface();
            this.Hide();
            customerInterface.Show();
        }
    }
}
