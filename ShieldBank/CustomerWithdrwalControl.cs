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
    public partial class CustomerWithdrwalControl : UserControl
    {
        SqlConnection con = AdminProps.con;
        public CustomerWithdrwalControl()
        {
            InitializeComponent();
        }

        private void CustomerWithdrwalControl_Load(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            lblSuccess.Text = "";
            pbTransact.Hide();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWithdrawAmount.Text != "" && AdminProps.AccountNo != null)
                {
                    double amnt = double.Parse(txtWithdrawAmount.Text);

                    timerTransact.Start();
                    pbTransact.Show();
                }
                else if (AdminProps.AccountNo == null)
                {
                    lblWarning.Text = "Select an Account";
                    lblSuccess.Text = "";
                }
                else if (txtWithdrawAmount.Text == "")
                {
                    lblWarning.Text = "Enter an Amount";
                    lblSuccess.Text = "";
                }
                
            }
            catch (Exception)
            {
                con.Close();
                lblWarning.Text = "Enter an valid Amount";
                lblSuccess.Text = "";

            }
        }

        private void timerTransact_Tick(object sender, EventArgs e)
        {
            timerTransact.Stop();
            pbTransact.Hide();

            double amnt = double.Parse(txtWithdrawAmount.Text);

            if ((AdminProps.AccountBalance - amnt >= 1000 && AdminProps.AccountType == "Savings")
                        || (AdminProps.AccountBalance - amnt >= 0 && AdminProps.AccountType == "Current"))
            {
                AdminProps.AccountBalance -= amnt;

                string query = "UPDATE Accounts SET AccountBalance = @amnt WHERE AccountNumber = @acctNo";
                string secQuery = "INSERT INTO History VALUES(@desc, @amnt, @acctNo, @created, @id)";

                SqlCommand com = new SqlCommand(query, con);
                SqlCommand mand = new SqlCommand(secQuery, con);

                com.Parameters.AddWithValue("@acctNo", AdminProps.AccountNo);
                com.Parameters.AddWithValue("@amnt", AdminProps.AccountBalance);

                mand.Parameters.AddWithValue("@desc", AdminProps.Withdraw());
                mand.Parameters.AddWithValue("@amnt", -amnt);
                mand.Parameters.AddWithValue("@acctNo", AdminProps.AccountNo);
                mand.Parameters.AddWithValue("@created", AdminProps.CreatedAt);
                mand.Parameters.AddWithValue("@id", AdminProps.ID);

                con.Open();

                int done = com.ExecuteNonQuery();
                int made = mand.ExecuteNonQuery();


                if (done >= 0 && made >= 0)
                {
                    lblSuccess.Text = "Withdrawal Successful";
                    lblWarning.Text = "";
                    con.Close();
                }
                else con.Close();
            }
            else
            {
                
                lblWarning.Text = "Insufficient Balance";
                lblSuccess.Text = "";
            }
        }
    }
}
