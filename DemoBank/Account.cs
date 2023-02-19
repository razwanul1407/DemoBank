namespace DemoBank
{
    class Account 
    {
        public string name;
        public string ID;
        public double balance;
        public string type;
        public double ammount;

        //public void printAccount()
        //{
        //    Console.WriteLine("Name : " + name);
        //    Console.WriteLine("Account No :" + ID);
        //    Console.WriteLine("Balance :" + balance);
        //    Console.WriteLine("Type : " + type);

        //}

        public Account(string name, string ID, double balance, string type)
        {
            this.name = name;
            this.ID = ID;
            this.balance = balance;
            this.type = type;
        }
        public virtual void Deposit(double amount)
        {
            ammount = amount;
            balance = balance + ammount;
            Console.WriteLine("You account balance has been deposited.Balance is: " + balance);
        }
        public virtual void Withdraw(double amount)
        {
            ammount = amount;
            balance = balance - ammount;
            Console.WriteLine("You account balance has been withdrawed.Balance is: " + balance);
        }

       

    }
}
