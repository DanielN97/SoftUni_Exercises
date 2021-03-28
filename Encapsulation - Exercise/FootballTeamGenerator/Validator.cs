using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public static class Validator
    {
        public static void ThrowIfNumberNotInRange(int min, int max, int number, string message)
        {
            if (number < min || number > max)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ThrowIfInvalidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("A name should not be empty.");
            }
        }
    }
}
