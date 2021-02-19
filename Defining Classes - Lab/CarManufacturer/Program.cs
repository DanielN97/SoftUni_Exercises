using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            List<Tire[]> tiresIndexes = new List<Tire[]>();

            string[] tiresCommands = Console.ReadLine().Split();

            while (tiresCommands[0] != "No")
            {
                Queue<string> queue = new Queue<string>(tiresCommands);

                Tire[] tires = new Tire[4];

                int counter = 0;

                while (queue.Count > 0)
                {
                    Tire tire = new Tire(int.Parse(queue.Dequeue()), double.Parse(queue.Dequeue()));

                    tires[counter] = tire;
                    counter++;
                }

                tiresIndexes.Add(tires);

                tiresCommands = Console.ReadLine().Split();
            }

            string[] enginesCommands = Console.ReadLine().Split();

            while (enginesCommands[0] != "Engines")
            {
                Engine engine = new Engine(int.Parse(enginesCommands[0]), double.Parse(enginesCommands[1]));

                engines.Add(engine);

                enginesCommands = Console.ReadLine().Split();
            }

            string[] carCommands = Console.ReadLine().Split();

            while (carCommands[0] != "Show")
            {
                Car car = new Car(carCommands[0], carCommands[1], int.Parse(carCommands[2]), double.Parse(carCommands[3]), double.Parse(carCommands[4]), engines[int.Parse(carCommands[5])], tiresIndexes[int.Parse(carCommands[6])]);

                cars.Add(car);

                carCommands = Console.ReadLine().Split();
            }

            foreach (Car currentCar in cars)
            {
                if (currentCar.Year >= 2017 && currentCar.Engine.HorsePower > 330 && currentCar.Tires.Sum(x => x.Pressure) > 9 && currentCar.Tires.Sum(x => x.Pressure) < 10)
                {
                    currentCar.Drive(0.2);

                    Console.WriteLine($"Make: {currentCar.Make}");
                    Console.WriteLine($"Model: {currentCar.Model}");
                    Console.WriteLine($"Year: {currentCar.Year}");
                    Console.WriteLine($"HorsePowers: {currentCar.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {currentCar.FuelQuantity}");

                }
            }
        }
    }
}
