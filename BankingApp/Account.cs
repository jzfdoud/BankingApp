using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Account
    {

        public int AccountNumber { get; set; }
        public double Balance { get; set; } = 0;
        public string Description { get; set; }


        public void Deposit(double Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Invalid Deposit Amount, Amount must be positive");
                return;
            }
            Balance += Amount;
        }

        public void Withdrawl(double Amount)
        {
            if (Amount > Balance || Amount <= 0)
            {
                Console.WriteLine("Insufficient Funds");
                return;
            }
            Balance -= Amount;
        }

        public double GetBalance()
        {
            return Balance;
        }


        public Account() {
            this.AccountNumber = 0;
            this.Description = "New Account";


        }
    }
}
