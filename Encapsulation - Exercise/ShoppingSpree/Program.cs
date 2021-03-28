using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            try
            {
                string[] peopleInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                foreach (string person in peopleInput)
                {
                    string[] personData = person.Split("=", StringSplitOptions.RemoveEmptyEntries);

                    Person newPerson = new Person(personData[0], decimal.Parse(personData[1]));

                    people.Add(personData[0], newPerson);
                }
            }
            catch (ArgumentException exeption)
            {
                Console.WriteLine(exeption.Message);
                return;
            }

            try
            {
                string[] productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                foreach (string product in productsInput)
                {
                    string[] productData = product.Split("=", StringSplitOptions.RemoveEmptyEntries);

                    Product newProduct = new Product(productData[0], decimal.Parse(productData[1]));

                    products.Add(productData[0], newProduct);
                }
            }
            catch (ArgumentException exeption)
            {
                Console.WriteLine(exeption.Message);
                return;
            }

            string[] purchases = Console.ReadLine().Split();

            while (purchases[0] != "END")
            {
                string name = purchases[0];
                string productName = purchases[1];

                Person person = people[name];
                Product product = products[productName];

                try
                {
                    person.Purchasing(product);
                }
                catch (InvalidOperationException exeption)
                {
                    Console.WriteLine(exeption.Message);
                }

                purchases = Console.ReadLine().Split();
            }

            foreach (Person person in people.Values)
            {
                Console.WriteLine(person);
            }
        }
    }
}
