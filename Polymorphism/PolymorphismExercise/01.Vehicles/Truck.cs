using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public override double FuelConsumption { get => base.FuelConsumption + 1.6; set => base.FuelConsumption = value; }
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }
        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * 0.95);
        }
    }
}
