using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private double cakeGrams = 250;
        private double cakeCalories = 250;
        private decimal cakePrice = 5m;

        public override double Grams { get => this.cakeGrams; }
        public override double Calories { get => this.cakeCalories; }
        public override decimal Price { get => this.cakePrice; }
        public Cake(string name) : base(name, 0, 0, 0)
        {
            
        }
    }
}
