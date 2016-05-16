using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changecounter
{
    public partial class Form1 : Form
    {
        //contstant fields
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = .50m;

        // total variaiable starts with 0
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //add to total
            total += FIVE_CENTS_VALUE;

            //display new total
            totalLabel.Text = total.ToString("c");

        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            //add to total
            total += TEN_CENTS_VALUE;

            //display new total
            totalLabel.Text= total.ToString("c");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //add to total
            total += TWENTY_FIVE_CENTS_VALUE;

            //display new total
            totalLabel.Text =total.ToString("c");
              
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            //add to total
            total += FIFTY_CENTS_VALUE;

            //display new total
            totalLabel.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
