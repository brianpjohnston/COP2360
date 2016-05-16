using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //method to calculte present value
        private double PresentValue(double future, double interest, double years)
        {
        return future / (Math.Pow(1 + interest/100, years));
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //declare variables
            double futureValue, interestrate, presentValue, amountyears;

            //getting future value
            if(double.TryParse(desiredTextBox.Text, out futureValue))
            {


                //get interest rate
                if(double.TryParse(rateTextBox.Text, out interestrate))
                {
                    //get years 
                    if(double.TryParse(yearsTextBox.Text, out amountyears))
                    {
                        //calculating present value
                        presentValue = PresentValue(futureValue, interestrate, amountyears);

                        //posting to output label
                        outputLabel.Text = presentValue.ToString("c");
                    }
                    else
                    {
                        //show error message for years
                        MessageBox.Show("Please enter a valid amount of years.");

                    }

                }
                else
                    {
                        //show error message for interest
                        MessageBox.Show("Please enter a valid interest rate.");

                    }
            }
            else
                    {
                        //show error message for future value
                        MessageBox.Show("Please enter a valid future amount.");

                    }

        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear textboxes
            yearsTextBox.Text = "";
            rateTextBox.Text = "";
            desiredTextBox.Text = "";

            //clear outputlabel
            outputLabel.Text = "";

            //change focus to years textbox
            yearsTextBox.Focus();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            //close form
            this.Close();

        }

        
       
    }
}
