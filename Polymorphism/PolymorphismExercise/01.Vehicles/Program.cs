using System;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split();
            var carFuelQuantity = double.Parse(carInfo[1]);
            var carFuelConsumption = double.Parse(carInfo[2]);

            var truckInfo = Console.ReadLine().Split();
            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckFuelConsumption = double.Parse(truckInfo[2]);

            var car = new Car(carFuelQuantity, carFuelConsumption);
            var truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var cmd = Console.ReadLine().Split();
                var action = cmd[0];
                var vehicleType = cmd[1];
                if (action == "Drive")
                {
                    var distance = double.Parse(cmd[2]);
                    if (vehicleType == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Drive(distance);
                    }
                }
                else if (action == "Refuel")
                {
                    var fuel = double.Parse(cmd[2]);
                    if (vehicleType == "Car")
                    {
                        car.Refuel(fuel);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(fuel);
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
