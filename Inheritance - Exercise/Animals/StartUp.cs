using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();

            while (type != "Beast!")
            {
                string[] animalInfo = Console.ReadLine().Split();

                if (int.Parse(animalInfo[1]) < 0 || string.IsNullOrEmpty(animalInfo[2]) || string.IsNullOrEmpty(animalInfo[0]))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (type == "Cat")
                {
                    Cat cat = new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);

                    Console.WriteLine(cat);
                    Console.WriteLine(cat.ProduceSound());
                }
                else if (type == "Dog")
                {
                    Dog dog = new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);

                    Console.WriteLine(dog);
                    Console.WriteLine(dog.ProduceSound());
                }
                else if (type == "Frog")
                {
                    Frog frog = new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);

                    Console.WriteLine(frog);
                    Console.WriteLine(frog.ProduceSound());
                }
                else if (type == "Kitten")
                {
                    Kitten kitten = new Kitten(animalInfo[0], int.Parse(animalInfo[1]));

                    Console.WriteLine(kitten);
                    Console.WriteLine(kitten.ProduceSound());
                }
                else if (type == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(animalInfo[0], int.Parse(animalInfo[1]));

                    Console.WriteLine(tomcat);
                    Console.WriteLine(tomcat.ProduceSound());
                }

                type = Console.ReadLine();
            }
        }
    }
}
