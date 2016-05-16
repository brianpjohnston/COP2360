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

namespace RandomNumberGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int RandomNumberAmount;
                RandomNumberAmount = int.Parse(inputTextBox.Text.ToString());
                int random = 0;
                int count =1;
                saveFileDialog.DefaultExt ="txt";
                StreamWriter outputFile;
               

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.CreateText(saveFileDialog.FileName);
                    Random rand = new Random();
                    
                    while(count <= RandomNumberAmount)
                    {
                        random = rand.Next(100) +1;
                        outputFile.WriteLine(random);
                        count ++;
                    }
                    outputFile.Close();
                }
                else
                {
                    MessageBox.Show("Operation was cancelled");
                }
               
            }
            catch
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
