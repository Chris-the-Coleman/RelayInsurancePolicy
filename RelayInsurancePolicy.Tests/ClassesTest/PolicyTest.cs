﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RelayInsurancePolicy.Tests.ClassesTest
{
    [TestClass]
    public class PolicyTest
    {
       
        
        [TestMethod]
        public void AddDriverTest()
        {
            
            Policy.addDriver("bob", "Accountant", default(DateTime), 3);
            Assert.AreNotEqual(Policy.drivers[0], null);
            Assert.AreEqual(Policy.drivers[0].DriverName.Contains("bob"), true);
            Assert.AreEqual(Policy.drivers[0].Occupation, "Accountant");
            Assert.AreEqual(Policy.drivers[0].DriverAge, Policy.ageCalculator(default(DateTime)));
            Assert.AreEqual(Policy.drivers[0].NumberOfClaims, 3);
        }

        [TestMethod]

        public void UpdateDriverTest()
        {
            AddDriverTest();

            DateTime value = new DateTime(2015, 1, 18);
            Policy.updateDriver(0, "chris", "Chaffuer", value, 5);
            Assert.AreNotEqual(Policy.drivers[0].DriverName, "bob");
            Assert.AreNotEqual(Policy.drivers[0].Occupation, "Accountant");
            Assert.AreNotEqual(Policy.drivers[0].DriverAge, Policy.ageCalculator(default(DateTime)));
            Assert.AreNotEqual(Policy.drivers[0].NumberOfClaims, 3);
        }

        [TestMethod]

        public void ageCalculatorTest()
        {
            DateTime age = new DateTime(1990, 2, 18);
            DateTime startdate = new DateTime(2015, 2, 18);
            Policy.PolicyStart = startdate;
            int result = Policy.ageCalculator(age);
            Assert.AreEqual(25, result);
        
        }

        [TestMethod]

        public void PercentageCalculatorTest()
        {
           Double result = Policy.percantageCalculated(10);
           Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void CalculatePremiumTest()
        {
            Policy.addDriver("", "Accountant", new DateTime(30 / 05 / 1990), 0);
            Double result = 405;

            Assert.AreEqual(Policy.CalculatePremium(26), result);
        }

       
    }
}
