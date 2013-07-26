using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMSimulator
{
    public class CashDispenser
    {
        //the default initial number of bills in the cash dispenser
        private const int INITIAL_COUNT = 500;
        private int billCount;

        //parameterless constructor initializes billCount to INITIAL_COUNT
        public CashDispenser()
        {
            billCount = INITIAL_COUNT;
        }

        //simulate dispensing cash
        public void DispenseCash(decimal amount)
        {
            //number of twenty dollar bills required
            int billsRequired = ((int)amount) / 20;
            billCount -= billsRequired;
        }

        //indicates whether cash dispenser can dispense desired amount
        public bool IsSufficientCashAvailable(decimal amount)
        {
            //number of twenty dollar bills required
            int billsRequired = ((int)amount) / 20;

            //return whether there are enough bills available
            return (billCount >= billsRequired);
        }
    }
}
