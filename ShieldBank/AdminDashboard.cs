using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShieldBank
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = AdminProps.AdminNames;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void lblAdminName_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnCreate.Height;
            activePanel.Top = btnCreate.Top;
            createUserControl1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnUpdate.Height;
            activePanel.Top = btnUpdate.Top;
            updateUserControl1.BringToFront();
        }

        private void btnMultipleAcct_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnMultipleAcct.Height;
            activePanel.Top = btnMultipleAcct.Top;
            multipleAccountControl1.BringToFront();
        }
    }
}
