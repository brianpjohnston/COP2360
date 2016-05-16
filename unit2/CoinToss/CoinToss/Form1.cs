using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinToss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //variable to indiicate side up
            int sideUp;
            

            //create a random object
            Random rand = new Random();

            //get random int in the range of 0 through 1.
            // 0 tails up 1 = heads up
            sideUp = rand.Next(2);

            //display the side that is up
            if (sideUp == 0)
            {

                //display tails up
                tailsPictureBox.Visible = true;
                headPictureBox.Visible = false;

            }
            else
            {
                //display heads up
                headPictureBox.Visible= true;
                tailsPictureBox.Visible= false;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
