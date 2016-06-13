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
    public partial class OverView : BaseForm
    {
        public OverView()
        {

            InitializeComponent();
            startLabel.ForeColor = Color.LimeGreen;
            startLabel.Text = "\u2714";
            driverLabel.ForeColor = Color.LimeGreen;
            driverLabel.Text = "\u2714";
            claimLabel.ForeColor = Color.LimeGreen;
            claimLabel.Text = "\u2714";
           


            DriversUpdate(driverOne, 0, false, false);
            switch (Policy.drivers.Count)
            {
                case 2:
                    DriversUpdate(driverTwo, 1, false, false);
                    Visibilty(driverTwo, Amend2, Delete2); 
                    break;
                case 3:
                    DriversUpdate(driverTwo, 1, false, false);
                    Visibilty(driverTwo, Amend2, Delete2);
                    DriversUpdate(driverThree, 2, false, false);
                    Visibilty(driverThree, Amend3, Delete3);
                    break;
                case 4:
                    DriversUpdate(driverTwo, 1, false, false);
                    Visibilty(driverTwo, Amend2, Delete2);
                    DriversUpdate(driverThree, 2, false, false);
                    Visibilty(driverThree, Amend3, Delete3);
                    DriversUpdate(driverFour, 3, false, false);
                    Visibilty(driverFour, Amend4, Delete4);
                    break;
                case 5:
                    DriversUpdate(driverTwo, 1, false, false);
                    Visibilty(driverTwo, Amend2, Delete2);
                    DriversUpdate(driverThree, 2, false, false);
                    Visibilty(driverThree, Amend3, Delete3);
                    DriversUpdate(driverFour, 3, false, false);
                    Visibilty(driverFour, Amend4, Delete4);
                    Visibilty(driverFive, Amend5, Delete5);
                    DriversUpdate(driverFive, 4, false, false);
                    break;
            }


        }
        public void Visibilty(TextBox text, Button one, Button two)
        {
            text.Visible = true;
            one.Text = "Amend";
            two.Visible = true;
        }

        public void Invisibilty(TextBox text, Button one, Button two)
        {
            text.Visible = false;
            one.Text = "Add Driver";
            two.Visible = false;
        }


        public void DriversUpdate(TextBox text, int driverNumber, Boolean clear, Boolean delete)
        {
            if (clear)
            {
                text.Clear();

                if (delete)
                {   
                    Policy.drivers.Remove(Policy.drivers[driverNumber]);
                    Policy.ages.Remove(Policy.ages[driverNumber]);
                }
            }
           try
            {
                text.AppendText("Driver ");
                text.AppendText(Convert.ToString(driverNumber + 1));
                text.AppendText("\n");
                text.AppendText(Policy.drivers[driverNumber].DriverName);
                text.AppendText("\n");
                text.AppendText("Occupation: ");
                text.AppendText(Policy.drivers[driverNumber].Occupation);
                text.AppendText("\n");
                text.AppendText("Age: ");
                text.AppendText(Convert.ToString(Policy.drivers[driverNumber].DriverAge));
                text.AppendText("\n");
                text.AppendText("No. of claims: ");
                text.AppendText(Convert.ToString(Policy.drivers[driverNumber].NumberOfClaims));
                text.AppendText("\n");
                text.AppendText("Claim dates: ");

                foreach (DateTime claim in Policy.drivers[driverNumber].claimDates)
                {

                    text.AppendText(Convert.ToString(claim.Date.ToString("d")));
                    text.AppendText("\n");
                }
            }
            catch
            {
                
            }
        }    
           
        

      
        

        private void button3_Click(object sender, EventArgs e)
        {
            AmmendDriver(0);

        }
        private void AmmendDriver(int driverNumber)
        {

            DriverDetails DForm = new DriverDetails(driverNumber, true);
            DForm.StartPosition = FormStartPosition.Manual;
            DForm.Show(this);
            Hide();
        }//opens another driverdetails class

        private void button4_Click(object sender, EventArgs e)
        {
            if (Policy.drivers.Count == 1)
            {
                var result = MessageBox.Show("Last driver: Would you like to restart?", "Restart",
    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Restart = true;
                    Application.Restart();


                }

            }
            else
            {
                switch (Policy.drivers.Count)
                {
                   
                    case 2:
                        Invisibilty(driverTwo, Amend2, Delete2);
                        DriversUpdate(driverOne, 0, true, true);
                        break;
                    case 3:
                        Invisibilty(driverThree, Amend3, Delete3);
                        DriversUpdate(driverOne, 0, true, true);
                        DriversUpdate(driverTwo, 1, true, false);
                        break;
                    case 4:
                        Invisibilty(driverFour, Amend4, Delete4);
                        DriversUpdate(driverOne, 0, true, true);
                        DriversUpdate(driverTwo, 1, true, false);
                        DriversUpdate(driverThree, 2, true, false);
                        break;
                    case 5:
                        Invisibilty(driverFive, Amend5, Delete5);
                        DriversUpdate(driverOne, 0, true, true);
                        DriversUpdate(driverTwo, 1, true, false);
                        DriversUpdate(driverThree, 2, true, false);
                        DriversUpdate(driverFour, 3, true, false);
                        break;

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmmendDriver(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AmmendDriver(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AmmendDriver(3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AmmendDriver(4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Delete5_Click(object sender, EventArgs e)
        {
            Invisibilty(driverFive, Amend5, Delete5);
            DriversUpdate(driverFive, 4, true, true);
        }

        private void Delete4_Click(object sender, EventArgs e)
        {
            if (Policy.drivers.Count == 5)
            {
                Invisibilty(driverFive, Amend5, Delete5);
                DriversUpdate(driverFour, 3, true, true);
            }
            else
            {
                Invisibilty(driverFour, Amend4, Delete4);
                DriversUpdate(driverFour, 3, true, true);
            }
        }

        private void Delete3_Click(object sender, EventArgs e)
        {
            switch (Policy.drivers.Count)
            {
                case 3:
                    Invisibilty(driverThree, Amend3, Delete3);
                    DriversUpdate(driverThree, 2, true, true);
                    break;
                case 4:
                    Invisibilty(driverFour, Amend4, Delete4);
                    DriversUpdate(driverThree, 2, true, true);
                    break;
                case 5:
                    Invisibilty(driverFive, Amend5, Delete5);
                    DriversUpdate(driverThree, 2, true, true);
                    DriversUpdate(driverFour, 3, true, false);
                    break;
            }
        }

        private void Delete2_Click(object sender, EventArgs e)
        {
            switch (Policy.drivers.Count)
            {
                case 2:
                    Invisibilty(driverTwo, Amend2, Delete2);
                    DriversUpdate(driverTwo, 1, true, true);
                    break;
                case 3:
                    Invisibilty(driverThree, Amend3, Delete3);
                    DriversUpdate(driverTwo, 1, true, true);
                    break;
                case 4:
                    Invisibilty(driverFour, Amend4, Delete4);
                    DriversUpdate(driverTwo, 1, true, true);
                    DriversUpdate(driverThree, 2, true, false);
                    break;
                case 5:
                    Invisibilty(driverFive, Amend5, Delete5);
                    DriversUpdate(driverTwo, 1, true, true);
                    DriversUpdate(driverThree, 2, true, false);
                    DriversUpdate(driverFour, 3, true, false);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Submitted submit = new Submitted();
            submit.StartPosition = FormStartPosition.Manual;
            submit.Show(this);
            Hide();
        }
    }
}

