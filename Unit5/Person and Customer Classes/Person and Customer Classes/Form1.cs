using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_and_Customer_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * The GetCustData method accepts customer as an arguement. It assigns the data entered by
         * the user to the objects properties.
         */
        private void GetCustData(Customer customer)
        {
            //Temp variables
            int custNumber;
                          
            //Get the customer data
            if (nameTextBox.Text != "")
            {
                customer.Name = nameTextBox.Text;

                if (addressTextBox.Text != "")
                {
                    customer.Address = addressTextBox.Text;

                    if (telephoneTextBox.Text != "")
                    {
                        customer.Telephone = telephoneTextBox.Text;
                        if (int.TryParse(customerNumberTextBox.Text, out custNumber))
                        {
                            customer.CustomerNumber = custNumber;
                        }
                        else
                        {
                            //Error message
                            MessageBox.Show("Please enter a valid customer number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid telephone number.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid address.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid name.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create Customer object
            Customer newCustomer = new Customer();

            //Get the customer data.
            GetCustData(newCustomer);

            //Display customer data.
            nameLabel.Text = newCustomer.Name;
            addressLabel.Text = newCustomer.Address;
            telephoneLabel.Text = newCustomer.Telephone;
            custNumberLabel.Text = newCustomer.CustomerNumber.ToString();

            if (mailListCheckBox.Checked)
            {
                mailListLabel.Text = "True";
            }
            else
            {
                mailListLabel.Text = "False";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            
    }
}
