using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAccount
{
    public class BasicAccount
    {
        private int accountNumber;
        private string owner;
        protected decimal balance;
        private float interestRate; // annual interest rate

        // public properties
        public int AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value >= 100) // Account number should be greater than or equal to 100
                    accountNumber = value;
                else // bad value; assign default zero instead
                    accountNumber = 0;
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // if empty string
                    owner = "unknown"; // assign default value
                else // otherwise, good!
                    owner = value;
            }
        }
        public decimal Balance
        {
            get { return balance; }
            set
            {
                balance = value;
            }
        }

        public float InterestRate
        {
            get { return interestRate; }
            set
            {
                {
                    if (value > 0.0F && value < 1.0F) // Interest rate should be greater than zero and less than one
                        interestRate = value;
                    else // bad value; assign default zero instead
                        interestRate = 0;
                }
            }
        }

        // public constructor
        public BasicAccount(int accountNumber = 100, string owner = "unknown", decimal balance = 0.0m, float interestRate = 0.0F)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
            InterestRate = interestRate;
        }

        public virtual bool Deposit(decimal amount = 0.0m)
        {
            // checks the amount given as parameter to be positive
            if (amount > 0.0m)
            {
                balance += amount;
                return true; // if successful operation, return true;
            }
            else return false;
        }
         
        public virtual bool Withdraw(decimal amount = 0.0m)
        {
            // checks the amount given as parameter to be positive
            // and not more than balance
            // and subtracts amount from the balance if valid
            if (amount > 0.0m && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else return false;
        }
        public virtual void AddMonthlyInterest() {
            // adds to the balance the amount of monthly interest that is
            // calculated based on the current balance and monthly interest rate.
            balance += (balance * (Decimal)(interestRate / 12.0));
        }
        public virtual string GetDisplayText(String alignment) {
            // print the account info
            return String.Format(alignment, AccountNumber, Owner, Balance.ToString("c"), interestRate.ToString("P"), this.GetType().Name.Remove(this.GetType().Name.Length - 7));
        }
    }
}
