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
    public partial class Form1 : Form
    {
        private bool userAuthenticated;
        private bool accountRegistered;
        private bool pinRegistered;
        private bool processingWithdrawal;
        private bool processingDeposit;
        private int accountNumber;
        private int currentAccountNumber;
        private int pin;
        private Screen screen;
        private Keypad keypad;
        private CashDispenser cashDispenser;
        private DepositSlot depositSlot;
        private BankDatabase bankDatabase;
        

        public Form1()
        {
            InitializeComponent();
            bankDatabase = new BankDatabase();
            cashDispenser = new CashDispenser();
            depositSlot = new DepositSlot();
            screen = new Screen(displayScreen);
            keypad = new Keypad(customerInput);
            depositSlotLabel.ForeColor = Color.Gray;
            cashDispenserLabel.ForeColor = Color.Gray;
        }

        private enum MenuOption
        {
            BALANCE_INQUIRY = 1,
            WITHDRAWAL = 2,
            DEPOSIT = 3,
            EXIT_ATM = 4
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            depositSlotLabel.ForeColor = Color.Gray;
            if (processingWithdrawal)
                Withdrawal();
            else if (processingDeposit)
                MakeDeposit();
            else
                Run();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userAccounts.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.userAccounts.Accounts);
            this.accountsTableAdapter.GetData();
            screen.DisplayMessage("Welcome!\r\n\r\nPlease enter your account number:");
        }

        private void Run()
        {
            //If they haven't entered an account number, check for it
            if (!accountRegistered)
            {
                screen.DisplayMessage("Please enter your PIN:");
                checkAccountNumber();
            }
            else if (!pinRegistered)
            {
                checkPin();
            }

            //if they have entered an account number and pin check that they are valid
            if (pinRegistered && accountRegistered)
            {
                userAuthenticated = bankDatabase.AuthenticateUser(accountNumber, pin);

                //if they are valid, perform a transaction
                if (userAuthenticated)
                {
                    screen.DisplayMessage("Authenticated");
                    currentAccountNumber = accountNumber;
                    PerformTransactions();
                }
                else  //otherwise, kick them out
                {
                    screen.DisplayMessage("Invalid account number or PIN. Please try again.");
                    screen.appendMessage("\r\nPlease enter account number again:");
                    ResetAll();
                }
            }
        }

        private void PerformTransactions()
        {
            int mainMenuSelection;

            //show main menu and get user selection
            DisplayMainMenu();
            mainMenuSelection = keypad.getSelection();


            //decide how to proceed based on user's menu selection
            if (mainMenuSelection != 0)
            {
                Transaction transaction;
                switch ((MenuOption)mainMenuSelection)
                {
                    //user chooses to perform one of three transaction types
                    case MenuOption.BALANCE_INQUIRY:
                        transaction = new BalanceInquiry(accountNumber, screen, bankDatabase);
                        transaction.Execute();
                        break;
                    case MenuOption.WITHDRAWAL:
                        Withdrawal();
                        break;
                    case MenuOption.DEPOSIT:
                        MakeDeposit();
                        break;
                    case MenuOption.EXIT_ATM:
                        ExitATM();
                        break;
                    default:
                        screen.DisplayMessage("You did not enter a valid selection. Try again.");
                        break;
                }
            }
        }

        private void DisplayMainMenu()
        {
            screen.appendMessage("\nMain Menu:");
            screen.appendMessage("1 - View my balance");
            screen.appendMessage("2 - Withdraw cash");
            screen.appendMessage("3 - Deposit funds");
            screen.appendMessage("4 - Exit\n");
            screen.appendMessage("Enter a choice: ");
        }

        //Grab the customer input for the account
        private void checkAccountNumber()
        {
            accountNumber = keypad.getInfo();
            accountRegistered = true;
        }

        //Grab the customer input for the pin
        private void checkPin()
        {
            pin = keypad.getInfo();
            pinRegistered = true;
        }

        //Set the transaction to the Withdrawal class and Execute
        //Must be a separate class so that the Click event can access it directly
        private void Withdrawal()
        {
            Transaction transaction;
            processingWithdrawal = true;
            transaction = new Withdrawal(accountNumber, screen, bankDatabase, keypad, cashDispenser, processingWithdrawal);
            transaction.Execute();
            processingWithdrawal = transaction.checkStatus();
        }

        //Set the transaction to the Deposit class and Execute
        //Must be a separate class so that the Click event can access it directly
        private void MakeDeposit()
        {
            Transaction transaction;
            transaction = new Deposit(accountNumber, screen, bankDatabase, keypad, depositSlot, processingDeposit);
            transaction.Execute();
            processingDeposit = transaction.checkStatus();
        }

        //log account out
        private void ExitATM()
        {
            screen.DisplayMessage("You are now logged out.");
            screen.appendMessage("\r\n\r\nPlease enter your account number:");
            ResetAll();
        }

        //start over
        private void ResetAll()
        {
            userAuthenticated = false;
            accountRegistered = false;
            pinRegistered = false;
            accountNumber = 0;
            pin = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerInput.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerInput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerInput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerInput.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customerInput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customerInput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customerInput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customerInput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customerInput.Text += "9";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            customerInput.Text = "";
        }

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userAccounts);

        }
    }
}
