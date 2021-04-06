using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        private const double BaseWeightModifier = 1;
        private static HashSet<string> аllowedFoods = new HashSet<string> { nameof(Meat) };

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, аllowedFoods, BaseWeightModifier, livingRegion, breed)
        {
        }

        public override string AskForFood()
        {
            return "ROAR!!!";
        }
    }
}
