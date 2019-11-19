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
    public partial class AdminOrCustomer : Form
    {
        public AdminOrCustomer()
        {
            InitializeComponent();
        }

        private void AdminOrCustomer_Load(object sender, EventArgs e)
        {
            txtWelcome.Text = "Welcome to NewBank";
            txtSelect.Text = "Select An Option";
            rdBtnAdmin.Text = "Admin";
            rdBtnCustomer.Text = "Customer";
            btnSelect.Text = "Select";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (rdBtnAdmin.Checked)
            {
                this.Hide();
                AdminLogin admin = new AdminLogin();
                admin.Show();
            }

            if (rdBtnCustomer.Checked)
            {
                this.Hide();
                CustomerLogin customer = new CustomerLogin();
                customer.Show();
            }
        }
    }
}
