using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        private const double BaseWeightModifier = 0.35;
        private static HashSet<string> аllowedFoods = new HashSet<string> { nameof(Meat), nameof(Fruit), nameof(Seeds), nameof(Vegetable) };

        public Hen(string name, double weight, double wingSize) : base(name, weight, аllowedFoods, BaseWeightModifier, wingSize)
        {
        }

        public override string AskForFood()
        {
            return "Cluck";
        }
    }
}
