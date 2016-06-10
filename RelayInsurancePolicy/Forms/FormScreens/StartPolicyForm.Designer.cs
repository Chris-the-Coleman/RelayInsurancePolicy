namespace RelayInsurancePolicy
{
    partial class StartPolicyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startPolicy_Drivernumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startPolicy_dateP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relaylogo)).BeginInit();
            this.bottomcontainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPolicy_Drivernumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(222, 9);
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startPolicy_Drivernumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.startPolicy_dateP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            // 
            // startPolicy_Drivernumber
            // 
            this.startPolicy_Drivernumber.Location = new System.Drawing.Point(177, 174);
            this.startPolicy_Drivernumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.startPolicy_Drivernumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startPolicy_Drivernumber.Name = "startPolicy_Drivernumber";
            this.startPolicy_Drivernumber.Size = new System.Drawing.Size(200, 20);
            this.startPolicy_Drivernumber.TabIndex = 14;
            this.startPolicy_Drivernumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(90, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "You may have up to 5 drivers on one policy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(93, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter the number of drivers on the policy";
            // 
            // startPolicy_dateP
            // 
            this.startPolicy_dateP.Location = new System.Drawing.Point(177, 101);
            this.startPolicy_dateP.Name = "startPolicy_dateP";
            this.startPolicy_dateP.Size = new System.Drawing.Size(200, 20);
            this.startPolicy_dateP.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(90, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "To begin please select a policy start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(128, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome to Relay insurance!";
            // 
            // StartPolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Name = "StartPolicyForm";
            this.Text = "StartPolicyForm";
            this.topContainer.ResumeLayout(false);
            this.topContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relaylogo)).EndInit();
            this.bottomcontainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPolicy_Drivernumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown startPolicy_Drivernumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startPolicy_dateP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}