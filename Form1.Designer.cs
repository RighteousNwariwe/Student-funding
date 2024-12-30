namespace Semester_Test_Practical_Question_CMPG_122__43511139
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNameAndSurname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBoxNameAndSurname = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lstBoxEmploymentType = new System.Windows.Forms.ListBox();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.grpBoxPreviousFunding = new System.Windows.Forms.GroupBox();
            this.picBoxThankYou = new System.Windows.Forms.PictureBox();
            this.btnSubmitApplication = new System.Windows.Forms.Button();
            this.btnNewApplication = new System.Windows.Forms.Button();
            this.checkBoxCorrectInfo = new System.Windows.Forms.CheckBox();
            this.radioReceivedFunding = new System.Windows.Forms.RadioButton();
            this.radioNotReceived = new System.Windows.Forms.RadioButton();
            this.grpBoxPreviousFunding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThankYou)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameAndSurname
            // 
            this.lblNameAndSurname.AutoSize = true;
            this.lblNameAndSurname.Location = new System.Drawing.Point(14, 25);
            this.lblNameAndSurname.Name = "lblNameAndSurname";
            this.lblNameAndSurname.Size = new System.Drawing.Size(99, 13);
            this.lblNameAndSurname.TabIndex = 0;
            this.lblNameAndSurname.Text = "Name and surname";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(14, 97);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // txtBoxNameAndSurname
            // 
            this.txtBoxNameAndSurname.Location = new System.Drawing.Point(149, 18);
            this.txtBoxNameAndSurname.Name = "txtBoxNameAndSurname";
            this.txtBoxNameAndSurname.Size = new System.Drawing.Size(163, 20);
            this.txtBoxNameAndSurname.TabIndex = 2;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(149, 94);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(163, 20);
            this.txtBoxAge.TabIndex = 3;
            // 
            // lstBoxEmploymentType
            // 
            this.lstBoxEmploymentType.FormattingEnabled = true;
            this.lstBoxEmploymentType.Items.AddRange(new object[] {
            "*****Select your current employment type*****",
            "",
            "Employed-Full time",
            "Employed-Part time",
            "Unemployed",
            "Self-employed",
            "Entrepreneur",
            "Tenderpreneur"});
            this.lstBoxEmploymentType.Location = new System.Drawing.Point(341, 19);
            this.lstBoxEmploymentType.Name = "lstBoxEmploymentType";
            this.lstBoxEmploymentType.Size = new System.Drawing.Size(239, 147);
            this.lstBoxEmploymentType.TabIndex = 4;
            // 
            // listOutput
            // 
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(16, 366);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(899, 238);
            this.listOutput.TabIndex = 5;
            // 
            // grpBoxPreviousFunding
            // 
            this.grpBoxPreviousFunding.Controls.Add(this.radioNotReceived);
            this.grpBoxPreviousFunding.Controls.Add(this.radioReceivedFunding);
            this.grpBoxPreviousFunding.Location = new System.Drawing.Point(610, 18);
            this.grpBoxPreviousFunding.Name = "grpBoxPreviousFunding";
            this.grpBoxPreviousFunding.Size = new System.Drawing.Size(305, 148);
            this.grpBoxPreviousFunding.TabIndex = 6;
            this.grpBoxPreviousFunding.TabStop = false;
            this.grpBoxPreviousFunding.Text = "Previous Funding";
            // 
            // picBoxThankYou
            // 
            this.picBoxThankYou.Image = ((System.Drawing.Image)(resources.GetObject("picBoxThankYou.Image")));
            this.picBoxThankYou.Location = new System.Drawing.Point(610, 189);
            this.picBoxThankYou.Name = "picBoxThankYou";
            this.picBoxThankYou.Size = new System.Drawing.Size(305, 151);
            this.picBoxThankYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxThankYou.TabIndex = 7;
            this.picBoxThankYou.TabStop = false;
            this.picBoxThankYou.Click += new System.EventHandler(this.picBoxThankYou_Click);
            // 
            // btnSubmitApplication
            // 
            this.btnSubmitApplication.Location = new System.Drawing.Point(16, 244);
            this.btnSubmitApplication.Name = "btnSubmitApplication";
            this.btnSubmitApplication.Size = new System.Drawing.Size(250, 83);
            this.btnSubmitApplication.TabIndex = 8;
            this.btnSubmitApplication.Text = "Submit Application";
            this.btnSubmitApplication.UseVisualStyleBackColor = true;
            this.btnSubmitApplication.Click += new System.EventHandler(this.btnSubmitApplication_Click);
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.Location = new System.Drawing.Point(330, 244);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.Size = new System.Drawing.Size(250, 83);
            this.btnNewApplication.TabIndex = 9;
            this.btnNewApplication.Text = "New Application";
            this.btnNewApplication.UseVisualStyleBackColor = true;
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // checkBoxCorrectInfo
            // 
            this.checkBoxCorrectInfo.AutoSize = true;
            this.checkBoxCorrectInfo.Location = new System.Drawing.Point(16, 201);
            this.checkBoxCorrectInfo.Name = "checkBoxCorrectInfo";
            this.checkBoxCorrectInfo.Size = new System.Drawing.Size(201, 17);
            this.checkBoxCorrectInfo.TabIndex = 10;
            this.checkBoxCorrectInfo.Text = "I declare that all information is correct";
            this.checkBoxCorrectInfo.UseVisualStyleBackColor = true;
            // 
            // radioReceivedFunding
            // 
            this.radioReceivedFunding.AutoSize = true;
            this.radioReceivedFunding.Location = new System.Drawing.Point(18, 31);
            this.radioReceivedFunding.Name = "radioReceivedFunding";
            this.radioReceivedFunding.Size = new System.Drawing.Size(170, 17);
            this.radioReceivedFunding.TabIndex = 0;
            this.radioReceivedFunding.TabStop = true;
            this.radioReceivedFunding.Text = "I have received funding before";
            this.radioReceivedFunding.UseVisualStyleBackColor = true;
            // 
            // radioNotReceived
            // 
            this.radioNotReceived.AutoSize = true;
            this.radioNotReceived.Location = new System.Drawing.Point(18, 79);
            this.radioNotReceived.Name = "radioNotReceived";
            this.radioNotReceived.Size = new System.Drawing.Size(188, 17);
            this.radioNotReceived.TabIndex = 1;
            this.radioNotReceived.TabStop = true;
            this.radioNotReceived.Text = "I have not received funding before";
            this.radioNotReceived.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(934, 617);
            this.Controls.Add(this.checkBoxCorrectInfo);
            this.Controls.Add(this.btnNewApplication);
            this.Controls.Add(this.btnSubmitApplication);
            this.Controls.Add(this.picBoxThankYou);
            this.Controls.Add(this.grpBoxPreviousFunding);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.lstBoxEmploymentType);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxNameAndSurname);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblNameAndSurname);
            this.Name = "Form1";
            this.Text = " Sizani Financial support application";
            this.grpBoxPreviousFunding.ResumeLayout(false);
            this.grpBoxPreviousFunding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThankYou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameAndSurname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBoxNameAndSurname;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.ListBox lstBoxEmploymentType;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.GroupBox grpBoxPreviousFunding;
        private System.Windows.Forms.PictureBox picBoxThankYou;
        private System.Windows.Forms.Button btnSubmitApplication;
        private System.Windows.Forms.Button btnNewApplication;
        private System.Windows.Forms.CheckBox checkBoxCorrectInfo;
        private System.Windows.Forms.RadioButton radioNotReceived;
        private System.Windows.Forms.RadioButton radioReceivedFunding;
    }
}

