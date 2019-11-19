using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppUI
{
    public partial class CustomerInterface : Form
    {
        public CustomerInterface()
        {
            InitializeComponent();
        }

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            txtWelcome.Text = "Welcome " + CustomerFunctions.FirstName + " " + CustomerFunctions.LastName;
            txtAccType.Text = CustomerFunctions.AcctType == "Savings" ? "Everday Savings Account" : "Premium Current Account";
            txtBalance.Text = CustomerFunctions.AcctBal.ToString();
            txtAcctNo.Text = CustomerFunctions.AcctNo;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CustomerFunctions.AcctBal = 0.00;
            CustomerFunctions.AcctNo = "";
            CustomerFunctions.AcctType = "";
            CustomerFunctions.FirstName = "";
            CustomerFunctions.LastName = "";
            CustomerFunctions.CustomerID = 0;

            CustomerLogin customerLogin = new CustomerLogin();
            this.Hide();
            customerLogin.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            CustomerDeposit deposit = new CustomerDeposit();
            this.Hide();
            deposit.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            CustomerWithdrawal withdrawal = new CustomerWithdrawal();
            this.Hide();
            withdrawal.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            CustomerTransfer transfer = new CustomerTransfer();
            this.Hide();
            transfer.Show();
        }
    }
}
