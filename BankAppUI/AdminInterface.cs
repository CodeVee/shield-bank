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
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {
            txtWelcomeAdmin.Text = "Welcome " + AdminFunctions.FirstName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AdminCreateCustomer adminCreate = new AdminCreateCustomer();
            this.Hide();
            adminCreate.Show();
        }
    }
}
