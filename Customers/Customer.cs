using System;


namespace Customers
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }

        public double Balance { get; set; }

        public void GetInfomation()
        {
            Console.WriteLine("Account Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("------------------------------");
        }

        public void GetBalance()
        {

            Console.WriteLine($"Your Current Balance is N {Balance}");
        }

        public void MakeDeposit()
        {
            Console.WriteLine("Enter the amount to Deposit");
            string number = Console.ReadLine();

            try
            {
                int amount = int.Parse(number);
                Balance += amount;
                Console.WriteLine("Deposit Successful");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid input: " + ex.Message);
                MakeDeposit();
            }
            Console.WriteLine($"Your New Balance is N {Balance}");
        }

        public void MakeWithdrawal ()
        {
            Console.WriteLine("Enter the amount to withdraw");
            string number = Console.ReadLine();

            try
            {
                int amount = int.Parse(number);

                if (AccountType == "Savings")
                {
                    if (Balance - amount >= 1000)
                    {
                        Balance -= amount;
                        Console.WriteLine("Here is Your cash");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance ");
                    }
                } 

                if (AccountType == "Current")
                {
                    if (Balance - amount >= 0)
                    {
                        Balance -= amount;
                        Console.WriteLine("Here is Your cash");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance");
                    }
                }
                

            }
            catch (Exception error)
            {

                Console.WriteLine("Invalid input: "  + error.Message);
                MakeWithdrawal();
            }
            Console.WriteLine($"Your New Balance is N {Balance}");
        }

        public void Transfer ()
        {
            Console.WriteLine("Enter Account Number");
            string account = Console.ReadLine();

            
            Console.WriteLine("Enter the amount to withdraw");
            string number = Console.ReadLine();

            try
            {
                int amount = int.Parse(number);

                if (AccountType == "Savings")
                {
                    if (Balance - amount >= 1000)
                    {
                        Balance -= amount;
                        Console.WriteLine("Here is Your cash");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance ");
                    }
                }

                if (AccountType == "Current")
                {
                    if (Balance - amount >= 0)
                    {
                        Balance -= amount;
                        Console.WriteLine("Here is Your cash");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance");
                    }
                }


            }
            catch (Exception error)
            {

                Console.WriteLine("Invalid input: " + error.Message);
                MakeWithdrawal();
            }
            Console.WriteLine($"Your New Balance is N {Balance}");
        }

       

    }

    
}
