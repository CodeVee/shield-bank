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
    public partial class CustomerTransformControl : UserControl
    {
        SqlConnection con = AdminProps.con;
        int ID { get; set; }
        public CustomerTransformControl()
        {
            InitializeComponent();
        }

        private void CustomerTransformControl_Load(object sender, EventArgs e)
        {
            lblFoundAcctName.Text = "";
            lblFoundAcctNo.Text = "";
            lblNotFound.Text = "";
            lblSuccess.Text = "";
            lblWarning.Text = "";
            pbTransact.Hide();
            pbGenerate.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblFoundAcctName.Text = "";
            lblFoundAcctNo.Text = "";
            lblNotFound.Text = "";
            lblSuccess.Text = "";
            txtCheckAcctNo.Text = "";
            txtTransferAmount.Text = "";
            lblWarning.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (AdminProps.AccountNo != null)
            {
                if (txtCheckAcctNo.Text.Length != 10)
                {
                    lblNotFound.Text = "Invalid Account Number";
                    lblSuccess.Text = "";
                    lblWarning.Text = "";
                    lblFoundAcctName.Text = "";
                    lblFoundAcctNo.Text = "";
                }
                else if (txtCheckAcctNo.Text == AdminProps.AccountNo)
                {
                    lblNotFound.Text = "Can't Transfer To The Same Account";
                    lblSuccess.Text = "";
                    lblWarning.Text = "";
                    lblFoundAcctName.Text = "";
                    lblFoundAcctNo.Text = "";
                }
                else
                {
                    lblNotFound.Text = "";
                    timerCheck.Start();
                    pbGenerate.Show();
                }
            }          
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (AdminProps.TempAcctNo != null && txtTransferAmount.Text != "" && AdminProps.AccountNo != null)
            {
                try
                {
                    double amount = double.Parse(txtTransferAmount.Text);

                    timerTransact.Start();
                    pbTransact.Show();
                }
                catch (Exception)
                {
                    lblWarning.Text = "Enter a valid Amount";
                }
            }
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void timerTransact_Tick(object sender, EventArgs e)
        {
            timerTransact.Stop();
            pbTransact.Hide();

            double amount = double.Parse(txtTransferAmount.Text);
            if ((AdminProps.AccountBalance - amount >= 1000 && AdminProps.AccountType == "Savings")
                        || (AdminProps.AccountBalance - amount >= 0 && AdminProps.AccountType == "Current"))
            {
                AdminProps.AccountBalance -= amount;
                AdminProps.TempBal += amount;

                string query = "UPDATE Accounts SET AccountBalance = @amnt WHERE AccountNumber = @acctNo";
                string secQuery = "INSERT INTO History VALUES(@desc, @amnt, @acctNo, @created, @id)";

                string tOut = "Transfer sent to " + AdminProps.TempNames + " " + AdminProps.TempAcctNo;
                string tIn = "TF received FM " + AdminProps.FirstName + " " + AdminProps.LastName + " " + AdminProps.AccountNo;

                SqlCommand com = new SqlCommand(query, con);
                SqlCommand mand = new SqlCommand(secQuery, con);

                com.Parameters.AddWithValue("@acctNo", AdminProps.AccountNo);
                com.Parameters.AddWithValue("@amnt", AdminProps.AccountBalance);

                mand.Parameters.AddWithValue("@desc", tOut);
                mand.Parameters.AddWithValue("@amnt", -amount);
                mand.Parameters.AddWithValue("@acctNo", AdminProps.AccountNo);
                mand.Parameters.AddWithValue("@created", AdminProps.CreatedAt);
                mand.Parameters.AddWithValue("@id", AdminProps.ID);

                SqlCommand com1 = new SqlCommand(query, con);
                SqlCommand mand1 = new SqlCommand(secQuery, con);

                com1.Parameters.AddWithValue("@acctNo", AdminProps.TempAcctNo);
                com1.Parameters.AddWithValue("@amnt", AdminProps.TempBal);

                mand1.Parameters.AddWithValue("@desc", tIn);
                mand1.Parameters.AddWithValue("@amnt", amount);
                mand1.Parameters.AddWithValue("@acctNo", AdminProps.TempAcctNo);
                mand1.Parameters.AddWithValue("@created", AdminProps.CreatedAt);
                mand1.Parameters.AddWithValue("@id", ID);

                con.Open();

                int done = com.ExecuteNonQuery();
                int made = mand.ExecuteNonQuery();

                int done1 = com1.ExecuteNonQuery();
                int made1 = mand1.ExecuteNonQuery();


                if (done >= 0 && made >= 0 && done1 >= 0 && made1 >= 0)
                {
                    lblSuccess.Text = "Transfer Successful";
                    lblWarning.Text = "";
                    con.Close();
                }
                else con.Close();
            }
            else lblWarning.Text = "Insufficient Balance";
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            timerCheck.Stop();
            pbGenerate.Hide();

            string acctNo = txtCheckAcctNo.Text;

            string query = "SELECT CustomerFirstName, CustomerLastName FROM Customers WHERE CustomerID = @id";
            string mini = "SELECT CustomerID, AccountBalance FROM Accounts WHERE AccountNumber = @acctNo";
            SqlCommand command = new SqlCommand(mini, AdminProps.con);

            command.Parameters.AddWithValue("@acctNo", acctNo);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = reader.GetInt32(0);
                    AdminProps.TempBal = reader.GetDouble(1);
                    con.Close();
                }
                else
                {
                    ID = 0;
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error1: " + ex.Message);
                con.Close();
            }

            SqlCommand sql = new SqlCommand(query, AdminProps.con);
            sql.Parameters.AddWithValue("@id", ID);

            try
            {
                con.Open();
                SqlDataReader read = sql.ExecuteReader();

                if (read.Read())
                {
                    lblFoundAcctName.Text = read.GetString(0) + " " + read.GetString(1);
                    lblFoundAcctNo.Text = acctNo;
                    AdminProps.TempAcctNo = acctNo;
                    AdminProps.TempNames = lblFoundAcctName.Text;

                    lblNotFound.Text = "";
                    lblSuccess.Text = "";
                    con.Close();
                }
                else
                {
                    lblNotFound.Text = "Account not Found";

                    lblSuccess.Text = "";
                    lblFoundAcctName.Text = "";
                    lblFoundAcctNo.Text = "";
                    con.Close();
                }
            }
            catch (Exception px)
            {
                MessageBox.Show("Error " + px.Message);
                con.Close();
            }
        }
    }
}
