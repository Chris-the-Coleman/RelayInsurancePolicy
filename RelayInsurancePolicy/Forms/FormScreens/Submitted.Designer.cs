namespace RelayInsurancePolicy
{
    partial class Submitted
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
            this.policyBox = new System.Windows.Forms.TextBox();
            this.topContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relaylogo)).BeginInit();
            this.bottomcontainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Text = "Restart";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Text = "Finish";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.policyBox);
            // 
            // policyBox
            // 
            this.policyBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.policyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.policyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.policyBox.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.policyBox.Location = new System.Drawing.Point(0, 0);
            this.policyBox.Multiline = true;
            this.policyBox.Name = "policyBox";
            this.policyBox.Size = new System.Drawing.Size(532, 366);
            this.policyBox.TabIndex = 0;
            // 
            // Submitted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Name = "Submitted";
            this.Text = "Submitted";
            this.topContainer.ResumeLayout(false);
            this.topContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relaylogo)).EndInit();
            this.bottomcontainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox policyBox;
    }
}