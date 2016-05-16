using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_and_Customer_Classes
{
    class Person
    {
        //Fields
        private string _name;
        private string _address;
        private string _telephone;

        //Constructor
        public Person()
        {
            _name = "";
            _address = "";
            _telephone = "";
        }

        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Address property
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        //Telephone property
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

    }
}
