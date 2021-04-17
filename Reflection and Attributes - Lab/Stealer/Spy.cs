using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string name, params string[] fields)
        {
            Type type = Type.GetType(name);

            FieldInfo[] allFields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            object classInstance = Activator.CreateInstance(type);

            sb.AppendLine($"Class under investigation: {name}");  


            foreach (var field in allFields.Where(x => fields.Contains(x.Name)))
            {
                sb.AppendLine($"{field} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
