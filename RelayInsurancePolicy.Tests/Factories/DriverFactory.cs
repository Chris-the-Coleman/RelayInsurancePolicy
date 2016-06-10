using System.Collections.Generic;
using RelayInsurancePolicy;
// <copyright file="DriverFactory.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;

namespace RelayInsurancePolicy
{
    /// <summary>A factory for RelayInsurancePolicy.Driver instances</summary>
    public static partial class DriverFactory
    {
        /// <summary>A factory for RelayInsurancePolicy.Driver instances</summary>
        [PexFactoryMethod(typeof(Driver))]
        public static Driver Create(
            List<DateTime> claimDates_list,
            string value_s,
            string value_s1,
            int value_i,
            int value_i1
        )
        {
            Driver driver = new Driver();
            driver.claimDates = claimDates_list;
            driver.DriverName = value_s;
            driver.Occupation = value_s1;
            driver.DriverAge = value_i;
            driver.NumberOfClaims = value_i1;
            return driver;

            // TODO: Edit factory method of Driver
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
