using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Products : Vendor
    {
        public static Products Cola = new Products { Name = "cola", Price = 1.0M, Id = 1};
        public static Products Chips = new Products { Name = "Chips", Price = 0.5M, Id = 2 };
        public static Products Candy = new Products { Name = "Candy", Price = 0.65M, Id = 3 };
    }
}
