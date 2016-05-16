using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_and_Customer_Classes
{
    class Customer : Person
    {
        //Fields
        private int _custNumber;
        private bool _mailList;

        //Constructor
        public Customer()
        {
            _custNumber = 0;
            _mailList = false;
        }

        //Customer Number property
        public int CustomerNumber
        {
            get { return _custNumber; }
            set { _custNumber = value; }
        }

        //Mailing List property
        public bool MailList
        {
            get { return _mailList; }
            set { _mailList = value; }
        }


    }
}
