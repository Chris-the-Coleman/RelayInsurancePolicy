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
        Boolean claimDates = false;
        Boolean policyClaimDates = false;
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
            CalculatePremium();
            if(AcceptorDecline())
            {
                policyBox.AppendText("Approved");
                policyBox.AppendText("\n");
                policyBox.AppendText("Your policy for ");
                policyBox.AppendText(Convert.ToString(Policy.drivers.Count));
                policyBox.AppendText(" drivers shall cost:");
                policyBox.AppendText("\n");
                policyBox.AppendText("£");
                Double premium = Math.Round(Policy.premium, 2);
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

        private void CalculatePremium()
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

                if(Policy.ages.Min() > 21 && Policy.ages.Min() < 26)
                {
                    Policy.premium += Policy.percantageCalculated(20);

                }
                else if(Policy.ages.Min() > 25 && Policy.ages.Min() < 76)
                {
                    Policy.premium -= Policy.percantageCalculated(10);
                }
                
                driver.checkClaimDates();
            }
        }//return end premium

        private Boolean AcceptorDecline()
        {
            if (Policy.ages.Min() < 21) youngest = true;
            if (Policy.ages.Max() > 75) oldest = true;
            if (Policy.Claims > 3) policyClaimDates = true;
            foreach(Driver driver in Policy.drivers)
            {
                if (driver.NumberOfClaims > 2) claimDates = true;
            }

            if (youngest || oldest || policyClaimDates || claimDates) return false;
            else return true;
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
            if(policyClaimDates)
            {
                policyBox.AppendText("Policy has more than 3 claims");
                policyBox.AppendText("\n");
            }
            if(claimDates)
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
    }
}
