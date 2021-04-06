using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> raidTeam = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            while (raidTeam.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                BaseHero hero = CreateHero(type, name);

                if (hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                raidTeam.Add(hero);
            }

            int bossHealthPoints = int.Parse(Console.ReadLine());

            foreach (BaseHero currenthero in raidTeam)
            {
                Console.WriteLine(currenthero.CastAbility());
            }

            if (raidTeam.Sum(x => x.Power) >= bossHealthPoints)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static BaseHero CreateHero(string type, string name)
        {
            BaseHero hero = null;

            switch (type)
            {
                case nameof(Druid):
                    hero = new Druid(name);
                    break;
                case nameof(Paladin):
                    hero = new Paladin(name);
                    break;
                case nameof(Rogue):
                    hero = new Rogue(name);
                    break;
                case nameof(Warrior):
                    hero = new Warrior(name);
                    break;
                default:
                    break;
            }

            return hero;
        }
    }
}
