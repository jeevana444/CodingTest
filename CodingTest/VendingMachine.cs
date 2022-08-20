using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class VendingMachine
    {
        public decimal InsertedCoin { get; set; } = 0;

        public void InsertCoin(decimal money)
        {
            InsertedCoin += money;
        }

        public char DispenseProduct(char id)
        {
            return id;
        }
    }
}
