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
    public partial class AdminUpdateCustomer : Form
    {
        public AdminUpdateCustomer()
        {
            InitializeComponent();
        }

        private void AdminUpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            //    string acctNo = txtCheckAcctNo.Text;
            //    if (acctNo == "")
            //    {
            //        lblWarning.Text = "Field Can't be Empty";

            //    }
            //    else if (acctNo.Length != 10)
            //    {
            //        lblWarning.Text = "Account Number must be 10 digits";

            //    }
            //    else
            //    {

            //        string qry = "SELECT * FROM Customer WHERE CustomerAccountNo='" + acctNo + "'";

            //        SqlCommand cmd = new SqlCommand(qry, AdminFunctions.con);


            //        try
            //        {
            //            AdminFunctions.con.Open();
            //            SqlDataReader i = cmd.ExecuteReader();

            //            if (i.Read())
            //            {
            //                int id = int.Parse(i.GetValue(0).ToString());
            //                txtUpdateFName.Text = i.GetValue(1).ToString();
            //                txtUpdateLName.Text = i.GetValue(2).ToString();
            //                //AcctNumber = i.GetValue(5).ToString();
            //                //AcctBal = double.Parse(i.GetValue(7).ToString());

            //                //lblAcctHolderName.Text = "" + FirstName + " " + LastName;
            //                //lblAcctHolderNo.Text = "" + AcctNumber;
            //                //lblWarning.Text = "";
            //                AdminFunctions.con.Close();

            //            }
            //            else
            //            {
            //                lblWarning.Text = "Invalid Account Number";

            //                AdminFunctions.con.Close();
            //            }



            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("The following error occurred during the read operation:" + ex.Message);
            //        }
        }
}
}
