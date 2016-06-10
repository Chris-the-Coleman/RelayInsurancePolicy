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
    public partial class StartPolicyForm : BaseForm
    {
        
        public StartPolicyForm()
        {
            InitializeComponent();
            startLabel.ForeColor = Color.LimeGreen;
            startLabel.Text = "\u2714";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           if (startPolicy_dateP.Value < DateTime.Today)
            {
                MessageBox.Show("Declined: Start Date of Policy");
               

            }
            else
            {
                Policy.PolicyStart = startPolicy_dateP.Value;
                if (Policy.drivers.Count == 0 || (int)startPolicy_Drivernumber.Value >= Policy.drivers.Count)
                    Policy.NumberOfDrivers = (int)startPolicy_Drivernumber.Value;
                else driverNumberUpdate();
                DriverDetails DForm = new DriverDetails(0, false);
                DForm.StartPosition = FormStartPosition.Manual;
                DForm.Show(this);
                Hide();
            }
        } 

        private void driverNumberUpdate()
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
