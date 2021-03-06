﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RelayInsurancePolicy.Tests.FormsTest
{
    [TestClass]
    public class StartPolicyFormTest
    {
        private StartPolicyForm startPolicyForm;

        [TestInitialize]
        public void TestInitialize()
        {
            startPolicyForm = new StartPolicyForm();
            Assert.AreNotEqual(startPolicyForm, null);
           
        }
        [TestMethod]
        public void startDateCheckTest()
        {
            Boolean result = startPolicyForm.startDateCheck();
            Assert.AreEqual(result,true );
        }

        [TestMethod]
        public void UpdateNumberOfDriversTest()
        {
            Boolean result = startPolicyForm.CheckNumberofDrivers();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void DriverDeleteTest()
        {
            Policy.addDriver("", "", default(DateTime), 0);
            Policy.addDriver("", "", default(DateTime), 0);
            int test = Policy.drivers.Count;
            startPolicyForm.driversDelete();
            int result = Policy.drivers.Count;
            Assert.AreNotEqual(test, result);

        }
    }
}
