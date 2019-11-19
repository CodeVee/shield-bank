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
    public partial class MultipleAccountControl : UserControl
    {
        int ID { get; set; }
        SqlConnection con = AdminProps.con;
        public MultipleAccountControl()
        {
            InitializeComponent();
        }

        private void MultipleAccountControl_Load(object sender, EventArgs e)
        {
            lblAcctFName.Text = "";
            lblAcctLName.Text = "";
            lblWarning.Text = "";
            lblSuccess.Text = "";
            lblNotFound.Text = "";
            pbTransact.Hide();
            pbCheck.Hide();
            pbGenerate.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtCheckAcctNo.Text.Length != 10)
            {
                lblNotFound.Text = "Invalid Account Number";
            }
            else
            {
                timerCheck.Start();
                pbCheck.Show();
            }
        }

        private void btnAcctNoCreator_Click(object sender, EventArgs e)
        {
            if (AcctTypeCombo.Text != "")
            {
                timerGenerate.Start();
                pbGenerate.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAcctFName.Text = "";
            lblAcctLName.Text = "";
            lblWarning.Text = "";
            lblSuccess.Text = "";
            lblNotFound.Text = "";
            txtAccountNo.Text = "";
            txtCheckAcctNo.Text = "";
            txtOpenBal.Text = "";
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
          
            string acctNo = txtAccountNo.Text;
            string acctType = AcctTypeCombo.Text;
            string acctBal = txtOpenBal.Text;

            if (lblAcctFName.Text == "" || lblAcctLName.Text == "" || acctBal == "" || acctNo == "" || acctType == "")
            {
                lblWarning.Text = "Field Cannot Be Empty";
                lblSuccess.Text = "";
                lblNotFound.Text = "";
            }
            else
            {
                timerTransact.Start();
                pbTransact.Show();
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            timerCheck.Stop();
            pbCheck.Hide();

            string acctNo = txtCheckAcctNo.Text;

            string query = "SELECT CustomerFirstName, CustomerLastName FROM Customers WHERE CustomerID = @id";
            string mini = "SELECT CustomerID FROM Accounts WHERE AccountNumber = @acctNo";
            SqlCommand command = new SqlCommand(mini, con);

            command.Parameters.AddWithValue("@acctNo", acctNo);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = reader.GetInt32(0);
                    AdminProps.con.Close();
                }
                else
                {
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
                    lblAcctFName.Text = read.GetString(0);
                    lblAcctLName.Text = read.GetString(1);

                    lblNotFound.Text = "";
                    lblWarning.Text = "";
                    con.Close();
                }
                else
                {
                    lblNotFound.Text = "Account not Found";
                    lblWarning.Text = "";
                    lblSuccess.Text = "";
                    con.Close();
                }
            }
            catch (Exception px)
            {
                MessageBox.Show("Error " + px.Message);
                con.Close();
            }
        }

        private void timerGenerate_Tick(object sender, EventArgs e)
        {
            timerGenerate.Stop();
            pbGenerate.Hide();

            string type = AcctTypeCombo.Text;
            int accNo = 0;

            string queryAcc = "SELECT AccountNumber from LatestNumbers WHERE AccountType=@type";

            SqlCommand comd = new SqlCommand(queryAcc, con);
            comd.Parameters.AddWithValue("@type", type);

            try
            {
                con.Open();
                SqlDataReader accDits = comd.ExecuteReader();

                if (accDits.Read())
                {
                    accNo = int.Parse(accDits.GetString(0));
                    Random account = new Random();
                    int accNumber = account.Next(accNo + 1, accNo + 3);
                    txtAccountNo.Text = accNumber.ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }

        private void timerTransact_Tick(object sender, EventArgs e)
        {
            timerTransact.Stop();
            pbTransact.Hide();

            string acctNo = txtAccountNo.Text;
            string acctType = AcctTypeCombo.Text;
            string acctBal = txtOpenBal.Text;

            string query = "INSERT INTO Accounts VALUES(@acctNo, @acctType, @acctBal, @id, @aID, @created)";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@acctNo", acctNo);
            command.Parameters.AddWithValue("@acctType", acctType);
            command.Parameters.AddWithValue("@id", ID);
            command.Parameters.AddWithValue("@aID", AdminProps.AdminId);
            command.Parameters.AddWithValue("@created", AdminProps.CreatedAt);

            string fourthQuery = "UPDATE LatestNumbers SET AccountNumber = @acctNo WHERE AccountType = @acctType";
            SqlCommand update = new SqlCommand(fourthQuery, con);

            update.Parameters.AddWithValue("@acctNo", acctNo);
            update.Parameters.AddWithValue("@acctType", acctType);

            try
            {
                double amnt = double.Parse(acctBal);
                command.Parameters.AddWithValue("@acctBal", amnt);

                con.Open();
                int create = command.ExecuteNonQuery();
                int yes = update.ExecuteNonQuery();

                if (create >= 0 && yes >= 0)
                {
                    lblSuccess.Text = "Account Added Successfully";
                    lblWarning.Text = "";
                    lblNotFound.Text = "";
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error " + ex.Message);
            }
        }

        
    }
}
