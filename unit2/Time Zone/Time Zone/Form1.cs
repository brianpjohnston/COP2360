﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city; //holds name of city

            if (cityListBox.SelectedIndex != -1)
            {
                //get selected item
                city = cityListBox.SelectedItem.ToString();

                //determine the timezone
                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aluetian";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        break;


                }
            }
            else
            {
                //no city was selected
                MessageBox.Show("Select a city.");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}