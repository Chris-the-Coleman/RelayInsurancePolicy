// <copyright file="PolicyTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelayInsurancePolicy;

namespace RelayInsurancePolicy.Tests
{
    [TestClass]
    [PexClass(typeof(Policy))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PolicyTest
    {

        [PexMethod]
        [PexAllowedException(typeof(ArgumentOutOfRangeException))]
        internal void updateDriver(
            int driverNumber,
            string name,
            string occupation,
            DateTime age,
            int claims
        )
        {
            Policy.updateDriver(driverNumber, name, occupation, age, claims);
            // TODO: add assertions to method PolicyTest.updateDriver(Int32, String, String, DateTime, Int32)
        }

        [PexMethod]
        internal void addDriver(
            string name,
            string occupation,
            DateTime age,
            int claims
        )
        {
            Policy.addDriver(name, occupation, age, claims);
            // TODO: add assertions to method PolicyTest.addDriver(String, String, DateTime, Int32)
        }

        [PexMethod]
        internal int ageCalculator(DateTime dob)
        {
            int result = Policy.ageCalculator(dob);
            return result;
            // TODO: add assertions to method PolicyTest.ageCalculator(DateTime)
        }

        [PexMethod]
        internal double percantageCalculated(int percentage)
        {
            double result = Policy.percantageCalculated(percentage);
            return result;
            // TODO: add assertions to method PolicyTest.percantageCalculated(Int32)
        }
    }
}
