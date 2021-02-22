using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;
        private List<Car> cars;

        public Parking(int capacity)
        {
            cars = new List<Car>();

            this.capacity = capacity;
        }

        public int Count
        {
            get
            {
                return cars.Count;
            }
        }

        public string AddCar(Car car)
        {
            string messege = String.Empty;

            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                messege = "Car with that registration number, already exists!";
            }
            else if (cars.Count >= capacity)
            {
                messege = "Parking is full!";
            }
            else
            {
                cars.Add(car);

                messege = $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }

            return messege;
        }

        public string RemoveCar(string registrationNumber)
        {
            bool found = false;

            string messege = String.Empty;

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].RegistrationNumber == registrationNumber)
                {
                    messege = $"Successfully removed {cars[i].RegistrationNumber}";

                    found = true;

                    cars.RemoveAt(i);

                    break;
                }
            }

            if (!found)
            {
                messege = "Car with that registration number, doesn't exist!";
            }

            return messege;
        }

        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string regNum in registrationNumbers)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].RegistrationNumber == regNum)
                    {
                        cars.RemoveAt(i);

                        break;
                    }
                }
            }
        }
    }
}
