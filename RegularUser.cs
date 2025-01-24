using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP06
{
    internal class RegularUser : User
    {
        public RegularUser(string name)
        {
            UserName = name;
        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
