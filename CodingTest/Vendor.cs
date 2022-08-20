using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CodingTest
{
    public enum ItemsAvailable
    {
        cola,
        chips,
        candy
    }
    abstract class Vendor
    {
        public string? Name { get; set; }
        public decimal Price { get; set; } 
        public int Id { get; set; } 

    }
}
