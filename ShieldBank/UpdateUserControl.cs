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
    public partial class UpdateUserControl : UserControl
    {
        int ID { get; set; }
        SqlConnection con = AdminProps.con;
        public UpdateUserControl()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblNotFound.Text = "";
            lblWarning.Text = "";
            lblSuccess.Text = "";
            txtCheckAcctNo.Text = "";
            txtUpdateEmail.Text = "";
            txtUpdateFName.Text = "";
            txtUpdateLName.Text = "";
            txtUpdatePhone.Text = "";
        }

        private void UpdateUserControl_Load(object sender, EventArgs e)
        {
            lblNotFound.Text = "";
            lblWarning.Text = "";
            lblSuccess.Text = "";
            pbTransact.Hide();
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
                pbGenerate.Show();
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string fName = txtUpdateFName.Text;
            string lName = txtUpdateLName.Text;
            string email = txtUpdateEmail.Text;
            string phone = txtUpdatePhone.Text;

            if (fName == "" || lName == "" || email == "" || phone == "")
            {
                lblWarning.Text = "Fields can't be empty";
                lblSuccess.Text = "";
                lblNotFound.Text = "";
            }
            else
            {
                timerUpdate.Start();
                pbTransact.Show();
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            timerCheck.Stop();
            pbGenerate.Hide();

            string acctNo = txtCheckAcctNo.Text;

            string query = "SELECT CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPhone FROM Customers WHERE CustomerID = @id";
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
                    con.Close();
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
                    txtUpdateFName.Text = read.GetString(0);
                    txtUpdateLName.Text = read.GetString(1);
                    txtUpdateEmail.Text = read.GetString(2);
                    txtUpdatePhone.Text = read.GetString(3);
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

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            timerUpdate.Stop();
            pbTransact.Hide();

            string fName = txtUpdateFName.Text;
            string lName = txtUpdateLName.Text;
            string email = txtUpdateEmail.Text;
            string phone = txtUpdatePhone.Text;

            string query = "UPDATE Customers SET CustomerFirstName = @fname, CustomerLastName = @lname, CustomerEmail = @email," +
                    " CustomerPhone = @phone WHERE CustomerID = @id";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@fname", fName);
            command.Parameters.AddWithValue("@lname", lName);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@id", ID);

            try
            {
                con.Open();
                int done = command.ExecuteNonQuery();

                if (done >= 0)
                {
                    lblSuccess.Text = "Customer Details Updated";
                    lblWarning.Text = "";
                    lblNotFound.Text = "";
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
