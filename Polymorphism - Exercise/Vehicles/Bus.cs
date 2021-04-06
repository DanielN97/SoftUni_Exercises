using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double IncreasedFuelConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, IncreasedFuelConsumption)
        {
        }

        public void TurnOnAirConditioner()
        {
            base.IncreasedFuelConsumption = IncreasedFuelConsumption;
        }
        
        public void TurnOffAirConditioner()
        {
            base.IncreasedFuelConsumption = 0;
        }
    }
}
