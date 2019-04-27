using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAccount
{
    public class CheckingAccount : BasicAccount
    {
        private decimal overdraftLimit;
 
        public decimal OverdraftLimit
        {
            get { return overdraftLimit; }
            set
            {
                {
                    if (value > 0.0m) // positive value
                        overdraftLimit = value;
                    else // bad value; assign default zero instead
                        overdraftLimit = 0.0m;
                }
            }
        }
        // public constructors
        public CheckingAccount() { }
        public CheckingAccount(int accountNumber = 0, string owner = "unknown", decimal balance = 0.0m, float interestRate = 0.0F, decimal overdraftLimit = 0.0m) : base(accountNumber, owner, balance, interestRate)
        {
            this.OverdraftLimit = overdraftLimit;
        }
    

        public override bool Withdraw(decimal amount = 0.0m)
        {
            // allow withdrawals that make the balance negative as long as it does not fall below the negative overdraftLimit
            if (amount > 0.0m && (base.Balance + overdraftLimit) >= amount)
            {
                base.balance -= amount;
                return true;
            }
            else return false;
        }

        public override void AddMonthlyInterest()
        {
            // the monthly interest is added only if the balance never fell below zero
            if (base.Balance > 0.0m)
                base.AddMonthlyInterest();
        }

        
    }

    
}
