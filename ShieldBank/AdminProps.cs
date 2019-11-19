using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShieldBank
{
    class AdminProps
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-4F2UI6D;Initial Catalog=BankApp;Integrated Security=True");
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static int ID { get; set; }
        public static string AccountNo { get; set; }
        public static string AccountType { get; set; }
        public static double AccountBalance { get; set; }
        public static string Password { get; set; }

        public static DateTime CreatedAt = DateTime.Now;
        
        public static int AdminId { get; set; }
        public static string AdminNames { get; set; }
        public static string AdminType { get; set; }

        public static string TempNames { get; set; }
        public static double TempBal { get; set; }
        public static string TempAcctNo { get; set; } 
        public static string salt = "EDITH";
        public static string AdminPrefix = "s2h0I1e9lD";

        public static string SHA1(string input)
        {
            byte[] hash;

            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                hash = sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
            }

            var sb = new StringBuilder();

            foreach (byte b in hash) sb.AppendFormat("{0:x2}", b);
            return sb.ToString();
        }

        public static bool Unique(string username)
        {
            string query = "SELECT * FROM Customers WHERE CustomerUsername=@user";
            bool uniq = false;
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@user", username);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
                con.Close();
            }
            con.Close();
            return uniq;
        }

        public static bool UniqueEmail(string email)
        {
            string query = "SELECT * FROM Customers WHERE CustomerUsername= @email";
            bool uniq = false;
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@email", email);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
                con.Close();
            }
            con.Close();
            return uniq;
        }

        public static bool UniquePhone(string phone)
        {
            string query = "SELECT * FROM Customers WHERE CustomerUsername= @phone";
            bool uniq = false;
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@phone", phone);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
                con.Close();
            }
            con.Close();
            return uniq;
        }

        public static string Deposit()
        {
            string[] dep = new string[]
            {
                "Bank Deposit @ Ajah Branch",
                "ATM Deposit @ Surulere",
                "Bank Deposit @ Igbo Efon"
            };

            Random rand = new Random();
            int random = rand.Next(3);

            return dep[random];
        }

        public static string Withdraw()
        {
            string[] dep = new string[]
            {
                "Bank Withdrawal @ Ajah Branch",
                "ATM Withdrawal @ Surulere",
                "Cheque cashed @ Igbo Efon Branch",
                "JumiaPay Services @WEBGATEWAY",
                "POS 12908 @ Genesis Cinema"
            };

            Random rand = new Random();
            int random = rand.Next(5);

            return dep[random];
        }
    }
}
