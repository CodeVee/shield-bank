using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppUI
{
    class CustomerFunctions
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-4F2UI6D;Initial Catalog=BankApp;Integrated Security=True");
        public static int CustomerID { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string AcctNo { get; set; }
        public static string AcctType { get; set; }
        public static double AcctBal { get; set; }


    }
}
