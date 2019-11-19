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
    public partial class CustomerDeposit : UserControl
    {
        SqlConnection con = AdminProps.con;
        public CustomerDeposit()
        {
            InitializeComponent();
        }

        private void CustomerDeposit_Load(object sender, EventArgs e)
        {
            lblSuccess.Text = "";
            lblWarning.Text = "";
            pbTransact.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(AdminProps.AccountNo.GetType().ToString());
            if (AdminProps.AccountNo == null)
            {
                lblWarning.Text = "Please Select An Account";
            }
            else if (txtDepositAmount.Text == "")
            {
                lblWarning.Text = "Please Fill in an amount";
            }
            else
            {
                timerTransact.Start();
                pbTransact.Show();             
            }
        }

        private void timerTransact_Tick(object sender, EventArgs e)
        {
            timerTransact.Stop();
            pbTransact.Hide();

            string amount = txtDepositAmount.Text;
            string query = "UPDATE Accounts SET AccountBalance = @amnt WHERE AccountNumber = @acctNo";
            string secQuery = "INSERT INTO History VALUES(@desc, @amnt, @acctNo, @created, @id)";
            SqlCommand com = new SqlCommand(query, con);
            SqlCommand mand = new SqlCommand(secQuery, con);

            com.Parameters.AddWithValue("@acctNo", AdminProps.AccountNo);
            mand.Parameters.AddWithValue("@desc", AdminProps.Deposit());
            mand.Parameters.AddWithValue("@acctNo", AdminProps.AccountNo);
            mand.Parameters.AddWithValue("@created", AdminProps.CreatedAt);
            mand.Parameters.AddWithValue("@id", AdminProps.ID);

            try
            {
                double parse = double.Parse(amount);
                AdminProps.AccountBalance += parse;
                com.Parameters.AddWithValue("@amnt", AdminProps.AccountBalance);
                mand.Parameters.AddWithValue("@amnt", parse);
                con.Open();

                int done = com.ExecuteNonQuery();
                int made = mand.ExecuteNonQuery();
                if (done >= 0 && made >= 0)
                {
                    lblSuccess.Text = "Deposit Successful";
                    lblWarning.Text = "";
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
