using System;
using System.Collections.Generic;


namespace RelayInsurancePolicy
{
    public class Driver
    {
        private String driverName { get; set; }
        private String occuptation { get; set; }
        private int driverAge { get; set; }
        private int numberOfClaims { get; set; }
        public List <DateTime> claimDates;

        public Driver() { claimDates = new List<DateTime>(); } 

        public String DriverName {
            get { return driverName; }
            set { this.driverName = value;
                  }
        }//set/get driver name

        public String Occupation
        {
            get
            {
                return occuptation;
            }
            set
            {
                occuptation = value;
            }
        }//get/set driver occuptation - premium change based on occupation

        public int DriverAge
        {
            get { return driverAge; }
            set { driverAge = value; }
        }//get/set drivers age  - increase premium based on age of youngest driver

        public int NumberOfClaims
        {
            get { return numberOfClaims; }
            set {
                numberOfClaims = value;
               
                  }
        }//get/set number of claims driver has

        public void addClaimDates(DateTime time)
        {
            claimDates.Add(time);
        }//add Claim dates

        public void checkClaimDates()
        {
            int dateDifference = 0;
           if(claimDates.Count > 0)
            {
                foreach (DateTime time in claimDates)
                {

                    dateDifference = Policy.ageCalculator(time);
                    if (dateDifference <= 1)
                    {
                        Policy.premium += Policy.percantageCalculated(20);

                    }

                    else if (dateDifference >= 2 && dateDifference <= 5)
                    {
                        Policy.premium += Policy.percantageCalculated(10);
                    }
                }

            }
           
        }//calculate premium increase from claims

        
    }

}
