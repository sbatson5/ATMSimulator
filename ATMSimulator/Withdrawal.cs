using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSimulator
{
    public class Withdrawal : Transaction
    {

        //references to associated objects
        private Keypad keypad;
        private CashDispenser cashDispenser;
        private BankDatabase bankDatabase;
        private bool processingWithdrawal;
        private int accountNumber;
        private Screen screen;

        //constant that represents a menu option for cancelling
        private const int CANCELED = 6;

        public Withdrawal(int userAccountNumber, Screen atmScreen, BankDatabase atmBankDatabase, Keypad atmKeypad, CashDispenser atmCashDispenser, bool withdrawStatus)
            : base(userAccountNumber, atmScreen, atmBankDatabase)
        {
            keypad = atmKeypad;
            cashDispenser = atmCashDispenser;
            screen = atmScreen;
            accountNumber = userAccountNumber;
            bankDatabase = atmBankDatabase;
            processingWithdrawal = withdrawStatus;
        }

        //perform transaction
        public override void Execute()
        {
            processingWithdrawal = true;
            //get the balances
            decimal availableBalance = bankDatabase.GetAvailableBalance(accountNumber);
            decimal totalBalance = bankDatabase.GetTotalBalance(accountNumber);

            //array of amounts to correspond to menu numbers
            int[] amounts = { 0, 20, 40, 60, 100, 200 };

            screen.DisplayMessage("\r\nWithdrawal options:");
            screen.appendMessage("1 - $20");
            screen.appendMessage("2 - $40");
            screen.appendMessage("3 - $60");
            screen.appendMessage("4 - $100");
            screen.appendMessage("5 - $200");
            screen.appendMessage("6 - Cancel transaction");
            screen.appendMessage("\r\nChoose a withdrawal option (1-6): ");

            int selection = keypad.getSelection();

            //Make sure the user input an option - Can't withdraw nothing
            if (selection != 0)
            {
                //pull the correct amount from the array
                int withdrawalAmount = amounts[selection];

                if (withdrawalAmount > availableBalance)
                {
                    //not enough money
                    screen.DisplayMessage("Insufficient funds.\r\nNow Exiting...");
                    processingWithdrawal = false;
                }
                else
                {
                    //subtract the amount
                    if (cashDispenser.IsSufficientCashAvailable(withdrawalAmount))
                    {
                        //debit the account to reflect the withdrawal
                        bankDatabase.Debit(accountNumber, withdrawalAmount);

                        cashDispenser.DispenseCash(withdrawalAmount);

                        screen.DisplayMessage("\r\nPlease take your cash from the cash dispenser.");
                        //cashDispenserLabel.ForeColor = Color.BlueViolet;
                        processingWithdrawal = false;
                    }
                    else
                    {
                        screen.DisplayMessage("\r\nInsufficient cash available in the ATM \n\nPlease choose a smaller amount.");
                    }
                }
            }
        }

        //Tells the program whether the withdrawal is complete or not
        public override bool checkStatus()
        {
            return processingWithdrawal;
        }
    }
}
