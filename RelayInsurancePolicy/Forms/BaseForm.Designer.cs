namespace RelayInsurancePolicy
{
    partial class BaseForm
    {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.topContainer = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.relaylogo = new System.Windows.Forms.PictureBox();
            this.bottomcontainer = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.leftcontainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.claimLabel = new System.Windows.Forms.Label();
            this.overviewLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.submitlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relaylogo)).BeginInit();
            this.bottomcontainer.SuspendLayout();
            this.leftcontainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topContainer
            // 
            this.topContainer.Controls.Add(this.Title);
            this.topContainer.Controls.Add(this.relaylogo);
            this.topContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.topContainer.Location = new System.Drawing.Point(0, 0);
            this.topContainer.Name = "topContainer";
            this.topContainer.Size = new System.Drawing.Size(634, 55);
            this.topContainer.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(212, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(315, 32);
            this.Title.TabIndex = 1;
            this.Title.Text = "Relay Insurance Policy";
            // 
            // relaylogo
            // 
            this.relaylogo.Image = global::RelayInsurancePolicy.Properties.Resources.RelayLogo;
            this.relaylogo.Location = new System.Drawing.Point(0, 0);
            this.relaylogo.Name = "relaylogo";
            this.relaylogo.Size = new System.Drawing.Size(100, 55);
            this.relaylogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.relaylogo.TabIndex = 0;
            this.relaylogo.TabStop = false;
            // 
            // bottomcontainer
            // 
            this.bottomcontainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bottomcontainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomcontainer.Controls.Add(this.button2);
            this.bottomcontainer.Controls.Add(this.button1);
            this.bottomcontainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomcontainer.Location = new System.Drawing.Point(100, 423);
            this.bottomcontainer.Name = "bottomcontainer";
            this.bottomcontainer.Size = new System.Drawing.Size(534, 38);
            this.bottomcontainer.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // leftcontainer
            // 
            this.leftcontainer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.leftcontainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftcontainer.Controls.Add(this.tableLayoutPanel1);
            this.leftcontainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftcontainer.Location = new System.Drawing.Point(0, 55);
            this.leftcontainer.Name = "leftcontainer";
            this.leftcontainer.Size = new System.Drawing.Size(100, 406);
            this.leftcontainer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.startLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.driverLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.claimLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.overviewLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.submitlabel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09019F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.72361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.72361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.72361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.62421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.62421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.49057F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Policy";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.startLabel.Location = new System.Drawing.Point(78, 40);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(19, 51);
            this.startLabel.TabIndex = 4;
            this.startLabel.Text = "X";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.driverLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.driverLabel.Location = new System.Drawing.Point(78, 91);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(19, 22);
            this.driverLabel.TabIndex = 3;
            this.driverLabel.Text = "X";
            // 
            // claimLabel
            // 
            this.claimLabel.AutoSize = true;
            this.claimLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.claimLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.claimLabel.Location = new System.Drawing.Point(78, 142);
            this.claimLabel.Name = "claimLabel";
            this.claimLabel.Size = new System.Drawing.Size(19, 22);
            this.claimLabel.TabIndex = 5;
            this.claimLabel.Text = "X";
            // 
            // overviewLabel
            // 
            this.overviewLabel.AutoSize = true;
            this.overviewLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.overviewLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.overviewLabel.Location = new System.Drawing.Point(78, 193);
            this.overviewLabel.Name = "overviewLabel";
            this.overviewLabel.Size = new System.Drawing.Size(19, 22);
            this.overviewLabel.TabIndex = 6;
            this.overviewLabel.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Driver details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Overview";
            // 
            // submitlabel
            // 
            this.submitlabel.AutoSize = true;
            this.submitlabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitlabel.Location = new System.Drawing.Point(3, 193);
            this.submitlabel.Name = "submitlabel";
            this.submitlabel.Size = new System.Drawing.Size(65, 15);
            this.submitlabel.TabIndex = 11;
            this.submitlabel.Text = "Submitted";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(100, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 368);
            this.panel1.TabIndex = 3;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottomcontainer);
            this.Controls.Add(this.leftcontainer);
            this.Controls.Add(this.topContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.topContainer.ResumeLayout(false);
            this.topContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relaylogo)).EndInit();
            this.bottomcontainer.ResumeLayout(false);
            this.leftcontainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.ComponentModel.IContainer components;
        protected System.Windows.Forms.Panel topContainer;
        protected System.Windows.Forms.PictureBox relaylogo;
        protected System.Windows.Forms.Panel bottomcontainer;
        protected System.Windows.Forms.Panel leftcontainer;
        protected System.Windows.Forms.Label Title;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label startLabel;
        protected System.Windows.Forms.Label claimLabel;
        protected System.Windows.Forms.Label overviewLabel;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label submitlabel;
        protected System.Windows.Forms.Label driverLabel;
        protected System.Windows.Forms.Panel panel1;
    }

    
}