using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNames = Console.ReadLine().Split().ToList();

            List<string> filters = new List<string>();

            string[] command = Console.ReadLine().Split(';');

            while (command[0] != "Print")
            {
                if (command[0] == "Add filter")
                {
                    filters.Add(command[1] + " " + command[2]);
                }
                else if (command[0] == "Remove filter")
                {
                    filters.Remove(command[1] + " " + command[2]);
                }

                command = Console.ReadLine().Split(';');
            }

            foreach (string filter in filters)
            {
                string[] currentFilter = filter.Split();

                if (currentFilter[0] == "Starts")
                {
                    inputNames = inputNames.Where(x => !x.StartsWith(currentFilter[2])).ToList();
                }
                else if (currentFilter[0] == "Ends")
                {
                    inputNames = inputNames.Where(x => !x.EndsWith(currentFilter[2])).ToList();
                }
                else if (currentFilter[0] == "Length")
                {
                    inputNames = inputNames.Where(x => x.Length == int.Parse(currentFilter[1])).ToList();
                }
                else if (currentFilter[0] == "Contains")
                {
                    inputNames = inputNames.Where(x => !x.Contains(currentFilter[1])).ToList();
                }
            }

            Console.WriteLine(String.Join(" ", inputNames));
        }
    }
}
