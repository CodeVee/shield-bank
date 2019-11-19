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
    public partial class CustomerHistoryControl : UserControl
    {
        SqlConnection con = AdminProps.con;
        public CustomerHistoryControl()
        {
            InitializeComponent();
        }

        private void HistoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            timerTransact.Start();
            pbGenerate.Show();
            
        }

        private void CustomerHistoryControl_Load(object sender, EventArgs e)
        {
            pbGenerate.Hide();
            

        }

        private void timerTransact_Tick(object sender, EventArgs e)
        {
            timerTransact.Stop();
            pbGenerate.Hide();
           

            string query = "SELECT TransactionDescription, TransactionAmount, TransactionTime FROM History WHERE TransactionAccount = " +
                "'" + AdminProps.AccountNo + "'";
            DataTable data = new DataTable();
            if (AdminProps.AccountNo != null)
            {
                con.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter(query, AdminProps.con);
                sqlData.Fill(data);

                HistoryGridView.DataSource = data;
                con.Close();
            }
            else con.Close();
        }
    }
}
