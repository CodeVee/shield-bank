using System;
using System.Collections.Generic;
using Customers;


namespace Admin
{
    public class Admininstrator
    {
        public static readonly List<Customer> customers = new List<Customer>();

        


        public static void Admins()
        {
            Customer customer = new Customer
            {
                AccountNumber = "1012321595",
                Name = "Vee Seeing Sharp",
                Email = "veeCsharp@dec.ins",
                Balance = 15010.50,
                ID = 1,
                AccountType = "Current"
            };

            Customer hello = new Customer
            {
                Balance = 1000.00,
                AccountNumber = "1012324456",
                AccountType = "Savings",
                Name = "Olusegun Bambo",
                Email = "olubams@yapmail.com",
                ID = 2
            };

            customers.Add(customer);
            customers.Add(hello);
        }
        

        public double Balance { get; set; }
        public static void CreateUser()
        {
            Random account = new Random();
            int accNumber = account.Next(1012321509, 1012321595);

            
            Console.WriteLine("Enter Account Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter User Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Account Type");
            string accountType = Console.ReadLine();
            Console.WriteLine("Enter Opening Balance");
            double balance = double.Parse(Console.ReadLine());


            Customer temp = new Customer
            {
                AccountType = accountType,
                Name = name,
                Email = email,
                Balance = balance,
                ID = 2,
#pragma warning disable CA1305 // Specify IFormatProvider
                AccountNumber = accNumber.ToString()
#pragma warning restore CA1305 // Specify IFormatProvider
            };

            customers.Add(temp);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("User has been Created Successfully");
            Console.WriteLine("--------------------------------");
        }

        public static void UpdateUser()
        {
            Console.WriteLine("Enter Customer ID");
            int id = int.Parse(Console.ReadLine());

            Customer update = customers[id];
            Console.WriteLine("");
            Console.WriteLine("1. To Update Name");
            Console.WriteLine("2. To Update Email");
            Console.WriteLine("");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Enter the new name");
                string name = Console.ReadLine();
                update.Name = name;
                Console.WriteLine("Name Updated Successfully");
                Console.WriteLine("");
                update.GetInfomation();
            }
            else if (input == "2")
            {
                Console.WriteLine("Enter the new email");
                string email = Console.ReadLine();
                update.Email = email;
                Console.WriteLine("Email Updated Successfully");
                Console.WriteLine("");
                update.GetInfomation();
            }
            Console.WriteLine("---------------------");


        }
    }
}
