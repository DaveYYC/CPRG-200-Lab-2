using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Hahner_CPRG_200_Lab2
{
    public class CommercialCustomer : Customer
    {
        // local declarations
        const double COM_FLATRATE = 60;   // commercial base rate
        const double COM_KWHRATE = 0.045; // commercial rate per kWh
        const double FLATRTCAP = 1000;    // variable used to identify first 1000 kWh consumed

        // constructor
        public CommercialCustomer(string type = "C", int acct = 0, string name= "unknown", double used = 0) 
            : base(type, acct, name, used) 
        {
        }
        
        // calculate the charge amount for commercial
        private double CalculateChargeCom()
        {
            if (kWhConsumed <= FLATRTCAP) return COM_FLATRATE; // flat rate charge
            else return COM_FLATRATE + COM_KWHRATE * (kWhConsumed - FLATRTCAP); // flat rate plus kWh usage
        }

        // override inherited methods
        public override double CalculateCharge()
        {
            return base.CalculateCharge() + CalculateChargeCom();
        }
    }
}
