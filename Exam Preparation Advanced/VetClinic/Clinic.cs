using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private Dictionary<string, Pet> data;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new Dictionary<string, Pet>();
        }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Pet pet)
        {
            if (data.Count < Capacity)
            {
                data[pet.Name] = pet;
            }
        }

        public bool Remove(string name)
        {
            if (data.ContainsKey(name))
            {
                data.Remove(name);
                return true;
            }

            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            if (data.ContainsKey(name) && data[name].Owner == owner)
            {
                return data[name];
            }
            return null;
        }

        public Pet GetOldestPet()
        {
            Pet pet = data.Values.First();

            foreach (var currentPet in data)
            {
                if (currentPet.Value.Age > pet.Age)
                {
                    pet = currentPet.Value;
                }
            }

            return pet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");

            foreach (var patient in data)
            {
                sb.AppendLine($"Pet {patient.Value.Name} with owner: {patient.Value.Owner}");
            }

            return sb.ToString();
        }
    }
}
