using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAccount
{
    public class SavingsAccount : BasicAccount
    {
        private decimal minimumBalance;

        public decimal MinimumBalance
        {
            get { return minimumBalance; }
            set
            {
                {
                    if (value > 0.0m) // minimumBalance – positive value
                        minimumBalance = value;
                    else // bad value; assign default zero instead
                        minimumBalance = 0.0m;
                }
            }
        }

        // public constructor
        public SavingsAccount() {
        }
        public SavingsAccount(int accountNumber = 0, string owner = "unknown", decimal balance = 0.0m, float interestRate = 0.0F, decimal minimumBalance = 0.0m) : base(accountNumber, owner, balance, interestRate)
        {
            this.MinimumBalance = minimumBalance;
        }

        public override bool Withdraw(decimal amount = 0.0m)
        {
            // allows the balance to fall below minimumBalance as
            // long as the balance is non - negative
            if (amount > 0.0m && (this.balance - amount) >= 0.0m)
            {
                balance -= amount;
                return true;
            }
            else return false;
        }

        public override void AddMonthlyInterest()
        {
            // adds the monthly interest
            // only if the balance of the account was at least the minimumBalance at any time
            if (this.Balance >= minimumBalance)
                base.AddMonthlyInterest();
        }
    }
}
