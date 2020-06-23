using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Exceptions
{
    public class InsufficientFundsException : Exception 
    {
        public int AccountNumber { get; set; }
        public string AccountDescription { get; set; }
        public double Balance { get; set; }
        public double Amount { get; set; }


        public InsufficientFundsException() : base() { }

        public InsufficientFundsException(string message) : base(message) { }

        public InsufficientFundsException(string message, Exception innerException) : base(message, innerException) { }



    }
}
