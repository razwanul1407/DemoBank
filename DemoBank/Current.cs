namespace DemoBank
{
    class Current : Account
    {

        public double LowestBalance = 10000;
        private double WithdrawLimit = 20000;

        public Current(string name, string ID, string type, double balance) : base(name, ID, balance, type)
        {
        }

        public override void Deposit(double amount)
        {
            ammount = amount;
            if (amount < LowestBalance)
            {
                base.Deposit(amount);
                

            }
            else
            {
                Console.WriteLine("You can not deposit more than 10000!");
            }
            //Console.WriteLine("You account balance has been deposited.Balance is: " + balance);

            //else
            //{
            //    //balance = balance + ammount;
            //    //Console.WriteLine("You account balance has been deposited.Balance is: " + balance);

            //}
            // return "You Cannot Diposit more than 10000";
        }

        public override void Withdraw(double amount)
        {
            ammount = amount;

            if (amount < WithdrawLimit)
            {
                Console.WriteLine("You can not withdraw more than 20000.");


            }
            else if (amount < LowestBalance)
            {
                Console.WriteLine("You can not withdraw that ammount of money!");

            }
            else
            {
                
                //Console.WriteLine("You account balance has been withdrawed.Balance is: " + balance);

            }
            // return base.Withdraw(amount);
        }
    }
}
