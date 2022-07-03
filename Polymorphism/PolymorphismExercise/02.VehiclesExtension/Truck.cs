using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        public override double FuelConsumption { get => base.FuelConsumption + 1.6; set => base.FuelConsumption = value; }
        public Truck(double fuelQuantity, double fuelConsumption, double fuelTankCapacity) : base(fuelQuantity, fuelConsumption, fuelTankCapacity)
        {

        }
        public override void Refuel(double fuel)
        {
            if (fuel > 0)
            {
                var truckFuel = fuel * 0.95;
                if (this.FuelQuantity + truckFuel > this.FuelTankCapacity)
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += truckFuel;
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }
    }
}
