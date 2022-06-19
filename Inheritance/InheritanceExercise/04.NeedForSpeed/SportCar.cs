using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private double SportCarDefaultFuelConsumption = 10;
        public override double FuelConsumption { get => SportCarDefaultFuelConsumption; }
        public SportCar(int horsePower, double fuel) : base (horsePower, fuel)
        {
            
        }
       
    }
}
