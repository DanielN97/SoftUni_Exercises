using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Speed_Racing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split();

                Car car = new Car(carData[0], double.Parse(carData[1]), double.Parse(carData[2]));
                cars.Add(car);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string model = command[1];
                double distance = double.Parse(command[2]);

                Car car = cars.FirstOrDefault(x => x.Model == model);

                car.Drive(distance);

                command = Console.ReadLine().Split();
            }

            foreach (Car currentCar in cars)
            {
                Console.WriteLine($"{currentCar.Model} {currentCar.FuelAmount:f2} {currentCar.TravelledDistance}");
            }
        }
    }
}
