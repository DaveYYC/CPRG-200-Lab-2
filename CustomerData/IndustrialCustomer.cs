using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Hahner_CPRG_200_Lab2
{
    public class IndustrialCustomer : Customer
    {
        // local declarations
        const double IND_FLATRATE = 76.00;        // industrial peak hour base rate
        const double IND_KWHRATE = 0.065;         // industrial peak hour rate per kWh
        const double IND_OFF_PK_FLATRATE = 40.00; // industrial off-peak hour base rate
        const double IND_OFF_PK_KWHRATE = 0.028;  // industrial off-peak hour rate per kWh
        const double FLATRTCAP = 1000;            // variable used to identify first 1000 kWh consumed
        double peakCost;        // cost incurred from peak hour kWh consumed
        double offPkCost;       // cost incurred from off peak hour kWh consumed
        double combinedCost;    // cost of peak and off peak consumption above the cap
        double combinedLessCap; // cost of peak and off peak consumption below the cap
        double totalCost;       // total cost of all scenarios combined
        double energyBill;      // output of the total cost

        // off-peak hours consumption
        public double OffPk_kWh { get; set; }

        // constructor
        public IndustrialCustomer(string type = "I", int acct = 0, string name = "unknown", double used = 0) 
            : base(type, acct, name, used)
        {
        }
        
        //calculate the charge amount for industrial customer
        private double CalculateChargeInd()
        {
            if (kWhConsumed <= FLATRTCAP && OffPk_kWh <= FLATRTCAP)
                peakCost = IND_FLATRATE + IND_OFF_PK_FLATRATE;
            else if (kWhConsumed > FLATRTCAP && OffPk_kWh == 0)
                peakCost = IND_FLATRATE + (kWhConsumed - FLATRTCAP) * IND_KWHRATE;
            else if (OffPk_kWh <= FLATRTCAP && kWhConsumed == 0)
                offPkCost = IND_OFF_PK_FLATRATE;
            else if  (OffPk_kWh > FLATRTCAP && kWhConsumed == 0)
                offPkCost = IND_OFF_PK_FLATRATE + (OffPk_kWh - FLATRTCAP) * IND_OFF_PK_KWHRATE;
            else if (OffPk_kWh <= FLATRTCAP && kWhConsumed <= FLATRTCAP)
                combinedLessCap = IND_OFF_PK_FLATRATE + IND_FLATRATE;
            else
                combinedCost = IND_OFF_PK_FLATRATE + (OffPk_kWh - FLATRTCAP) * IND_OFF_PK_KWHRATE +
                    IND_FLATRATE + (kWhConsumed - FLATRTCAP) * IND_KWHRATE;

            // add all scenario charges together as the energy bill
            totalCost = peakCost + offPkCost + combinedCost + combinedLessCap;
            energyBill = totalCost;

            // output the calculated total
            return energyBill;
        }

        // override inherited method
        public override double CalculateCharge()
        {
            return base.CalculateCharge() + CalculateChargeInd();
        }
    }
}
