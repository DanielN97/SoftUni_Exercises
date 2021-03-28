using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get => name;
            private set
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, "Name cannot be empty");

                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                Validator.ThrowIfNumberIsNegative(value, "Money cannot be negative");

                money = value;
            }
        }

        public void Purchasing(Product product)
        {
            if (Money < product.Cost)
            {
                throw new InvalidOperationException($"{Name} can't afford {product.Name}");
            }
            
            bagOfProducts.Add(product);
            Money -= product.Cost;

            Console.WriteLine($"{Name} bought {product.Name}");
        }

        public override string ToString()
        {
            if (bagOfProducts.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }

            return $"{Name} - {String.Join(", ", bagOfProducts.Select(x => x.Name))}";
        }
    }
}
