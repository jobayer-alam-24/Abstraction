using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.models
{
    public class CurrentAccount : BankAccount
    {
        private double _overdraftLimit = 1000.0;
        public CurrentAccount(string accountNumebr, string accountHolder) : base(accountNumebr, accountHolder){}
        public override void Deposit(decimal amount)
        {
            Balance += (double)amount;
            Console.WriteLine($"Deposited {amount} to {AccountNumber}");
        }
        public override void Withdraw(decimal amount)
        {
            if((Balance - (double)amount) >= -_overdraftLimit)
            {
                Balance -= (double)amount;
                Console.WriteLine($"Withdrew {amount} from {AccountNumber}");
            }
            else
            {
                Console.WriteLine("Withdrawal failed due to insufficient funds");
            }
        }
    }
}