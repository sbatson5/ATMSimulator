using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATMSimulator
{
    public class Keypad
    {
        private TextBox customerInput;

        public Keypad(TextBox tb)
        {
            customerInput = tb;
        }
        //return an integer value entered by user
        public int GetInput()
        {
            return 0;
        }

        //used to get 5-digit codes
        public int getInfo()
        {
            int i;
            if (customerInput.Text.Length == 5)
            {
                i = Convert.ToInt32(customerInput.Text);
                i = int.Parse(customerInput.Text);
                customerInput.Text = "";
                return i;
            }
            else
            {
                customerInput.Text = "";
                return 0;
            }
        }

        //used for menu selections
        public int getSelection()
        {
            int i;

            if (customerInput.Text.Length == 1)
            {
                i = Convert.ToInt32(customerInput.Text);
                i = int.Parse(customerInput.Text);
                customerInput.Text = "";
                return i;
            }
            else
            {
                customerInput.Text = "";
                return 0;
            }
        }

        //used for deposit amount
        public int getAmount()
        {
            int i;
            if (customerInput.Text.Length > 0 && customerInput.Text != "0")
            {
                i = Convert.ToInt32(customerInput.Text);
                i = int.Parse(customerInput.Text);
                customerInput.Text = "";
                return i;
            }
            else if (customerInput.Text == "0")
            {
                customerInput.Text = "";
                return 99999;
            }
            else
            {
                customerInput.Text = "";
                return 0;
            }
        }
    }
}
