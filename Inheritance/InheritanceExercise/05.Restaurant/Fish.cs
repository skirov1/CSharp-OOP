using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Fish : MainDish
    {
        private double fishGrams = 22;
        public override double Grams { get => this.fishGrams; }
        public Fish(string name, decimal price) : base(name, price, 0)
        {

        }
    }
}
