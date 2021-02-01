using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> dictionary = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string student = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!dictionary.ContainsKey(student))
                {
                    dictionary.Add(student, new List<decimal>() { grade });
                }
                else
                {
                    dictionary[student].Add(grade);
                }
            }

            foreach (var student in dictionary)
            {
                StringBuilder allGrades = new StringBuilder();

                for (int i = 0; i < student.Value.Count; i++)
                {
                    allGrades.Append($"{student.Value[i]:f2} ");
                }

                Console.WriteLine($"{student.Key} -> {allGrades}(avg: {student.Value.Average():f2})");
            }
        }
    }
}
