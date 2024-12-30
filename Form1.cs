using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Test_Practical_Question_CMPG_122__43511139
{
    public partial class Form1 : Form
    { //nhlanhla nwariwe 43511139
        public Form1()
        {
            InitializeComponent();
            //focus on name
            txtBoxNameAndSurname.Focus();
        }

        private void btnSubmitApplication_Click(object sender, EventArgs e)
        {
            //declarations
            string name=txtBoxNameAndSurname.Text;
            int age;
            const double baseFund = 15000.00;
            double FundAmount=0;
            double totalFunding=0;
            int years=3;
            int EmploymentType = lstBoxEmploymentType.SelectedIndex;

            if(checkBoxCorrectInfo.Checked)
            {
                //code to check if they input the correct age
                if (int.TryParse(txtBoxAge.Text, out age) && age > 18 && age < 36)
                {


                    //switch statement
                    switch (EmploymentType)
                    {
                        case 2:
                            years = 3;
                            break;

                        case 3:
                            years = 3;
                            break;

                        case 4:
                            years = 3;
                            break;

                        case 5:
                            years = 4;
                            break;

                        case 6:
                            years = 5;
                            break;

                        case 7:
                            years = 3;
                            break;



                    }


                    //to get the FundAmount
                    if (radioReceivedFunding.Checked)
                    {

                        FundAmount = baseFund + 25000;
                        totalFunding = (25000 * years);

                    }
                    else if (radioNotReceived.Checked)
                    {
                        FundAmount = baseFund + 40000;
                        totalFunding = (40000 * years);
                    }



                    //code to generate random number for reference
                    Random rand = new Random();
                    int randomReference = rand.Next(100000, 1000000);//number that is 6 degits




                    listOutput.Items.Add("Funding application receipt for " + name);
                    listOutput.Items.Add("");

                    //while loop
                    int counter = 1;
                    while (counter <= years)
                    {
                        listOutput.Items.Add("Funding for year " + counter + " will be R" + FundAmount + " with payout reference: " + randomReference);
                        listOutput.Items.Add("");


                        counter++;
                    }

                    ;
                    listOutput.Items.Add("If approved, the total funded amount, will be " + totalFunding);


                }
                else
                {
                    MessageBox.Show("Sorry only adults between the age of 18 and 36 are invited to apply for \r\nfunding to start a new business.");
                }




            }
            else
            {
                MessageBox.Show("Please declare that all information provided is correct.");
            }













        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            //declarations to clear 
            txtBoxAge.Text = "";
            txtBoxNameAndSurname.Text = "";
            lstBoxEmploymentType.SelectedIndex = -1;
            radioReceivedFunding.Checked = false;
            radioNotReceived.Checked = false;
            checkBoxCorrectInfo.Checked = false;
            listOutput.Items.Clear();
        }

        private void picBoxThankYou_Click(object sender, EventArgs e)
        {
            //code to close the form
            this.Close();
        }
    }
}
