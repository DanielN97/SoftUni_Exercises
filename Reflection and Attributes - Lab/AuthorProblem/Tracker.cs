using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type classType = typeof(StartUp);

            MethodInfo[] methodsInfo = classType.GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);

            foreach (MethodInfo method in methodsInfo)
            {
                if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);

                    foreach (AuthorAttribute attribute in attributes)
                    {
                        Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                    }
                }
            }
        }
    }
}
