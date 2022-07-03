using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Vehicle
    {
        private double fuelQuantity;
        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set
            {
                {
                    if (value > this.FuelTankCapacity || value < 0)
                    {
                        this.fuelQuantity = 0;
                    }
                    this.fuelQuantity = value;
                }
            }
        }
        public virtual double FuelConsumption { get; set; }
        public double FuelTankCapacity { get; set; }
        public Vehicle(double fuelQuantity, double fuelConsumption, double fuelTankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.FuelTankCapacity = fuelTankCapacity;
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
            if (fuel > 0)
            {
                if (this.FuelQuantity + fuel > this.FuelTankCapacity)
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += fuel;
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }
    }
}
