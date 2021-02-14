using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> dataBase = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!dataBase.ContainsKey(name))
                {
                    dataBase.Add(name, new List<decimal>());
                }

                dataBase[name].Add(grade);
            }

            foreach (var student in dataBase)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grades in student.Value)
                {
                    Console.Write($"{grades:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
