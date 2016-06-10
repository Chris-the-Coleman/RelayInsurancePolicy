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
    public partial class DriverDetails : BaseForm
    {
        public static int driverNumber;// determines which driver we are editing
        public static Boolean change; // determines if we are editing existing driver
        public static Boolean previous { get; set; }
        private List<string> _items = new List<string>();


        public DriverDetails(int DriverNumber, Boolean Change)
        {
            driverNumber = DriverNumber;
            change = Change;

            InitializeComponent();
            _items.Add("Accountant");
            _items.Add("Chaffuer");

            driverocc1.DataSource = _items;
            driverdob1.MaxDate = DateTime.Today;
            driver1ClaimDate1.MaxDate = DateTime.Today;
            driver1ClaimDate2.MaxDate = DateTime.Today;
            driver1ClaimDate3.MaxDate = DateTime.Today;
            driver1ClaimDate4.MaxDate = DateTime.Today;
            driver1ClaimDate5.MaxDate = DateTime.Today;

            startLabel.ForeColor = Color.LimeGreen;
            startLabel.Text = "\u2714";
            driverLabel.ForeColor = Color.LimeGreen;
            driverLabel.Text = "\u2714";

            if (change)
            {
                button2.Text = "No Changes";
                button2.Update();
            }



            switch (driverNumber)
            {
                case 0: this.driverTitle.Text = "Driver One details"; break;
                case 1: this.driverTitle.Text = "Driver two details"; break;
                case 2: this.driverTitle.Text = "Driver three details"; break;
                case 3: this.driverTitle.Text = "Driver four details"; break;
                case 4: this.driverTitle.Text = "Driver five details"; break;
            }
            driverTitle.Update();

             if (Policy.drivers.Count >= driverNumber + 1)
            {
                try
                {
                    drivername1.Text = Policy.drivers[driverNumber].DriverName;
                    if(Policy.drivers[driverNumber].Occupation.Equals("Accountant"))
                    driverocc1.SelectedIndex = 0;
                    else driverocc1.SelectedIndex = 1;
                    driverdob1.Value = Policy.dateOfBirths[driverNumber];

                    if(Policy.drivers[driverNumber].NumberOfClaims > 0)
                    {
                        driverclaims1.Value = Policy.drivers[driverNumber].NumberOfClaims;
                        claimInitializedVisbibilty();
                        if (driverclaims1.Value > 0) driver1ClaimDate1.Value = Policy.drivers[driverNumber].claimDates[0];
                        if (driverclaims1.Value > 1) driver1ClaimDate2.Value = Policy.drivers[driverNumber].claimDates[1];
                        if (driverclaims1.Value > 2) driver1ClaimDate3.Value = Policy.drivers[driverNumber].claimDates[2];
                        if (driverclaims1.Value > 3) driver1ClaimDate4.Value = Policy.drivers[driverNumber].claimDates[3];
                        if (driverclaims1.Value > 4) driver1ClaimDate5.Value = Policy.drivers[driverNumber].claimDates[4];
                    }
                    driverclaims1.Update();
                    driver1ClaimDate1.Update();
                    driver1ClaimDate2.Update();
                    driver1ClaimDate3.Update();
                    driver1ClaimDate4.Update();
                    driver1ClaimDate5.Update();
                    driverdob1.Update();
                    driverocc1.Update();
                    drivername1.Update();

                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
       private void claimVisibilty()
        {
            switch ((int)driverclaims1.Value)
            {
                case 0:
                    claim(false, dateclaim1, driver1ClaimDate1);
                    break;

                case 1:
                    claim(true, dateclaim1, driver1ClaimDate1);
                    claim(false, dateclaim2, driver1ClaimDate2);
                    break;
                case 2:
                    claim(true, dateclaim2, driver1ClaimDate2);
                    claim(false, dateclaim3, driver1ClaimDate3);
                    break;
                case 3:
                    claim(true, dateclaim3, driver1ClaimDate3);
                    claim(false, dateclaim4, driver1ClaimDate4);
                    break;
                case 4:
                    claim(true, dateclaim4, driver1ClaimDate4);
                    claim(false, dateclaim5, driver1ClaimDate5);
                    break;
                case 5:
                    claim(true, dateclaim5, driver1ClaimDate5);
                    break;
            }
        }//displays entry for claims

       private void claimInitializedVisbibilty()
        {
            switch((int)driverclaims1.Value)
            {
                case 1:
                    claim(true,dateclaim1,driver1ClaimDate1);
                    break;
                case 2:
                    claim(true, dateclaim1, driver1ClaimDate1);
                    claim(true, dateclaim2, driver1ClaimDate2);
                    break;
                case 3:
                    claim(true, dateclaim1, driver1ClaimDate1);
                    claim(true, dateclaim2, driver1ClaimDate2);
                    claim(true, dateclaim3, driver1ClaimDate3);
                    break;
                case 4:
                    claim(true, dateclaim1, driver1ClaimDate1);
                    claim(true, dateclaim2, driver1ClaimDate2);
                    claim(true, dateclaim3, driver1ClaimDate3);
                    claim(true, dateclaim4, driver1ClaimDate4);
                    break;
                case 5:
                    claim(true, dateclaim1, driver1ClaimDate1);
                    claim(true, dateclaim2, driver1ClaimDate2);
                    claim(true, dateclaim3, driver1ClaimDate3);
                    claim(true, dateclaim4, driver1ClaimDate4);
                    claim(true, dateclaim5, driver1ClaimDate5);
                    break;




            }
        }//initialzing which claims are visible
       
        private void claim(Boolean visible, Label label, DateTimePicker picker)
        {
            if (visible)
            {
                label.Visible = true;
                picker.Visible = true;
            }
            else
            {
                label.Visible = false;
                picker.Visible = false;
            }
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (drivername1.TextLength == 0) throw new Exception();

                else
                {
                    if (Policy.drivers.Count >= driverNumber + 1)
                    {
                        Policy.updateDriver(driverNumber, drivername1.Text, Convert.ToString(driverocc1.SelectedItem), driverdob1.Value, (int)driverclaims1.Value);
                        MessageBox.Show("Driver updated!");
                    }
                    else
                    {
                        MessageBox.Show("New driver added!");
                        Policy.addDriver(drivername1.Text, Convert.ToString(driverocc1.SelectedItem), driverdob1.Value, (int)driverclaims1.Value);

                    }

                    if (driverclaims1.Value > 0)
                    { AddClaims(); }
                    if (!change)
                    {
                        if (driverNumber == Policy.NumberOfDrivers - 1)
                        {
                            OverviewForm();
                        }
                        else
                        {
                            NewDriver();
                        }
                    }
                    else { OverviewForm(); }

                }
            }
            catch
            {
                MessageBox.Show("Error: Please enter values into all available fields");

            }
            
        }
        private void OverviewForm()
        {
            const string message = "Submit drivers?";
            const string caption = "Send";
            
           var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {



                OverView overViewForm = new OverView();
                overViewForm.StartPosition = FormStartPosition.Manual;
                overViewForm.Show(this);
                Hide();
            }
        }//opens the overview form

        private void NewDriver()
        {
            driverNumber++;
            DriverDetails DForm = new DriverDetails(driverNumber, false);
            DForm.StartPosition = FormStartPosition.Manual;
            DForm.Show(this);
            Hide();
        }//opens another driverdetails class


        private void AddClaims()
        {
            if (driver1ClaimDate1.Visible) Policy.drivers[driverNumber].addClaimDates(driver1ClaimDate1.Value);
            if (driver1ClaimDate2.Visible) Policy.drivers[driverNumber].addClaimDates(driver1ClaimDate2.Value);
            if (driver1ClaimDate3.Visible) Policy.drivers[driverNumber].addClaimDates(driver1ClaimDate3.Value);
            if (driver1ClaimDate4.Visible) Policy.drivers[driverNumber].addClaimDates(driver1ClaimDate4.Value);
            if (driver1ClaimDate5.Visible) Policy.drivers[driverNumber].addClaimDates(driver1ClaimDate5.Value);
        }//Checks to see if claim date is visible if true adds date to claim list



        private void button2_Click(object sender, EventArgs e)
        {
            CloseForm();
        }// previous form

        private void CloseForm()
        {
            if (!change)
            { if (driverNumber > 0) driverNumber--; }
            Owner.Show();
            Exit = false;
            Close();
        }

        private void driverclaims1_ValueChanged_1(object sender, EventArgs e)
        {
            claimVisibilty();
        }
    }
}
