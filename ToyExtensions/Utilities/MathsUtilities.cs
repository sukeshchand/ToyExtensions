using System;
using System.Collections.Generic;

namespace Toy.Extensions.Utilities
{
    public static class MathsUtilities
    {
        public static List<long> GetSumOfPowerOfTwo(long n)
        {
            var reminders = new List<int>();
            var powerOfTwo = new List<long>();
            while (n > 0)
            {
                reminders.Add((int)n % 2);
                n = n / 2;
            }
            for (var i = 0; i < reminders.Count; i++)
            {
                if (reminders[i] == 1)
                {
                    powerOfTwo.Add((long)Math.Pow(2, i));
                }
            }
            return powerOfTwo;
        }
    }
}
