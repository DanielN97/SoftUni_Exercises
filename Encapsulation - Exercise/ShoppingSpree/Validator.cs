using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string input, string message)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException(message);
            }
        }

        public static void ThrowIfNumberIsNegative(decimal number, string message)
        {
            if (number < 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
