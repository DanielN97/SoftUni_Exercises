using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = CreateVehicle();
            Vehicle truck = CreateVehicle();
            Vehicle bus = CreateVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                string action = command[0];
                string vehicle = command[1];
                double parameter = double.Parse(command[2]);

                try
                {
                    if (vehicle == nameof(Car))
                    {
                        ProcessCommand(car, action, parameter);
                    }
                    else if (vehicle == nameof(Truck))
                    {
                        ProcessCommand(truck, action, parameter);
                    }
                    else if (vehicle == nameof(Bus))
                    {
                        ProcessCommand(bus, action, parameter);
                    }
                }
                catch (Exception exeption) when(exeption is InvalidOperationException || exeption is ArgumentException)
                {
                    Console.WriteLine(exeption.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ProcessCommand(Vehicle vehicle, string action, double parameter)
        {
            if (action == "Drive")
            {
                vehicle.Drive(parameter);
            }
            else if (action == "Refuel")
            {
                vehicle.Refueling(parameter);
            }
            else if (action == "DriveEmpty")
            {
                ((Bus)vehicle).TurnOffAirConditioner();

                vehicle.Drive(parameter);

                ((Bus)vehicle).TurnOnAirConditioner();
            }
        }

        private static Vehicle CreateVehicle()
        {
            string[] carData = Console.ReadLine().Split();

            string type = carData[0];
            double fuelQuantity = double.Parse(carData[1]);
            double fuelConsumption = double.Parse(carData[2]);
            double tankCapacity = double.Parse(carData[3]);

            Vehicle vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }

            return vehicle;
        }
    }
}
