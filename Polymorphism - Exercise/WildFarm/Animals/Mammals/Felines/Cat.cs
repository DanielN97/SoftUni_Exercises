using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        private const double BaseWeightModifier = 0.3;
        private static HashSet<string> аllowedFoods = new HashSet<string> { nameof(Meat), nameof(Vegetable) };

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, аllowedFoods, BaseWeightModifier, livingRegion, breed)
        {
        }

        public override string AskForFood()
        {
            return "Meow";
        }
    }
}
