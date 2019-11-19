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
    public partial class AdminCreateCustomer : Form
    {

        public AdminCreateCustomer()
        {
            InitializeComponent();
        }

        private void AdminCreateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtCreateFName.Text == "" || txtCreateLName.Text == "" || txtCreateEmail.Text == "" || txtCreatePhone.Text == "")
            {
                lblWarning.Text = "Field Cannot Be Empty";
            }
            else if (txtCreateUsername.Text ==  "" || txtCreatePassword.Text == "" || txtCreateAcctNo.Text == "" || txtCreateAcctBal.Text == "")
            {
                lblWarning.Text = "Can't Submit Empty Fields";
            }
            else
            {
                AdminFunctions.FirstName = txtCreateFName.Text;
                AdminFunctions.LastName = txtCreateLName.Text;
                AdminFunctions.Phone = txtCreatePhone.Text;
                AdminFunctions.Email = txtCreateEmail.Text;
                AdminFunctions.AccountNo = txtCreateAcctNo.Text;
                AdminFunctions.AccountType = rdBtnCurrent.Checked ? rdBtnCurrent.Text : rdBtnSavings.Text;
                AdminFunctions.AccountBalance = double.Parse(txtCreateAcctBal.Text);
                AdminFunctions.Username = txtCreateUsername.Text;
                AdminFunctions.Password = txtCreatePassword.Text;

                AdminFunctions.CreateUser();
            }
        }

        private void btnAcctNoCreator_Click(object sender, EventArgs e)
        {
            Random account = new Random();
            int accNumber = account.Next(1012321509, 1012321595);
            txtCreateAcctNo.Text = accNumber.ToString();
        }

        private void clearFields()
        {
            txtCreateFName.Text = "";
            txtCreateLName.Text = "";
            txtCreateEmail.Text = "";
            txtCreatePhone.Text = "";
            txtCreateAcctNo.Text = "";
            txtCreateAcctBal.Text = "";
            txtCreateUsername.Text = "";
            txtCreatePassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
