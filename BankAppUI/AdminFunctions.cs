using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppUI
{
    class AdminFunctions
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-4F2UI6D;Initial Catalog=BankApp;Integrated Security=True");
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string Phone { get; set; }
        public static string AccountNo { get; set; }
        public static string AccountType { get; set; }
        public static double AccountBalance { get; set; }

        public static string Username { get; set; }
        public static string Password { get; set; }

        public static DateTime CreatedAt = DateTime.Now;

        public static int AdminId { get; set; }

        public static string AdminFirstNAme { get; set; }


        public static void CreateUser ()
        {
            
            string qry = "insert into Customer values('" + FirstName + "', '" + LastName + "', '" + Phone + "', '" + Email + "', '" 
                + AccountNo + "', '" + AccountType + "', '" + AccountBalance + "', '" + Username + "', '" + Password + "" +
                "', '" + CreatedAt + "', '" + AdminId + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i >= 0)
                {
                    MessageBox.Show("Customer created successfully");
                    con.Close();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred during the write operation:" + ex.Message);
            }
        }
    }
}
