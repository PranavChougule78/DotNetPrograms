using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstExample
{
    public class Address
    {
        public string _addressLine1;
        public string _addressLine2;
        public string _addressLine3;
        public string _addressLine4;
        public string _addressLine5;

        public Address(string addressLine1,string addressline2,string addressLine3,string addressline4,string addressline5)
        {
            this._addressLine1 = addressLine1;
            this._addressLine2 = addressline2;
            this._addressLine3 = addressLine3;
            this._addressLine4 = addressline4;
            this._addressLine5 = addressline5;
       
        }

        public Address(Address address)
        {
            _addressLine1 = address._addressLine1;
            _addressLine2 = address._addressLine2;
            _addressLine3 = address._addressLine3;
            _addressLine4 = address._addressLine4;
            _addressLine5 = address._addressLine5;
        }

        public void PrintAddress()
        {
            Console.WriteLine("My address is" + _addressLine1 + "" + _addressLine2 + "" + _addressLine3 + "" + _addressLine4 + "" +_addressLine5);
        }

        public void ShowAddress()
        {
            PrintAddress();
        }
    }
}
