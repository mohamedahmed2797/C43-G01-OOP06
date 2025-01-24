using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP06
{
    internal class GuestUser: User
    {
        public GuestUser(string name) 
        {
            UserName = name;
        }
        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
