using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        public string Status { get; set; }
        public override double FuelConsumption
        {
            get
            {
                {
                    if (this.Status == "Full")
                    {
                        return base.FuelConsumption + 1.4;
                    }
                    return base.FuelConsumption;
                }

            }
            set => base.FuelConsumption = value;
        }
        public Bus(double fuelQuantity, double fuelConsumption, double fuelTankCapacity) : base(fuelQuantity, fuelConsumption, fuelTankCapacity)
        {

        }
    }
}
