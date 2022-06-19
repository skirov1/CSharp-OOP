using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private double RaceMotorcycleDefaultFuelConsumption = 8;
        public override double FuelConsumption { get => RaceMotorcycleDefaultFuelConsumption; }

        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
}
