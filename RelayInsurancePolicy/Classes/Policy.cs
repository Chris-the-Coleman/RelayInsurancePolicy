using System;
using System.Collections.Generic;


namespace RelayInsurancePolicy
{
    static class Policy
    {
        public static List<Driver> drivers = new List<Driver>();
        public static List<int> ages = new List<int>();
        public static List<DateTime> dateOfBirths = new List<DateTime>();
        public static Double premium = 500;
        private static DateTime policyStart { get; set; }
        private static int numberOfUnassignedDrivers { get; set; }
        private static int claims { get; set; }


        public static DateTime PolicyStart
        {
            get { return policyStart; }
            set { policyStart = value; }
            
        }//get and set policy date

        public static int NumberOfDrivers
        {
            get { return numberOfUnassignedDrivers; }
            set { numberOfUnassignedDrivers = value; }
        }//get and set number of drivers on policy

        public static int Claims
        {
            get { return claims; }
            set { claims = value; }
        }// number of claims on the policy

        public static void addDriver(String name, String occupation, DateTime age, int claims)
        {
            Driver driver = new Driver();
            driver.DriverName = name;
            driver.Occupation = occupation;
            driver.DriverAge = ageCalculator(age);
            driver.NumberOfClaims = claims;
            ages.Add(driver.DriverAge);
            dateOfBirths.Add(age);
            drivers.Add(driver);
           
        }//add new driver to list

        public static void updateDriver(int driverNumber,String name, String occupation, DateTime age, int claims)
        {
            drivers[driverNumber].DriverName = name;
            drivers[driverNumber].Occupation = occupation;
            drivers[driverNumber].DriverAge = ageCalculator(age);
            drivers[driverNumber].NumberOfClaims = claims;
            dateOfBirths[driverNumber] = age;
            drivers[driverNumber].claimDates.Clear();
        }//Changes driver details and clears claim list

      

        public static int ageCalculator(DateTime dob)
        {
            int age = policyStart.Year - dob.Year;
            if(policyStart.Month < dob.Month)age--; 
            else if(policyStart.Month == dob.Month)
            {
                if (policyStart.Day < dob.Day) age--;
               
            }
            return age;
        }//Calculates accurate time difference

        public static Double percantageCalculated(int percentage)
        {
            Double Premium = (premium / 100) * percentage;
            return Premium;
        }//calculate percentages
    }
}
