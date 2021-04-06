using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        private const double BaseWeightModifier = 0.25;
        private static HashSet<string> аllowedFoods = new HashSet<string> { nameof(Meat) };

        public Owl(string name, double weight, double wingSize) : base(name, weight, аllowedFoods, BaseWeightModifier, wingSize)
        {
        }

        public override string AskForFood()
        {
            return "Hoot Hoot";
        }
    }
}
