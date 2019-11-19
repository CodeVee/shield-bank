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
    public partial class CustomerTransfer : Form
    {
        public double AcctBal { get; set; }
        public string AcctNumber { get; set; }
        public double Amount { get; set; }
        public int CustomerID { get; set; }
        public CustomerTransfer()
        {
            InitializeComponent();
        }

        private void CustomerTransfer_Load(object sender, EventArgs e)
        {
            btnCheck.Text = "Check";
            btnHome.Text = "Home";
            btnTransfer.Text = "Transfer";
            lblAcctHolderName.Text = "";
            lblAcctHolderNo.Text = "";
            lblWarning.Text = "";
            lblBal.Text = "$ " + CustomerFunctions.AcctBal;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CustomerInterface customerInterface = new CustomerInterface();
            this.Hide();
            customerInterface.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string acctNo = txtCheckAcctNo.Text;
            if (acctNo == "")
            {
                lblWarning.Text = "Field Can't be Empty";
                lblAcctHolderName.Text = "";
                lblAcctHolderNo.Text = "";
                AcctNumber = "";
            }
            else if (acctNo.Length != 10)
            {
                lblWarning.Text = "Account Number must be 10 digits";
                lblAcctHolderNo.Text = "";
                lblAcctHolderName.Text = "";
                AcctNumber = "";
            }
            else
            {
         
                string qry = "SELECT * FROM Customer WHERE CustomerAccountNo='" + acctNo + "'";

                SqlCommand cmd = new SqlCommand(qry, AdminFunctions.con);


                try
                {
                    AdminFunctions.con.Open();
                    SqlDataReader i = cmd.ExecuteReader();

                    if (i.Read())
                    {
                        CustomerID = int.Parse(i.GetValue(0).ToString());
                        string FirstName = i.GetValue(1).ToString();
                        string LastName = i.GetValue(2).ToString();
                        AcctNumber = i.GetValue(5).ToString();
                        AcctBal = double.Parse(i.GetValue(7).ToString());

                        lblAcctHolderName.Text = "" + FirstName + " " + LastName;
                        lblAcctHolderNo.Text = "" + AcctNumber;
                        lblWarning.Text = "";
                        AdminFunctions.con.Close();
                        
                    }
                    else
                    {
                        lblWarning.Text = "Invalid Account Number";
                        lblAcctHolderName.Text = "";
                        lblAcctHolderNo.Text = "";
                        AcctNumber = "";
                        AdminFunctions.con.Close();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error occurred during the read operation:" + ex.Message);
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (AcctNumber != "")
            {
                try
                {
                    CustomerFunctions.con.Open();

                    Amount = double.Parse(txtTransferAmnt.Text);

                    if ((CustomerFunctions.AcctBal - Amount >= 0 && CustomerFunctions.AcctType == "Current") || (CustomerFunctions.AcctBal - Amount >= 1000 && CustomerFunctions.AcctType == "Savings"))
                    {
                        CustomerFunctions.AcctBal -= Amount;
                        AcctBal += Amount;

                        string qry = "UPDATE Customer SET CustomerAccountBalance = '" + CustomerFunctions.AcctBal + "' WHERE CustomerID = '"
                            + CustomerFunctions.CustomerID + "'";

                        string qury = "insert into [Transaction] values('TransferOut', '" + -Amount + "', '" + DateTime.Now + "', '"
                            + CustomerFunctions.CustomerID + "')";

                        string qry1 = "UPDATE Customer SET CustomerAccountBalance = '" + AcctBal + "' WHERE CustomerID = '"
                            + CustomerID + "'";

                        string qury1 = "insert into [Transaction] values('TransferIn', '" + Amount + "', '" + DateTime.Now + "', '"
                            + CustomerID + "')";

                        SqlCommand cmd = new SqlCommand(qry, CustomerFunctions.con);
                        SqlCommand comd = new SqlCommand(qury, CustomerFunctions.con);

                        SqlCommand cmd1 = new SqlCommand(qry1, CustomerFunctions.con);
                        SqlCommand comd1 = new SqlCommand(qury1, CustomerFunctions.con);

                        int j = cmd.ExecuteNonQuery();
                        int i = comd.ExecuteNonQuery();
                        int k = cmd1.ExecuteNonQuery();
                        int l = comd1.ExecuteNonQuery();

                        if (j >= 0 && i >= 0 && k >= 0 && l >= 0)
                        {
                            MessageBox.Show("Transfer successful");
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
}
