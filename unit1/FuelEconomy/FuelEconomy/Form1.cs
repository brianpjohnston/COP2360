using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    public partial class outputDescriptionLabel : Form
    {
        public outputDescriptionLabel()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;   // To hold miles driven
            double gallons;     //to hold gallons used
            double mpg;          //To hold mpg

            //Get the miles driven and assign to the miles variable
            miles = double.Parse(milesTextBox.Text);

            //Get the gallons and assign to the gallons variable
            gallons= double.Parse(gallonsTextBox.Text);

            //calculate mpg
            mpg = miles / gallons;

            //Display Mpg in label
            mpgLabel.Text = mpg.ToString();
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
