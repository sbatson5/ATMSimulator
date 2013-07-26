using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSimulator
{
    public class Account
    {
        private int accountNumber;
        private int pin;
        private decimal availableBalance;
        private decimal totalBalance;

        //four-parameter constructor
        public Account(int theAccountNumber, int thePIN, decimal theAvailableBalance, decimal theTotalBalance)
        {
            accountNumber = theAccountNumber;
            pin = thePIN;
            availableBalance = theAvailableBalance;
            totalBalance = theTotalBalance;
        }

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        public decimal AvailableBalance
        {
            get
            {
                return availableBalance;
            }
        }

        public decimal TotalBalance
        {
            get
            {
                return totalBalance;
            }
        }

        //determine whether specified PIN matches PIN in account
        public bool ValidatePIN(int userPIN)
        {
            return (userPIN == pin);
        }

        //credit the account
        public void Credit(decimal amount)
        {
            totalBalance += amount;
        }

        public void Debit(decimal amount)
        {
            availableBalance -= amount;
            totalBalance -= amount;
        }
    }
}
