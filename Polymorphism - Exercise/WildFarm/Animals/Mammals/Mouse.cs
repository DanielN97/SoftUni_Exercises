using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        private const double BaseWeightModifier = 0.1;
        private static HashSet<string> аllowedFoods = new HashSet<string> { nameof(Fruit), nameof(Vegetable) };

        public Mouse(string name, double weight, string livingRegion) : base(name, weight, аllowedFoods, BaseWeightModifier, livingRegion)
        {
        }

        public override string AskForFood()
        {
            return "Squeak";
        }
    }
}
