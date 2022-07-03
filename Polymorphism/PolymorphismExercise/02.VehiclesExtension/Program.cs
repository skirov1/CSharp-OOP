using System;

namespace VehiclesExtension
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split();
            var carFuelQuantity = double.Parse(carInfo[1]);
            var carFuelConsumption = double.Parse(carInfo[2]);
            var carFuelTankCapacity = double.Parse(carInfo[3]);

            var truckInfo = Console.ReadLine().Split();
            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckFuelConsumption = double.Parse(truckInfo[2]);
            var truckFuelTankCapacity = double.Parse(truckInfo[3]);

            var busInfo = Console.ReadLine().Split();
            var busFuelQuantity = double.Parse(busInfo[1]);
            var busFuelConsumption = double.Parse(busInfo[2]);
            var busFuelTankCapacity = double.Parse(busInfo[3]);

            var car = new Car(carFuelQuantity, carFuelConsumption, carFuelTankCapacity);
            var truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckFuelTankCapacity);
            var bus = new Bus(busFuelQuantity, busFuelConsumption, busFuelTankCapacity);

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
                    else if (vehicleType == "Bus")
                    {
                        bus.Status = "Full";
                        bus.Drive(distance);
                    }
                }
                else if (action == "DriveEmpty")
                {
                    var distance = double.Parse(cmd[2]);
                    bus.Status = "Empty";
                    bus.Drive(distance);
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
                    else if (vehicleType == "Bus")
                    {
                        bus.Refuel(fuel);
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
