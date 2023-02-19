using Microsoft.VisualBasic;
using System;

namespace DemoBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();


            Console.WriteLine("****  Welcome to Bank Management System  ***");

            while (true)
            {
                Console.WriteLine("\nWhat you want to do:");
                Console.WriteLine("1. Create account");
                Console.WriteLine("2. Show account info");
                Console.WriteLine("3. Deposit ");
                Console.WriteLine("4. Withdraw ");
                Console.WriteLine("5. Show all account");
                Console.WriteLine("6. Clear screen");
                Console.WriteLine("7. Exit");

                string input = Console.ReadLine();


                if (input == "1")
                {
                    bank.create_account();
                }
                else if (input == "2")
                {
                    bank.showAll();
                }
                else if (input == "3")
                {

                    bank.deposit();

                    //if(bank.accounts.Count != null)
                    //{
                    //    Console.WriteLine("Please Create Account Frist");
                    //}
                    //else
                    //{
                    //    bank.deposit();
                    //}

                }
                else if (input == "4")
                {

                    bank.withdraw();

                }
                else if (input == "5")
                {
                    bank.showAll();
                }
                else if (input == "6")
                {
                    Console.Clear();
                }
                else if (input == "7")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}