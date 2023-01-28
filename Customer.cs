using System;
using System.Collections.Generic;
using System.Text;

namespace RepairServiceQuote
{
    class Customer
    {
        //Fields to help build customer objs
        private string _name;
        private string _address;
        private string _phone;
        //TODO: consider adding a link to a car object
        //so that it is linked to the customer obj

        public Customer(string name, string address, string phone)
        {
            _name = name;
            _address = address;
            _phone = phone;
        }
        //name property- getter+setter
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //address property getter+setter
        public string Address
        {
            get { return _address; }
            set { _name = value; }
        }
        //phone property getter+setter
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

    }
}
