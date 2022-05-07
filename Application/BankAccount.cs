using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class BankAccount : Transaction
    {
        public string Name;
        public int Number;
        public decimal Balance;
        public decimal LastTransactionAmount;
        public DateTime LastTransactionTime;
        public BankAccount(string Name, int Number)
        {
            Name = Name;
            Number = Number;
            Balance = 0;
        }

        public BankAccount(string Name, int Number, decimal Amount)
        {
            Name = Name;
            Number = Number;
            Balance = Amount;
        }

        public override void makeWithdrawal(string Name, DateTime time, decimal AmountAvailable)
        {
            if (AmountAvailable <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(AmountAvailable), "Amount of withdraw");
            }

            if (Balance - AmountAvailable <= 0)
            {
                throw new InvalidOperationException("Not sufficient funds");
            }

            Balance = Balance - AmountAvailable;
            LastTransactionAmount = AmountAvailable;
            LastTransactionTime = time;
        }

        public string getDetails()
        {
            return $"The account balance is {Balance} and account holder\'s name is {Name}";
        }

        public string getLastTransaction()
        {
            return $"The last transaction was made on {LastTransactionTime} of of amount {LastTransactionAmount}";
        }
    }
}
