using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP06
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount() 
        {
            Name = "BuyOneGetOneDiscount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity <= 0)
            {
                return 0;
            }
            return (price /2) * (quantity /2);
        }
    }

}
