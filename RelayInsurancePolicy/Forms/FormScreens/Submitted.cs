using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelayInsurancePolicy
{
    public partial class Submitted : BaseForm
    {
        Boolean youngest = false;
        Boolean oldest = false;
        Boolean driversClaimDates = false;
        Boolean claimsOnPolicy = false;
        public Submitted()
        {
            InitializeComponent();
            startLabel.ForeColor = Color.LimeGreen;
            startLabel.Text = "\u2714";
            driverLabel.ForeColor = Color.LimeGreen;
            driverLabel.Text = "\u2714";
            overviewLabel.ForeColor = Color.LimeGreen;
            overviewLabel.Text = "\u2714";
            claimLabel.ForeColor = Color.LimeGreen;
            claimLabel.Text = "\u2714";


            policyBox.AppendText("Your policy has been ");
            
            if(AcceptorDecline())
            {
                policyBox.AppendText("Approved");
                policyBox.AppendText("\n");
                policyBox.AppendText("Your policy for ");
                policyBox.AppendText(Convert.ToString(Policy.drivers.Count));
                policyBox.AppendText(" drivers shall cost:");
                policyBox.AppendText("\n");
                policyBox.AppendText("£");
                MessageBox.Show(Convert.ToString(Policy.ages.Min()));
                Double premium = CalculatePremium();
                
                policyBox.AppendText(Convert.ToString(premium)); 
            }
            else
            {
                policyBox.AppendText("Declined");
                policyBox.AppendText("\n");
                policyBox.AppendText("For the following reasons:");
                policyBox.AppendText("\n");
                declined();
            }
        }

       

        private Boolean AcceptorDecline()
        {
            youngest = Youngest();
            oldest = Oldest();
            claimsOnPolicy = ClaimsOnPolicy();
            driversClaimDates = DriversClaimDates();

            if (youngest || oldest || claimsOnPolicy || driversClaimDates) return false;
            else return true;
        }

        public Boolean Youngest()
        {
            if (Policy.ages.Min() < 21) return true;
                
            else return false;
        }

        public Boolean Oldest()
        { if (Policy.ages.Max() > 75) return true;
            else return false;
        }

        public Boolean ClaimsOnPolicy()
        {
            if (Policy.Claims > 3) return true;
            else return false;
        }

        public Boolean DriversClaimDates()
        {
            Boolean result;
            foreach (Driver driver in Policy.drivers)
            {
                if (driver.NumberOfClaims > 2) result = true;
                else result = false;
                return result;
            }
            return false;
        }

        private void declined()
        {
            if (youngest)
            {
                policyBox.AppendText("Age of youngest: " + Policy.drivers[Policy.ages.IndexOf(Policy.ages.Min())].DriverName);
                policyBox.AppendText("\n");
            }
            if(oldest)
            {
                policyBox.AppendText("Age of oldest: " + Policy.drivers[Policy.ages.IndexOf(Policy.ages.Max())].DriverName);
                policyBox.AppendText("\n");
            }
            if(claimsOnPolicy)
            {
                policyBox.AppendText("Policy has more than 3 claims");
                policyBox.AppendText("\n");
            }
            if(driversClaimDates)
            {
                foreach(Driver drive in Policy.drivers)
                {
                    if(drive.NumberOfClaims > 2)
                    {
                        policyBox.AppendText("Driver has more than 2 claims: ");
                        policyBox.AppendText(drive.DriverName);
                        policyBox.AppendText("\n");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Would you like to start a new policy?", "Restart",
    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Restart = true;
                Application.Restart();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        public static Double CalculatePremium()
        {
            foreach (Driver driver in Policy.drivers)
            {
                if (driver.Occupation == "Accountant")
                {
                    Policy.premium -= Policy.percantageCalculated(10);

                }
                else
                {
                    Policy.premium += Policy.percantageCalculated(10);

                }
                Policy.Claims += driver.NumberOfClaims;

                if (Policy.ages.Min() > 21 && Policy.ages.Min() < 26)
                {
                    Policy.premium += Policy.percantageCalculated(20);

                }
                else if (Policy.ages.Min() > 25 && Policy.ages.Min() < 76)
                {
                    Policy.premium -= Policy.percantageCalculated(10);
                }

                driver.checkClaimDates();

            }
            return Math.Round(Policy.premium, 2);
        }//return end premium
    }
}
