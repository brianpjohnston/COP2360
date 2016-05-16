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

namespace test5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = open("data.txt");

            inputFile = OpenFile("data.txt");

            inputFile = File.OpenFile("Data.txt");

            inputFile = File.OpenText("Data.txt");


            }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        }
    }

