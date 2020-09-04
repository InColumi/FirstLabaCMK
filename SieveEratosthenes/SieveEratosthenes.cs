using System;
using System.Collections.Generic;

namespace SimpleNumbers
{
    public class SieveEratosthenes
    {
        public static int[] GetSimpleNumbers(int endNumber)
        {
            IsCorrectNumber(endNumber);
            List<int> numbers = new List<int>();
            for (int i = 2; i <= endNumber; i++)
            {
                if (IsSimple(i))
                {
                    numbers.Add(i);
                }
            }
            return numbers.ToArray();
        }

        public static void ShowSimpleNumbers(int endNumber)
        {
            IsCorrectNumber(endNumber);
            for (int i = 2; i <= endNumber; i++)
            {
                if (IsSimple(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        private static bool IsSimple(int number)
        {
            for (int i = 2; i <= (int)Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsCorrectNumber(int number)
        {
            if (number > 1)
            {
                return true;
            }
            throw new Exception("Number must be more than one!");
        }
    }
}
