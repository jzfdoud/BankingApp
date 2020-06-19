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

        public bool Transfer(Account ToAccount, double Amount)
        {
            var Success = Withdrawl(Amount);
            if (!Success)
            {
                Console.WriteLine($"{Amount} - Transfer failed - See log file.");
                return false;
            }
            Success = ToAccount.Deposit(Amount);
            if (!Success)
            {
                Console.WriteLine($"{Amount} - Transfer failed - See log file.");
                Deposit(Amount);
                return false;
            }
            return true;
        }

        private bool IsAmountNegative(double Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine($"{Amount} - Invalid Amount. Amount must be positive number.");
                return true;
            }
            return false;
        }

        public bool Deposit(double Amount)
        {
            if (IsAmountNegative(Amount))
            {
                return false;
            }
            Balance += Amount;
            return true;
        }

        public bool Withdrawl(double Amount)
        {
            if (IsAmountNegative(Amount) || InsufficientFunds(Amount))
            {
                return false;
            }
           
            Balance -= Amount;
            return true;
        }

        private bool InsufficientFunds(double Amount)
        {
            if (Amount > Balance)
            {
                Console.WriteLine($"{Amount} - Insufficient Funds, cannot complete withdrawl.");
                return true;
            }
            return false;
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
