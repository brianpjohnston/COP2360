using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disntace_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (fromListBox.SelectedIndex != -1)
                {
                    if (toListBox.SelectedIndex != -1)
                    {
                        double fromdistance, todistance;
                        string measureinput, measureoutput;


                        todistance = 0;
                        fromdistance = double.Parse(distanceTextBox.Text);
                        measureinput = fromListBox.SelectedItem.ToString();
                        measureoutput = toListBox.SelectedItem.ToString();

                        switch (measureinput)
                        {
                            case "Inches":
                                switch (measureoutput)
                                {
                                    case "Inches":
                                        todistance = fromdistance;
                                        break;
                                    case "Feet":
                                        todistance = fromdistance / 12;
                                        break;
                                    case "Yards":
                                        todistance = fromdistance / 36;
                                        break;
                                }
                                break;

                            case "Feet":
                                switch (measureoutput)
                                {
                                    case "Inches":
                                        todistance = fromdistance * 12;
                                        break;
                                    case "Feet":
                                        todistance = fromdistance;
                                        break;
                                    case "Yards":
                                        todistance = fromdistance / 3;
                                        break;
                                }
                                break;
                            case "Yards":
                                switch (measureoutput)
                                {
                                    case "Inches":
                                        todistance = fromdistance * 36;
                                        break;
                                    case "Feet":
                                        todistance = fromdistance * 12;
                                        break;
                                    case "Yards":
                                        todistance = fromdistance;
                                        break;

                                }
                                break;
                        }
                        convertedDistanceLabel.Text = todistance.ToString();
                    }
                    else
	{
        MessageBox.Show("Please select a to measurement.");       
	}


                }
                else
                {
                    MessageBox.Show("Please select a from measurement.");  
                }
               
            }

            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}



