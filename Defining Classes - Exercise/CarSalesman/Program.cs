using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(engineData[0], int.Parse(engineData[1]));

                if (engineData.Length == 3)
                {
                    if (char.IsDigit(engineData[2][0]))
                    {
                        engine.Displacement = engineData[2];
                    }
                    else if (char.IsLetter(engineData[2][0]))
                    {
                        engine.Efficiency = engineData[2];
                    }
                }
                else if (engineData.Length == 4)
                {
                    engine.Displacement = engineData[2];
                    engine.Efficiency = engineData[3];
                }

                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(carData[0], engines.Find(x => x.Model == carData[1]));

                if (carData.Length == 3)
                {
                    if (char.IsDigit(carData[2][0]))
                    {
                        car.Weight = carData[2];
                    }
                    else if (char.IsLetter(carData[2][0]))
                    {
                        car.Color = carData[2];
                    }
                }
                else if (carData.Length == 4)
                {
                    car.Weight = carData[2];
                    car.Color = carData[3];
                }

                cars.Add(car);
            }

            foreach (Car currentCar in cars)
            {
                Console.WriteLine($"{currentCar.Model}:");
                Console.WriteLine($"  {currentCar.Engine.Model}:");
                Console.WriteLine($"    Power: {currentCar.Engine.Power}");
                Console.WriteLine($"    Displacement: {currentCar.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {currentCar.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {currentCar.Weight}");
                Console.WriteLine($"  Color: {currentCar.Color}");
            }
        }
    }
}
