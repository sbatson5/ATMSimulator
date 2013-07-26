using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATMSimulator
{
    public class Screen
    {
        private TextBox screenTB;

        public Screen(TextBox tb)
        {
            screenTB = tb;
        }
        public void ClearMessage()
        {
            screenTB.Text = "";
        }
        //displays a message without a terminating carriage return
        public void DisplayMessage(string message)
        {
            screenTB.Text = "";
            screenTB.Text += "\r\n"+message;
        }

        //display a message with a terminating carriage return
        public void appendMessage(string message)
        {
            screenTB.Text += "\r\n"+message;
        }

        //display a dollar amount
        public void DisplayDollarAmount(decimal amount)
        {
            screenTB.Text += "\r\n";
            screenTB.Text += amount.ToString();
            
        }
    }
}
