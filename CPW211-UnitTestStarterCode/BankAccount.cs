using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class BankAccount
    {
        private string owner;
        private decimal balance;

        public BankAccount(string owner, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(owner))
            {
                throw new ArgumentException("Owner name must not be empty", nameof(owner));
            }

            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance must be non-negative", nameof(initialBalance));
            }

            this.owner = owner;
            this.balance = initialBalance;
        }

        public string Owner => owner;

        public decimal Balance => balance;

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive", nameof(amount));
            }

            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive", nameof(amount));
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            balance -= amount;
        }
    }
}
