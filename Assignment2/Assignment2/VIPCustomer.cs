using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2
{
    internal class VIPCustomer : Customer
    {
        public string type { get; set; }

        public VIPCustomer() : base("name") { }

        public VIPCustomer(string name) : base(name)
        {
            _name = name;
        }

        public bool takeloan(double amount)
        {
            return false;
        }

        public override void PayBill(double amount)
        {
            throw new NotImplementedException();
        }
    }
}