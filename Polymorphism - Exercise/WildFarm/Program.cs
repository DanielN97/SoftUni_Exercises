using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();
                Animal animal = CreateAnimal(parts);
                animals.Add(animal);

                Console.WriteLine(animal.AskForFood());

                string[] foodInfo = Console.ReadLine().Split();
                Food food = CreateFood(foodInfo);

                try
                {
                    animal.Eat(food);
                }
                catch (InvalidOperationException exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
            }

            foreach (Animal currentAnimal in animals)
            {
                Console.WriteLine(currentAnimal);
            }
        }

        private static Food CreateFood(string[] foodInfo)
        {
            string type = foodInfo[0];
            int quantity = int.Parse(foodInfo[1]);

            Food food = null;

            if (type == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }
            else if (type == nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if (type == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }
            else if (type == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }

            return food;
        }

        private static Animal CreateAnimal(string[] parts)
        {
            string type = parts[0];

            Animal animal = null;

            string name = parts[1];
            double weight = double.Parse(parts[2]);

            if (type == nameof(Cat))
            {
                string livingRegion = parts[3];
                string breed = parts[4];

                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == nameof(Tiger))
            {
                string livingRegion = parts[3];
                string breed = parts[4];

                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else if (type == nameof(Owl))
            {
                double wingSize = double.Parse(parts[3]);

                animal = new Owl(name, weight, wingSize);
            }
            else if (type == nameof(Hen))
            {
                double wingSize = double.Parse(parts[3]);

                animal = new Hen(name, weight, wingSize);
            }
            else if (type == nameof(Dog))
            {
                string livingRegion = parts[3];

                animal = new Dog(name, weight, livingRegion);
            }
            else if (type == nameof(Mouse))
            {
                string livingRegion = parts[3];

                animal = new Mouse(name, weight, livingRegion);
            }

            return animal;
        }
    }
}
