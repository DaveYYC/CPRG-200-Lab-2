using Microsoft.VisualStudio.TestTools.UnitTesting;
using David_Hahner_CPRG_200_Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Hahner_CPRG_200_Lab2.Tests
{
    // six methods for testing six different scenarios of charges, two for each customer type
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void ResCustZeroUsageTest() // residential flat rate only
        {
            // arrange
            ResidentialCustomer cust = new ResidentialCustomer("R", 123, "Dave", 1000);
            cust.kWhConsumed = 0;
            double expectedBill = 6;
            double actualAmount;
            // act 
            actualAmount = cust.CalculateCharge();
            // assert
            Assert.AreEqual(expectedBill, actualAmount);
        }

        [TestMethod()]
        public void ResCustUsageTest()  // residential flat rate plus kWh charge
        {
            // arrange
            ResidentialCustomer cust = new ResidentialCustomer("R", 321, "DaveH", 1010);
            cust.kWhConsumed = 1000;
            double expectedBill = 58;
            double actualAmount;
            // act 
            actualAmount = cust.CalculateCharge();
            // assert
            Assert.AreEqual(expectedBill, actualAmount);
        }

        [TestMethod()]
        public void ComCustZeroUsageTest() // commercial flat rate only
        {
            // arrange
            CommercialCustomer cust = new CommercialCustomer("C", 456, "David", 2000);
            cust.kWhConsumed = 0;
            double expectedBill = 60;
            double actualAmount;
            // act 
            actualAmount = cust.CalculateCharge();
            // assert
            Assert.AreEqual(expectedBill, actualAmount);
        }

        [TestMethod()]
        public void ComCustUsageTest() // commercial flat rate plus kWh charge
        {
            // arrange
            CommercialCustomer cust = new CommercialCustomer("C", 654, "DavidH", 2020);
            cust.kWhConsumed = 1500;
            double expectedBill = 82.5; 
            double actualAmount;
            // act 
            actualAmount = cust.CalculateCharge();
            // assert
            Assert.AreEqual(expectedBill, actualAmount);
        }

        [TestMethod()]
        public void IndCustPeakTest() // industrial peak flat rate plus kWh charge
        {
            // arrange
            IndustrialCustomer cust = new IndustrialCustomer("I", 789, "DH", 3000);
            cust.kWhConsumed = 1500;
            cust.OffPk_kWh = 0;
            double expectedBill = 108.5;
            double actualAmount;
            // act 
            actualAmount = cust.CalculateCharge();
            // assert
            Assert.AreEqual(expectedBill, actualAmount);
        }

        [TestMethod()]
        public void IndCustOffPeakTest() // industrial off peak flat rate plus kWh charge
        {
            // arrange
            IndustrialCustomer cust = new IndustrialCustomer("I", 987, "D_H", 3030);
            cust.kWhConsumed = 0;
            cust.OffPk_kWh = 1500;
            double expectedBill = 54;
            double actualAmount;
            // act 
            actualAmount = cust.CalculateCharge();
            // assert
            Assert.AreEqual(expectedBill, actualAmount);
        }
    }
}