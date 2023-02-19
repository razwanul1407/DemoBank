using System.Globalization;
using System.Transactions;

namespace DemoBank
{
    class Bank
    {

        List<Account> accounts = new List<Account>();

        public void showAll()
        {
            Console.WriteLine("########- All the acconts information -########");

            foreach (Account account in accounts)
            {
                Console.WriteLine($"Name: {account.name}");
                Console.WriteLine($"ID: {account.ID}");
                Console.WriteLine($"Type: {account.type}");
                Console.WriteLine($"Balance: {account.balance}");

                Console.WriteLine("............................................................................");
            }
        }


        public void create_account()
        {
            string name;
            string ID;
            string type;
            double balance;

            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Current Account");

            int accountType = Convert.ToInt32(Console.ReadLine());

            if (accountType == 1)
            {
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Enter Accont No: ");
                ID = Console.ReadLine();

                type = "Savings";

                Console.WriteLine("Enter Initial Balance: ");
                balance = Convert.ToDouble(Console.ReadLine());

                Saving acc = new Saving(name, ID, type, balance);

                accounts.Add(acc);

            }
            else if (accountType == 2)
            {
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Enter Accont No: ");
                ID = Console.ReadLine();

                type = "Current";

                Console.WriteLine("Enter Initial Balance: ");
                balance = Convert.ToDouble(Console.ReadLine());

                Current accc = new Current(name, ID, type, balance);


                accounts.Add(accc);
            }
        }

        List<AccountList> accountLists= new List<AccountList>();


        public void deposit()
        {

            Console.WriteLine("Please Enter Account Number: ");
            string ac = Convert.ToString(Console.ReadLine());

            foreach (Account account in accounts)
            {
                if (account.ID == ac)
                {
                    
                    Console.WriteLine("Your Account Type is : " + account.type);
                    Console.WriteLine("Your Balance is : " + account.balance);
                    Console.WriteLine("How Much Do You Want to Diposit");
                    double newbalance = Convert.ToDouble(Console.ReadLine());

                    account.Deposit(newbalance);


                    //account.ammount = newbalance;
                    //account.balance = account.balance + account.ammount;
                }
                else 
                {
                    Console.WriteLine("Account Number is invalid");
                }
            }

        }

        public void withdraw()
        {
            Console.WriteLine("Please Enter Account Number: ");
            string ac = Convert.ToString(Console.ReadLine());

            foreach (Account account in accounts)
            {
                if (account.ID == ac)
                {

                    Console.WriteLine("Your Account Type is : " + account.type);
                    Console.WriteLine("Your Balance is : " + account.balance);
                    Console.WriteLine("How Much Do You Want to Withdraw");
                    double newbalance = Convert.ToDouble(Console.ReadLine());

                    account.Withdraw(newbalance);

                    //account.ammount = newbalance;
                    //account.balance = account.balance + account.ammount;
                }
                else
                {
                    Console.WriteLine("Account Number is invalid");
                }
            }
        }
    }
}