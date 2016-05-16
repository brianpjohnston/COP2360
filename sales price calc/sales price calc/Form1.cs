using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_price_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice; //declare original proce
            decimal discountpercentage; //declare percentage
            decimal discountAmount; //declare discount
            decimal salePrice;  //declare sales price
            
            //Store the original price
            originalPrice = decimal.Parse(originalPriceTextBox.Text);

            //Store discount percent
            discountpercentage = decimal.Parse(discountPercentageTextBox.Text);

            //convert discount percentage
            discountpercentage = discountpercentage / 100;

            //figoure out discount amount
            discountAmount = originalPrice * discountpercentage;

            //calculate sales price
            salePrice = originalPrice - discountAmount;

            salesPriceLabel.Text = salePrice.ToString("c");



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
