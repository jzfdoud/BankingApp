using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var chk1 = new Checking();
            chk1.Deposit(100);
            chk1.Deposit(300);
            chk1.WriteCheck("Cash", 10, 101);
            chk1.WriteCheck("Apple", 2);
            chk1.WriteCheck("Hulu", 12);
            chk1.WriteCheck("AmazonPrime", 119.99);
            // figure out how to make deposits run before withdrawls-- ken says cant, just write them in the order I want


            var sav1 = new Savings();
            sav1.InterestRate(0.12);
            sav1.Deposit(100);
            sav1.CalculateAndDepositInterest(9);
            //Console.WriteLine($"{InterestToBeDeposited} in Interest has been deposited.");
            // what did I do why I cant use the method in this string, check savings class. Tried outting it there after interest calc.
            Console.WriteLine($"Savings Balance is ${sav1.GetBalance()}.");

            Console.WriteLine($"Routing number is {Account.GetRoutingNumber()}");

            var acct1 = new Account();
            acct1.Deposit(100000);
            acct1.Withdrawl(60000);
            acct1.Withdrawl(50000);
            acct1.Deposit( -20000);
            acct1.Withdrawl(-10000);

            var acct2 = new Account();

            acct1.Transfer(acct2, 1000.00);
            acct1.Transfer(acct2, 40000.00);
            acct1.Transfer(acct2, 5000.00);

            Account.AddAccount(acct1);
            Account.AddAccount(acct2);
            Account.ListAccounts();




        }
    }
}
