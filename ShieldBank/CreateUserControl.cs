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
    public partial class CreateUserControl : UserControl
    {
        SqlConnection con = AdminProps.con;
        public CreateUserControl()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNo.Text = "";
            txtCreateEmail.Text = "";
            txtCreateFName.Text = "";
            txtCreateLName.Text = "";
            txtCreatePassword.Text = "";
            txtCreatePhone.Text = "";
            txtCreateUsername.Text = "";
            txtOpenBal.Text = "";
            lblSuccess.Text = "";
            lblWarning.Text = "";
        }

        private void btnAcctNoCreator_Click(object sender, EventArgs e)
        {
            if (AcctTypeCombo.Text != "")
            {
                timerGen.Start();
                pbGenerate.Show();
            }
        }

        private void CreateUserControl_Load(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            lblSuccess.Text = "";
            pbGenerate.Hide();
            pbTransact.Hide();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {

            string fName = txtCreateFName.Text;
            string lName = txtCreateLName.Text;
            string email = txtCreateEmail.Text;
            string phone = txtCreatePhone.Text;
            string username = txtCreateUsername.Text;
            string password = txtCreatePassword.Text;
            string acctNo = txtAccountNo.Text;
            string acctBal = txtOpenBal.Text;
            string acctType = AcctTypeCombo.Text;


            if (fName == "" || lName == "" || email == "" || phone == "" || username == "" || password == "" || acctBal == ""
                || acctNo == "" || acctType == "")
            {
                lblWarning.Text = "Field Cannot Be Empty";
                lblSuccess.Text = "";
            }
            else
            {
                timerTran.Start();
                pbTransact.Show();
            }
        }

        private void timerGen_Tick(object sender, EventArgs e)
        {
            timerGen.Stop();
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

        private void timerTran_Tick(object sender, EventArgs e)
        {
            timerTran.Stop();
            pbTransact.Hide();

            string fName = txtCreateFName.Text;
            string lName = txtCreateLName.Text;
            string email = txtCreateEmail.Text;
            string phone = txtCreatePhone.Text;
            string username = txtCreateUsername.Text;
            string password = txtCreatePassword.Text;
            string acctNo = txtAccountNo.Text;
            string acctBal = txtOpenBal.Text;
            string acctType = AcctTypeCombo.Text;

            bool uniqueUser = AdminProps.Unique(username);
            bool uniqueEmail = AdminProps.UniqueEmail(email);
            bool uniquePhone = AdminProps.UniquePhone(phone);

            if (uniqueUser) lblWarning.Text = "Username Already exist";
            else if (uniqueEmail) lblWarning.Text = "Email Already exist";
            else if (uniquePhone) lblWarning.Text = "Phone Already exist";
            else
            {

                string hashedPassword = AdminProps.SHA1(password + AdminProps.salt);
                string query = "insert into Customers values(@fName, @lName, @email, @phone, @username, @hashed, @adminID, @created)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@fName", fName);
                command.Parameters.AddWithValue("@lName", lName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@hashed", hashedPassword);
                command.Parameters.AddWithValue("@adminID", AdminProps.AdminId);
                command.Parameters.AddWithValue("@created", AdminProps.CreatedAt);

                try
                {

                    con.Open();
                    int check = command.ExecuteNonQuery();
                    if (check >= 0)
                    {
                        con.Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error occurred during the write operation:" + ex.Message);
                    con.Close();
                }


                string secQuery = "SELECT CustomerID FROM Customers WHERE CustomerUsername =@username";
                SqlCommand sql = new SqlCommand(secQuery, con);
                sql.Parameters.AddWithValue("@username", username);
                int id = 0;

                try
                {
                    con.Open();
                    SqlDataReader read = sql.ExecuteReader();

                    if (read.Read())
                    {
                        id = read.GetInt32(0);
                        con.Close();
                    }
                }
                catch (Exception mess)
                {
                    MessageBox.Show("Error " + mess.Message);
                    con.Close();
                }


                string thirdQuery = "insert into Accounts values(@acctNo, @acctType, @acctBal, @id, @aID, @created)";
                SqlCommand sqlCommand = new SqlCommand(thirdQuery, con);

                sqlCommand.Parameters.AddWithValue("@acctNo", acctNo);
                sqlCommand.Parameters.AddWithValue("@acctType", acctType);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@aID", AdminProps.AdminId);
                sqlCommand.Parameters.AddWithValue("@created", AdminProps.CreatedAt);

                string fourthQuery = "UPDATE LatestNumbers SET AccountNumber = @acctNo WHERE AccountType = @acctType";
                SqlCommand update = new SqlCommand(fourthQuery, con);

                update.Parameters.AddWithValue("@acctNo", acctNo);
                update.Parameters.AddWithValue("@acctType", acctType);

                try
                {
                    double bal = double.Parse(acctBal);
                    sqlCommand.Parameters.AddWithValue("@acctBal", bal);

                    con.Open();
                    int done = sqlCommand.ExecuteNonQuery();
                    int yes = update.ExecuteNonQuery();

                    if (done >= 0 && yes >= 0)
                    {
                        lblSuccess.Text = "Account Created Successfully";
                        lblWarning.Text = "";
                        con.Close();
                    }

                }
                catch (Exception final)
                {
                    MessageBox.Show("Error: " + final.Message);
                    con.Close();
                }
            }
        }
    }
}
