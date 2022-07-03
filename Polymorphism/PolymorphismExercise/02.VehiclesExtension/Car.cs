using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        public override double FuelConsumption { get => base.FuelConsumption + 0.9; set => base.FuelConsumption = value; }

        public Car(double fuelQuantity, double fuelConsumption, double fuelTankCapacity) : base(fuelQuantity, fuelConsumption, fuelTankCapacity)
        {

        }
    }
}
