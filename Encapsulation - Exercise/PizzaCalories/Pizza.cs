using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private Dough pizzaDough;

    public Pizza()
    {
        Toppings = new List<Topping>();
    }

    public Pizza(string name)
        : this()
    {
        Name = name;
    }

    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            if (value.Length < 1 || value.Length > 15)
            {
                throw new Exception("Pizza name should be between 1 and 15 symbols.");
            }

            name = value;
        }
    }

    public Dough PizzaDough
    {
        get { return pizzaDough; }
        set { pizzaDough = value; }
    }

    public List<Topping> Toppings { get; }

    public void Add(Topping topping)
    {
        if (Toppings.Count >= 10)
        {
            throw new Exception("Number of toppings should be in range [0..10].");
        }

        Toppings.Add(topping);
    }

    public double PizzaCalories()
    {
        double totalToppingCalories = Toppings.Select(c => c.ToppingCalories()).Sum();

        return PizzaDough.DoughCalories() + totalToppingCalories;
    }
}