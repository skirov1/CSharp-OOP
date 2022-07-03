using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Vehicle
    {
        public double FuelQuantity { get; set; }
        public virtual double FuelConsumption { get; set; }
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public void Drive(double distance)
        {
            if (this.FuelConsumption * distance <= this.FuelQuantity)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
        public virtual void Refuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }
    }
}
