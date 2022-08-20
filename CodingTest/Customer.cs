using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Customer
    {
        private decimal money;
        public decimal Money { get { return money; } set { money = value; } }
        public List<Vendor> customerProductList = new List<Vendor>();

    }
}
