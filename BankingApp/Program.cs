﻿using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var acct1 = new Account();
            acct1.Deposit(100000);
            acct1.Withdrawl(50000);
            acct1.Withdrawl(60000);
            acct1.Deposit( -20000);
            acct1.Withdrawl(-10000);
        }
    }
}
