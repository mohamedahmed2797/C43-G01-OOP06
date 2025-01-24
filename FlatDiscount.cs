using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP06
{
    internal class FlatDiscount : Discount
    {
        private decimal flatAmount;
        public FlatDiscount(decimal flatAmount) : base()
        {
            this.flatAmount = flatAmount;
            Name = "Flat Amount";    
             
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return flatAmount * Math.Min(quantity, 1);
        }
    }
}
