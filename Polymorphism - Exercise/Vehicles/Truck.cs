using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double IncreasedFuelConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, IncreasedFuelConsumption)
        {
        }

        public override void Refueling(double refuelAmmount)
        {
            if (refuelAmmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (FuelQuantity + refuelAmmount > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {refuelAmmount} fuel in the tank");
            }

            FuelQuantity += refuelAmmount * 0.95;
        }
    }
}
