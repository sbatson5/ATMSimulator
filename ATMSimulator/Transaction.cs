using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSimulator
{
    public abstract class Transaction
    {
        private int accountNumber;
        private Screen userScreen;
        private BankDatabase database;

        public Transaction(int userAccount, Screen theScreen, BankDatabase theDatabase)
        {
            accountNumber = userAccount;
            userScreen = theScreen;
            database = theDatabase;
        }

        //read-only properties
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        public Screen UserScreen
        {
            get
            {
                return userScreen;
            }
        }

        public BankDatabase Database
        {
            get
            {
                return database;
            }
        }

        //perform the transaction (overridden)
        public abstract void Execute();
        public abstract bool checkStatus();
    }
}
