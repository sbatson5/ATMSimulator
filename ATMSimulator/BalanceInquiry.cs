using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSimulator
{
    public class BalanceInquiry : Transaction
    {
        //five-parameter constructor
        public BalanceInquiry(int userAccountNumber, Screen atmScreen, BankDatabase atmBankDatabase) : base(userAccountNumber, atmScreen, atmBankDatabase) { }

        public override void Execute()
        {
            //get available balance for the current user's Account
            decimal availableBalance = Database.GetAvailableBalance(AccountNumber);

            decimal totalBalance = Database.GetTotalBalance(AccountNumber);

            UserScreen.DisplayMessage("Balance Information:");
            UserScreen.appendMessage(" - Available balance: "+availableBalance);
            UserScreen.appendMessage(" - Total balance: " + totalBalance);
            UserScreen.appendMessage("");
        }
        //this is never used for BalanceInquiry
        public override bool checkStatus()
        {
            return true;
        }
    }
}
