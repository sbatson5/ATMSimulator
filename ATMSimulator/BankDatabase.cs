using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATMSimulator
{
    public class BankDatabase
    {

        private Account[] accounts;

        public BankDatabase()
        {
            //create two Account objects for testing
            
            accounts = new Account[2];
            accounts[0] = new Account(12345, 54321, 1000.00M, 1200.00M);
            accounts[1] = new Account(98765, 56789, 200.00M, 200.00M);
        }

        private Account GetAccount(int accountNumber)
        {
            
            //loop through accounts searching for matching account number
            foreach (Account currentAccount in accounts)
            {
                if (currentAccount.AccountNumber == accountNumber)
                    return currentAccount;
            }
            return null;
        }

        //check the PIN
        public bool AuthenticateUser(int userAccountNumber, int userPIN)
        {
            //attempt to retrieve the account
            Account userAccount = GetAccount(userAccountNumber);

            //if account exists, return result of Account function ValidatePIN
            if (userAccount != null)
                return userAccount.ValidatePIN(userPIN);
            else
                return false;
        }

        public decimal GetAvailableBalance(int userAccountNumber)
        {
            Account userAccount = GetAccount(userAccountNumber);
            return userAccount.AvailableBalance;
        }

        public decimal GetTotalBalance(int userAccountNumber)
        {
            Account userAccount = GetAccount(userAccountNumber);
            return userAccount.TotalBalance;
        }

        public void Credit(int userAccountNumber, decimal amount)
        {
            Account userAccount = GetAccount(userAccountNumber);
            userAccount.Credit(amount);
        }

        public void Debit(int userAccountNumber, decimal amount)
        {
            Account userAccount = GetAccount(userAccountNumber);
            userAccount.Debit(amount);
        }
    }
}
