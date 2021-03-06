﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BankingApp
{
    // inherited from Account class

    public class Savings : Account 
    {
        // get properties set up first
        public double _InterestRate { get; private set; } = 0;

        private double CalculateInterestAmount(int NumberOfMonths)
        {
            return _InterestRate / 12 * NumberOfMonths * GetBalance();
        }

        public bool CalculateAndDepositInterest(int NumberOfMonths)
        {
            if (NumberOfMonths <= 0)
            {
                Console.WriteLine($"{NumberOfMonths}  Number of months must be greater than zero.");
                return false;
            }
            var InterestToBeDeposited = CalculateInterestAmount(NumberOfMonths);
            return Deposit(InterestToBeDeposited);
        }

        public bool InterestRate(double NewInterestRate)
        {
            if (NewInterestRate < 0)
            {
                Console.WriteLine($"{NewInterestRate} Interest Rate cannot be negative.");
                return false;
            }
            if (NewInterestRate < 0.10)
            {
                Console.WriteLine($"{NewInterestRate} Interest Rate cannot be greater than 10.");
                return false;
            }
            _InterestRate = NewInterestRate;
            return true;
        }

        public Savings() : base()
        {
            Description = "New Savings Account";
        }

    }
}
