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
}
