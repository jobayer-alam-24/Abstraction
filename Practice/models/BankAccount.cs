using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public abstract class BankAccount
    {
        public string AccountNumber {get; private set;}
        public string AccountHolder {get; private set;}
        protected double Balance {get; set;}
        public BankAccount(string AccountNumber, string AccountHolder)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
        }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public virtual void DisplayBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}