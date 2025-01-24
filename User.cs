using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP06
{
    internal abstract class User
    {
        public string? UserName { get; set; }
        public abstract Discount GetDiscount();

        
    }
}
