using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Code_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //Array to hold characters
            char[] Letters = new char[] { ' ', ',', '.', '?', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 
                                          'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 
                                          'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //Array to hold Morse code
            string[] MorseCode = new string[] { " ", "--..--", ".-.-.-", "..--..", "-----", ".----", "..---", 
                                                "...--", "....-", ".....", "-....", "--...", "---..", "----.", 
                                                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", 
                                                ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", 
                                                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            //Declare variables
            string input = inputTextBox.Text.ToLower();
            string result = "";
            int index = -1;

            //Step through input and convert
            for (int i = 0; i <= input.Length - 1; i++)
            {
                index = Array.IndexOf(Letters, input[i]);
                if (index != -1)
                    result += MorseCode[index] + " ";
             }
            
            //Show result in dialog
            MessageBox.Show(result);
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear fields
            inputTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
