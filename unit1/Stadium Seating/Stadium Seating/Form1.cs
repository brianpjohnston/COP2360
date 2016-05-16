using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
       //declaring seat value
        const int CLASS_A_COST = 15;
        const int CLASS_B_COST = 12;
        const int CLASS_C_COST = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                //to catch number of tickets
                int classa;
                int classb;
                int classc;
                int classARev;
                int classBRev;
                int classCRev;
                int totalRev;

                //getting values
                classa = int.Parse(inputClassATextBox.Text);
                classb = int.Parse(inputClassBTextBox.Text);
                classc = int.Parse(inputClassCTextBox.Text);

                //getting revenues
                classARev = classa * CLASS_A_COST;
                classBRev = classb * CLASS_B_COST;
                classCRev = classc * CLASS_C_COST;
                totalRev = classARev + classBRev + classCRev;

                //displaying revenue totals
                classAOutputLabel.Text = classARev.ToString("c");
                classBOutputLabel.Text = classBRev.ToString("c");
                classCOutputLabel.Text = classCRev.ToString("c");
                totalOutputLabel.Text = totalRev.ToString("c");



            }

            catch (Exception ex)
                {
                    //display default exception
                    MessageBox.Show(ex.Message);
                }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing textboxes
            inputClassATextBox.Text = "";
            inputClassBTextBox.Text = "";
            inputClassCTextBox.Text = "";
            //clearing labels
            classAOutputLabel.Text = "";
            classBOutputLabel.Text = "";
            classCOutputLabel.Text = "";
            totalOutputLabel.Text = "";

            //Setting focus class a input
            inputClassATextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
