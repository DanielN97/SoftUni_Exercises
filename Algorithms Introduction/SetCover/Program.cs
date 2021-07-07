using System;
using System.Collections.Generic;
using System.Linq;

namespace SetCover
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputUniverse = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] universe = inputUniverse.Skip(1).Select(int.Parse).ToArray();

            string[] inputNumberOfSets = Console.ReadLine().Split();
            int numberOfSets = int.Parse(inputNumberOfSets[3]);

            List<int[]> sets = new List<int[]>();

            for (int i = 0; i < numberOfSets; i++)
            {
                sets.Add(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            }

            List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList());
            Console.WriteLine($"Sets to take ({selectedSets.Count}):");

            foreach (int[] set in selectedSets)
            {
                Console.WriteLine($"{{ {string.Join(", ", set)} }}");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> selectedSets = new List<int[]>();

            while (universe.Count > 0)
            {
                int[] currentSet = sets.OrderByDescending(x => x.Count(universe.Contains)).First();

                selectedSets.Add(currentSet);

                sets.Remove(currentSet);

                foreach (int item in currentSet)
                {
                    universe.Remove(item);
                }
            }

            return selectedSets;
        }
    }
}
