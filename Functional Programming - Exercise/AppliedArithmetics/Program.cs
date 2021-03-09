using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                Action<int[]> printing = x => Console.WriteLine(String.Join(" ", numbers));

                if (command == "print")
                {
                    printing(numbers);
                }
                else
                {
                    Func<int, int> action = GetAction(command);
                    numbers = numbers.Select(action).ToArray();
                }

                command = Console.ReadLine();
            }
        }

        static Func<int, int> GetAction(string command)
        {
            Func<int, int> actions = x => x;

            if (command == "add")
            {
                actions = x => x + 1;
            }
            else if (command == "multiply")
            {
                actions = x => x * 2;
            }
            else if (command == "subtract")
            {
                actions = x => x - 1;
            }

            return actions;
        }
    }
}
