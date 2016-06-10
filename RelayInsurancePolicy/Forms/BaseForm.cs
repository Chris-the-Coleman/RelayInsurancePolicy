using System;

using System.Windows.Forms;

namespace RelayInsurancePolicy
{
    public partial class BaseForm : Form
    {
        public Boolean Exit = true;
        private static Boolean CompleteExit = false;
        public static Boolean Restart = false;
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            if(Owner != null)
            Location = Owner.Location;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            const string message = "Are you sure that you would like to exit?";
            const string caption = "Exit";
            if(!Restart)
            { if (Exit && !CompleteExit)
                {
                    var result = MessageBox.Show(message, caption,
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {

                        e.Cancel = true;
                    }
                    else
                    {

                        CompleteExit = true;
                        Application.Exit();
                    }
                }
            }
        }//creates prompt message when user closes program
    }
}
