﻿using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {


           // Console.WriteLine($"Routing number is {Account.GetRoutingNumber()}");

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
