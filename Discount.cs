using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP06
{
    internal abstract class Discount 
    {
        public string? Name { get; set; }

        private Discount(string name) 
        {
        Name = name;
        }

        protected Discount()
        {
        }

        public abstract decimal CalculateDiscount(decimal price , int quantity);
    }
    
}
