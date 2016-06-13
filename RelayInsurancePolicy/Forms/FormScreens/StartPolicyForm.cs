using System;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace RelayInsurancePolicy
{
    public partial class StartPolicyForm : BaseForm
    {
        
        public StartPolicyForm()
        {
            InitializeComponent();
            startLabel.ForeColor = Color.LimeGreen;
            startLabel.Text = "\u2714";
            startPolicy_dateP.Value = DateTime.Today;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           if (startDateCheck())
            {
               
                Policy.PolicyStart = startPolicy_dateP.Value;
                if (CheckNumberofDrivers())
                    Policy.NumberOfDrivers = (int)startPolicy_Drivernumber.Value;
                else driversDelete();

                DriverDetails DForm = new DriverDetails(0, false);
                DForm.StartPosition = FormStartPosition.Manual;
                DForm.Show(this);
                Hide();
            }
            else MessageBox.Show("Declined: Start Date of Policy");

        } 
        public Boolean startDateCheck()
        {
            if (startPolicy_dateP.Value < DateTime.Today) return false;
            else return true;
        }

        public Boolean CheckNumberofDrivers()
        {
            if (Policy.drivers.Count == 0 || (int)startPolicy_Drivernumber.Value >= Policy.drivers.Count)
                return true;
            else return false;
        }

        public void driversDelete()
        {
            do
            {
                Policy.drivers.Remove(Policy.drivers.Last());
            } while (Policy.drivers.Count != (int)startPolicy_Drivernumber.Value);
            Policy.NumberOfDrivers = (int)startPolicy_Drivernumber.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
