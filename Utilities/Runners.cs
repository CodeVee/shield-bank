using Admin;
using Customers;
using System;

namespace Utilities
{
    public class Runners
    {

        public static void AdminSide ()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. To Display Account Holders");
                Console.WriteLine("2. To Create Users");
                Console.WriteLine("3. To Update Users");
                Console.WriteLine("AnyKey. To Terminate");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("");
                string selection = Console.ReadLine();
                if (selection == "1")
                {
                    foreach (Customer item in Admininstrator.customers)
                    {
                        item.GetInfomation();
                    }
                }
                else if (selection == "2")
                {
                    Admininstrator.CreateUser();
                }
                else if (selection == "3")
                {
                    Admininstrator.UpdateUser();
                }
                else
                {
                    break;
                }
            }
        }

        public static void ClientSide(int id)
        {
            string exit = "";
            Customer user = Admininstrator.customers[id];
            while (exit != "0")
            {
                Console.WriteLine("1. Get Details");
                Console.WriteLine("2. Get Balance");
                Console.WriteLine("3. Make Deposit");
                Console.WriteLine("4. Make Withdrawal");
                Console.WriteLine("0. End Transaction");
                Console.WriteLine("------------------------");
                exit = Console.ReadLine();

                switch (exit)
                {
                    case "1":
                        user.GetInfomation();
                        break;
                    case "2":
                        user.GetBalance();
                        break;
                    case "3":
                        user.MakeDeposit();
                        break;
                    case "4":
                        user.MakeWithdrawal();
                        break;
                    default:
                        Console.WriteLine("Hello Darkness");
                        break;
                }

            }
        }
    }
}
