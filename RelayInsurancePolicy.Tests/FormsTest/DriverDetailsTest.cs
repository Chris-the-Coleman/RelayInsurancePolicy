﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;


namespace RelayInsurancePolicy.Tests.FormsTest
{
    [TestClass]
    public class DriverDetailsTest
    {
        private DriverDetails driver;
       
        [TestInitialize]
        public void TestInitialize()
        {
            
            driver = new DriverDetails(0, true);
            Assert.AreNotEqual(driver, null);


        }
        [TestMethod]
        public void claimTrueTest()
        {
            Label label = new Label();
            DateTimePicker picker = new DateTimePicker();
            label.Visible = false;
            picker.Visible = false;
            driver.claim(true, label, picker);
            Assert.AreEqual(label.Visible, true);
            Assert.AreEqual(picker.Visible, true);
        }

        [TestMethod]
        public void claimFalseTest()
        {
            Label label = new Label();
            DateTimePicker picker = new DateTimePicker();
            label.Visible = true;
            picker.Visible = true;
            driver.claim(false, label, picker);
            Assert.AreEqual(label.Visible, false);
            Assert.AreEqual(picker.Visible, false);
        }
    }
}
