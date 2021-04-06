using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        private const double BaseWeightModifier = 0.4;
        private static HashSet<string> аllowedFoods = new HashSet<string> { nameof(Meat) };

        public Dog(string name, double weight, string livingRegion) : base(name, weight, аllowedFoods, BaseWeightModifier, livingRegion)
        {
        }

        public override string AskForFood()
        {
            return "Woof!";
        }
    }
}
