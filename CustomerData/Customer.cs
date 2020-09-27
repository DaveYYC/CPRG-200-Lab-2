using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Hahner_CPRG_200_Lab2
{
    public class Customer
    {
        // private data and public properties
        public int AccountNo { get; set; }       // account number
        public string CustomerName { get; set; } // customer's name
        public string CustomerType { get; set; } // type of customer residential(res), commercial(com), or industrial(ind)
        public double kWhConsumed { get; set; }  // how many kWhs are entered
        private double chargeAmount;             // private data of the amount the customer is charged
        public double ChargeAmount               // public data of the amount the customer is charged
        {
            get { return chargeAmount; }
            set { chargeAmount = (value < 0) ? 0 : value; } // validate the chargeAmount to be a positive number
        }

        // constructor
        public Customer(string type = "Unknown", int acct = 0, string name = "Unknown", double usage = 0)
        {
            CustomerType = type; 
            AccountNo = acct;   
            CustomerName = name; 
            kWhConsumed = usage; 
        }
        
        // calculate the charge amount
        public virtual double CalculateCharge()
        {
            return 0;
        }

        // override the method of ToString that returns a display string
        public override string ToString()
        {
            return CustomerType + ", " + AccountNo.ToString() + ", " + CustomerName + " -- " + ChargeAmount.ToString("c");
        }

        // display string that writes a line in the .txt file and is comma seperated
        public string ToFileLine()
        {
            return CustomerType + "," + AccountNo.ToString() + "," + CustomerName + "," + ChargeAmount.ToString();
        }
    }
}