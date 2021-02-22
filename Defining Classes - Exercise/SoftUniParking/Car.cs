using System;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            string output = $"Make: {Make}" + Environment.NewLine;
            output += $"Model: {Model}" + Environment.NewLine;
            output += $"HorsePower: {HorsePower}" + Environment.NewLine;
            output += $"RegistrationNumber: {RegistrationNumber}";

            return output;
        }
    }
}
