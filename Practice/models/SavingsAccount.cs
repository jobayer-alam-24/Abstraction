using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class SavingsAccount : BankAccount
    {
        private double _interestRate = 0.03;
        public SavingsAccount(string AccountHolder, string AccountNumber) :
        base(AccountHolder, AccountNumber){}
        public override void Deposit(decimal amount)
        {
            Balance += (double)amount;
            Console.WriteLine($"Depsited: {amount} into Savings Account");
        }
        public override void Withdraw(decimal amount)
        {
            if(Balance - (double)amount <= 0)
            {
                Balance -= (double)amount;
                Console.WriteLine($"Witdrew: {amount} from Savings Account");
            }
            else
            {
                Console.WriteLine($"Insufficient funds to withdraw {amount}");
            }
        }
        public void AddInterest()
        {
            Balance += Balance * _interestRate;
            Console.WriteLine($"Added interest to Savings Account");
        }
    }
}