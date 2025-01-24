﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP06
{
    internal class PercentageDiscount : Discount
    {
        private decimal percentage;

        public PercentageDiscount(decimal percentage) 
        {
            this.percentage = percentage;
            Name = "Percentage Discount";

        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (percentage /100);
        }
    }
}
