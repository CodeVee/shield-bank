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
    public partial class SuperAdminDashboard : Form
    {
        public SuperAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();

        }

        private void lblSAdminName_Click(object sender, EventArgs e)
        {

        }

        private void SuperAdminDashboard_Load(object sender, EventArgs e)
        {
            lblSAdminName.Text = AdminProps.AdminNames;
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

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnCreateAdmin.Height;
            activePanel.Top = btnCreateAdmin.Top;
            createAdminControl1.BringToFront();
        }

        private void createUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
