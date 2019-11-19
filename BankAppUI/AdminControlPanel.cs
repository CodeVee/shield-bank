using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankAppUI
{
    public partial class AdminControlPanel : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4F2UI6D;Initial Catalog=BankApp;Integrated Security=True");

        public AdminControlPanel()
        {
            InitializeComponent();
        }

        private void AdminControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitAdminData_Click(object sender, EventArgs e)
        {
            string fName = txtAdminFirstNAme.Text;
            string lName = txtAdminLastName.Text;
            string eMail = txtAdminEmail.Text;
            string password = txtAdminPassword.Text;
            string uName = txtAdminUserName.Text;
            DateTime current = DateTime.Now;
            
            string qry = "insert into Admin values('" + fName + "', '" + lName + "', '" + eMail + "', '" + uName + "', '" + password + "', '" + current + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i >= 0)
                {
                    
                    MessageBox.Show("Admin added successfully");
                    con.Close();
                }
           
            }catch(Exception ex)
            {
                MessageBox.Show("The following error occurred during the write operation:" + ex.Message);
            }
        }

        private void txtAdminPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
