using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RelayInsurancePolicy.Tests.FormsTest
{
    [TestClass]
    public class SubmittedTest
    {
        private Submitted submit;

        [TestInitialize]
        public void TestInitialize()
        {
            Policy.addDriver("", "", default(DateTime), 3);
            submit = new Submitted();
            
            Assert.AreNotEqual(submit, null);
        }
        [TestMethod]
        public void YoungestTest()
        {
            DateTime date = new DateTime(30 / 05 / 1995);
            Policy.addDriver("", "", date, 0);
            Boolean result = submit.Youngest();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void OldestTest()
        {
            Policy.PolicyStart = DateTime.Today;
            DateTime date = new DateTime(30 / 05 / 1920);
            Policy.addDriver("", "", date, 0);
            Boolean result = submit.Oldest();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void ClaimsOnPolicyTest()
        {
            Policy.Claims = 4;
            Boolean result = submit.ClaimsOnPolicy();
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void DriverClaimDatesTest()
        {
           
            //Driver added in initialize with 3 claims
            Boolean result = submit.DriversClaimDates();
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void CalculatePremiumTest()
        {
            Policy.addDriver("", "Accountant", new DateTime(30 / 05 / 1990), 0);
            Double result = 405;

            Assert.AreEqual(submit.CalculatePremium(), result);
        }
    }
}
