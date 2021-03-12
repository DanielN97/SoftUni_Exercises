using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNames = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split();

            Func<List<string>, List<string>> listFilter = x => x;

            while (command[0] != "Party!")
            {
                string action = command[0];
                string criteria = command[1];
                string filter = command[2];

                if (criteria == "StartsWith")
                {
                    listFilter = x => x.Where(y => y.Substring(0, filter.Length) == filter).ToList();
                }
                else if (criteria == "EndsWith")
                {
                    listFilter = x => x.Where(y => y.Substring(y.Length - filter.Length) == filter).ToList();
                }
                else if (criteria == "Length")
                {
                    int length = int.Parse(filter);

                    listFilter = x => x.Where(y => y.Length == length).ToList();
                }

                listModifier(action, listFilter, inputNames);

                command = Console.ReadLine().Split();
            }

            if (inputNames.Count > 0)
            {
                Console.Write(String.Join(", ", inputNames));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static void listModifier(string action, Func<List<string>, List<string>> listFilter, List<string> names)
        {
            if (action == "Remove")
            {
                foreach (string name in listFilter(names))
                {
                    names.RemoveAll(x => x == name);
                }
            }
            else if (action == "Double")
            {
                foreach (string name in listFilter(names))
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (name == names[i])
                        {
                            names.Insert(i, name);
                            break;
                        }
                    }
                }
            }
        }
    }
}
