using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace David_Hahner_CPRG_200_Lab2
{
    public static class Validator
    {
        // tests if text box is not empty (required fields)
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; // "innocent until proven guilty"
            if(tb.Text == "")   // empty textbox
            {
                result = false;
                MessageBox.Show("Please enter the " + name);
                tb.Focus();
            }
            return result;
        }

        // test if input is a non-negative integer
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool result = true;
            int num; // parsed number
            if(!Int32.TryParse(tb.Text, out num)) // test if input is not integer
            {
                result = false;
                MessageBox.Show(name + ": Please enter a whole number", "Please re-enter");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // a decimal value; check if non-negative
            {
                if(num < 0)
                {
                    result = false;
                    MessageBox.Show(name + ": Please enter a positive number or zero", "Please re-enter");
                    tb.SelectAll(); // select all text and focus
                    tb.Focus();
                }
            }
            return result;
        }

        // test if input is a non-negative decimal
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool result = true;
            double num; // parsed number
            if (!Double.TryParse(tb.Text, out num)) // test if input is not integer
            {
                result = false;
                MessageBox.Show(name + ": Please enter a floating point number", "Please re-enter");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // a double value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + ": Please enter a positive number or zero", "Please re-enter");
                    tb.SelectAll(); // select all text and focus
                    tb.Focus();
                }
            }
            return result;
        }
        //test if the input is unique in the customerlist
        public static bool IsUnique(TextBox inputBox, List<Customer> list, string name)
        {
            foreach (Customer c in list)
            {
                if (c.AccountNo == Convert.ToInt32(inputBox.Text)) // if has already existed
                {
                    MessageBox.Show("The " + name + " has already been used, please re-enter.");
                    inputBox.SelectAll();
                    inputBox.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}

    
