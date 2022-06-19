using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private double CoffeeMilliliters = 50;
        private decimal CoffeePrice = 3.50m;

        public override double Milliliters { get => this.CoffeeMilliliters; }
        public override decimal Price { get => this.CoffeePrice; }
        public double Caffeine { get; set; }
        public Coffee(string name, double caffeine) : base(name, 0, 0)
        {
            this.Caffeine = caffeine;
        }
    }
}
