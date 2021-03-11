using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount Tim = new BankAccount();
            BankAccount Mark = new BankAccount("Mark", true, 45.00);
            Mark.deposit(25.25);
            Tim.withdraw(76);
            Mark.display_balance();
        }
    }
    class BankAccount
    {
        string accountID;
        bool accountType;
        //savings = true, checking = false
        double balance;
        public BankAccount()
        {
            accountID = "Not Set";
            accountType = false;
            balance = 0.0;
        }
        public BankAccount(string accountid, bool isSavings, double balance)
        {
            accountID = accountid;
            accountType = isSavings;
            this.balance = balance;
        }
        public void withdraw(double amount)
        {
            balance = balance - amount;
            Console.Write(balance);
            Console.WriteLine(" has been withdrawn from: ");
            Console.Write(accountID);
        }
        public void deposit(double amount)
        {
            balance = balance - amount;
            Console.Write(balance);
            Console.WriteLine(" has been deposit to: ");
            Console.Write(accountID);
        }
        public void display_balance()
        {
            Console.Write("Your current balance is: ");
            Console.WriteLine(balance);
        }
    }
}
