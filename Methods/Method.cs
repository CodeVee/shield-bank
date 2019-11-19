using System;
using Admin;
using Utilities;

namespace Methods
{
    public class Method
    {
        public static void Validation ()
        {
            Admininstrator.Admins();

            Console.WriteLine("Please Enter Your UserName");
            string username = Console.ReadLine();

            if (username == "Admin" || username == "user" || username == "user1")
            {
                Console.WriteLine("Please Enter Your Password");
                string password = Console.ReadLine();

                if (username == "Admin" && password == "superuser")
                {
                    Runners.AdminSide();
                    
                }
                else if (username == "user" && password == "winform")
                {

                    Runners.ClientSide(0);
                }
                else if (username == "user1" && password == "console")
                {
                    Runners.ClientSide(1);
                }
                else
                {
                    Console.WriteLine("Wrong PassWord");
                }
            }
            else
            {
                Console.WriteLine("Invalid Username");
            }
        }

    }

    
}
