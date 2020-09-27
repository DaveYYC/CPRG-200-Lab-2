using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Hahner_CPRG_200_Lab2
{
    public class ResidentialCustomer : Customer
    {
        // local declarations
        const double RES_FLATRATE = 6.00; // residential base rate
        const double RES_KWHRATE = 0.052; // residential rate per kWh 

        // constructor
        public ResidentialCustomer(string type = "R", int acct = 0, string name = "unknown", double used = 0) 
            : base(type, acct, name, used)
        {
        } 

        // calculate the charge amount for residential
        private double CalculateChargeRes()
        {
            return RES_FLATRATE + RES_KWHRATE * kWhConsumed; // flat rate plus kWh used
        }

        // override inherited methods
        public override double CalculateCharge()
        {
            return base.CalculateCharge() + CalculateChargeRes();
        }
    }
}
