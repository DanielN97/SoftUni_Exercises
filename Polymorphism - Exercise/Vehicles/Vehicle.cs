using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double increasedFuelConsumption)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            IncreasedFuelConsumption = increasedFuelConsumption;
        }

        protected double IncreasedFuelConsumption { get; set; }
        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }

            }
        }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }

        public void Drive(double distance)
        {
            if (FuelQuantity < distance * (FuelConsumption + IncreasedFuelConsumption))
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= distance * (FuelConsumption + IncreasedFuelConsumption);

            Console.WriteLine($"{GetType().Name} travelled {distance} km");
        }
        public virtual void Refueling(double refuelAmmount)
        {
            if (refuelAmmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (FuelQuantity + refuelAmmount > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {refuelAmmount} fuel in the tank");
            }

            FuelQuantity += refuelAmmount;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
