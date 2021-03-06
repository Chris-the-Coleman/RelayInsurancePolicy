﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RelayInsurancePolicy.Tests.ClassesTest
{
    [TestClass]
    public class DriverTest
    {
        private Driver driver;
        [TestInitialize]

        public void TestInitialize()
        {
            driver = new Driver();
            Assert.AreNotEqual(driver, null);
        }

        [TestMethod]
        public void AddClaimTimeTest()
        {
           
            driver.addClaimDates(default(DateTime));
            Assert.IsNotNull((object)(driver.claimDates));
            Assert.AreEqual<int>(4, driver.claimDates.Capacity);
            Assert.AreEqual<int>(1, driver.claimDates.Count);
        }

        [TestMethod] 
        public void CheckClaimDates()
        {
            Double number = Policy.premium;
            driver.addClaimDates(default(DateTime));
            driver.checkClaimDates();

            Assert.AreNotEqual(number, Policy.premium);
        }
    }
}
