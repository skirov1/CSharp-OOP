using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private double DefaultCarFuelConsumption = 3;
        public override double FuelConsumption { get => DefaultCarFuelConsumption; }

        public Car(int horsePower, double fuel) : base (horsePower, fuel)
        {

        }

    }
}
