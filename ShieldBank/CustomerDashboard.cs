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

namespace ShieldBank
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
            fill();
        }

        void fill()
        {
            string qury = "SELECT AccountNumber FROM Accounts WHERE CustomerID = @id";
            SqlCommand com = new SqlCommand(qury, AdminProps.con);

            com.Parameters.AddWithValue("@id", AdminProps.ID);

            try
            {
                AdminProps.con.Open();
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string acctNo = reader.GetString(0);
                    AcctNoComboBox.Items.Add(acctNo);

                }
                AdminProps.con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
                AdminProps.con.Close();
            }
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = AdminProps.FirstName + " " + AdminProps.LastName;
            lblAcctBal.Text = "";
            lblAcctType.Text = "";
            customerDeposit1.BringToFront();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblAcctBal.Text = "₦ " + AdminProps.AccountBalance;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnDeposit.Height;
            activePanel.Top = btnDeposit.Top;
            customerDeposit1.BringToFront();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnWithdraw.Height;
            activePanel.Top = btnWithdraw.Top;
            customerWithdrwalControl1.BringToFront();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnTransfer.Height;
            activePanel.Top = btnTransfer.Top;
            customerTransformControl1.BringToFront();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnHistory.Height;
            activePanel.Top = btnHistory.Top;
            customerHistoryControl1.BringToFront();
        }

        private void AcctNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string acctNo = AcctNoComboBox.Text;


            string query = "SELECT AccountType, AccountBalance FROM Accounts WHERE AccountNumber = @acctNo";
            SqlCommand command = new SqlCommand(query, AdminProps.con);

            command.Parameters.AddWithValue("@acctNo", acctNo);

            try
            {
                AdminProps.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    AdminProps.AccountNo = acctNo;
                    AdminProps.AccountBalance = reader.GetDouble(1);
                    AdminProps.AccountType = reader.GetString(0);
                    AdminProps.con.Close();
                }

                lblAcctBal.Text = "₦ " + AdminProps.AccountBalance;
                lblAcctType.Text = AdminProps.AccountType == "Savings" ? "EveryDay Savings" : "Premium Current";
            }
            catch (Exception ex)
            {
                AdminProps.con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnPassword.Height;
            activePanel.Top = btnPassword.Top;
            changePasswordControl1.BringToFront();
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
