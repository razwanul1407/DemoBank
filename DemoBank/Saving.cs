using System;

namespace DemoBank
{
    class Saving : Account
    {
        public double highistBalance = 10000;
        private double depositLimit = 2000;


        public Saving(string name, string ID, string type, double balance) : base(name, ID, balance, type)
        {
            Console.WriteLine("Successfully created Savings Account for " + name);
        }

        public override void Deposit(double amount)
        {

            //ammount = amount;
            //balance = balance + ammount;
            if (amount < highistBalance)
            {
                base.Deposit(amount);
                

            }
            else
            {
                Console.WriteLine("You can not deposit more than 10000!");
                
            }
            //Console.WriteLine("You account balance has been deposited.Balance is: " + balance);
            // return "Invalid" ;


            //else
            //{
            //    balance = balance + ammount;
            //    Console.WriteLine("You account balance has been deposited.Balance is: " + balance);
            //}
        }

        public override void Withdraw(double amount)
        {
            //ammount = amount;
            //balance = balance - ammount;

            if (amount < depositLimit)
            {

                base.Withdraw(amount);
               
            }
            else if (amount < highistBalance)
            {
                Console.WriteLine("You can not withdraw that ammount of money!");

            }
            else
            {
                Console.WriteLine("You can not withdraw more than 20000.");
            }
            //else
            //{

            //    Console.WriteLine("You account balance has been withdrawed.Balance is: " + balance);

            //}
        }
    }
}
