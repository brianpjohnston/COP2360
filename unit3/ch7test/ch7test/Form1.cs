using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ch7test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           int[] n = { 16, 3, 7, 18, 21 };

	          	
int max = n[0];

for (int i = 1; i < n.Length; i++)

{

if (n[i] > max)

{

max = n[i];

}

}

MessageBox.Show(max.ToString());

    






        }
    }
}
