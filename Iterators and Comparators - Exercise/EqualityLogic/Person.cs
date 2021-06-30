  using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person other)
        {
            if (name.CompareTo(other.name) != 0)
            {
                return name.CompareTo(other.name);
            }

            return age.CompareTo(other.age);
        }

        public override bool Equals(object obj)
        {
            return GetHashCode().Equals(obj.GetHashCode());
        }

        public override int GetHashCode()
        {
            int hashName = name.GetHashCode();
            int hashAge = age.GetHashCode();

            return hashName + hashAge;
        }
    }
}
