// <copyright file="DriverTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelayInsurancePolicy;

namespace RelayInsurancePolicy.Tests
{
    [TestClass]
    [PexClass(typeof(Driver))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DriverTest
    {

        [PexMethod(Timeout = 240, MaxConstraintSolverTime = 2)]
        [PexAllowedException(typeof(NullReferenceException))]
        public void checkClaimDates([PexAssumeUnderTest]Driver target)
        {
            target.checkClaimDates();
            // TODO: add assertions to method DriverTest.checkClaimDates(Driver)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public void addClaimDates([PexAssumeUnderTest]Driver target, DateTime time)
        {
            target.addClaimDates(time);
            // TODO: add assertions to method DriverTest.addClaimDates(Driver, DateTime)
        }
    }
}
