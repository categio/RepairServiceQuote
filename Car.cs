using System;
using System.Collections.Generic;
using System.Text;

namespace RepairServiceQuote
{
    class Car
    {
        //Fields to create class Car objs
        private string _make;
        private string _model;
        private int _year;
        
        //Constructor for class Car
        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        //make property getter+setter
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        //model property getter+setter
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        //year property getter+setter
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
    }
}
