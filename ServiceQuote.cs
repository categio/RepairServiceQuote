using System;
using System.Collections.Generic;
using System.Text;

namespace RepairServiceQuote
{
    class ServiceQuote
    {
        //Fields to build a ServiceQuote obj
        private decimal _partsCharges;
        private decimal _laborCharges;
        private decimal _taxRate;

        public ServiceQuote(decimal partsCharges, decimal laborCharges, decimal taxRate)
        {
            _partsCharges = partsCharges;
            _laborCharges = laborCharges;
            _taxRate = taxRate;
        }
        //PartsCharges property gettter+setter
        public decimal PartsCharges
        {
            get { return _partsCharges ; }
            set { _partsCharges = value; }
        }
        //PartsCharges property gettter+setter
        public decimal laborCharges
        {
            get { return _laborCharges; }
            set { _laborCharges = value; }
        }
        //PartsCharges property gettter+setter
        public decimal taxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }
        //SalesTax property (read-only)
        public decimal SalesTax
        {
            get { return _partsCharges* _taxRate; }
        }
        //Total charges propert (read-only)
        public decimal TotalCharges
        {
            get { return _partsCharges + _laborCharges + (_partsCharges * _taxRate); }
        }
    }
}
