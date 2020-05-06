using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class ShippingService 
    {
        private double weightPrice;

        public ShippingService(double price)
        {
            this.weightPrice = price;
        }

        public double GetShippingPrice(double weight)
        {
            return weightPrice * weight;
        }
    }
}
