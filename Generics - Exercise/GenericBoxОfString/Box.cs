using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxОfString
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {Value}";
        }
    }
}
