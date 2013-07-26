using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSimulator
{
    public class Deposit : Transaction
    {
        private Keypad keypad;
        private DepositSlot depositSlot;
        private bool processingDeposit;
        private Screen screen;
        private BankDatabase bankDatabase;
        private int accountNumber;

        private const int CANCELED = 0;

        //five-parameter constructor
        public Deposit(int userAccountNumber, Screen atmScreen, BankDatabase atmBankDatabase, Keypad atmKeypad, DepositSlot atmDepositSlot, bool depositStatus)
            : base(userAccountNumber, atmScreen, atmBankDatabase)
        {
            keypad = atmKeypad;
            depositSlot = atmDepositSlot;
            bankDatabase = atmBankDatabase;
            accountNumber = userAccountNumber;
            processingDeposit = depositStatus;
            screen = atmScreen;
        }

        //perform transaction; overrides Transaction's Execute
        public override void Execute()
        {
            processingDeposit = true;
            screen.DisplayMessage("Please input a deposit amount in CENTS (or 0 to cancel):");

            decimal amount = keypad.getAmount();
            screen.appendMessage("" + amount);
            if (amount != 99999 && amount != 0)
            {
                //convert to cents
                amount = amount / 100.00M;
                screen.DisplayMessage("Please insert an envelope containing " + amount + " into the deposit slot.");
                bankDatabase.Credit(accountNumber, amount);
                //depositSlotLabel.ForeColor = Color.BlueViolet;
                processingDeposit = false;
            }
            else if (amount == 99999)
            {
                screen.DisplayMessage("Deposit Cancelled");
                processingDeposit = false;
            }
        }//end Execute

        //Tells the program whether the deposit is complete or not
        public override bool checkStatus()
        {
            return processingDeposit;
        }
    }
}
