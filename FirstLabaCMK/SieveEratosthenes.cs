using System;
using System.Collections.Generic;

namespace FirstLabaCMK
{
    public static class SieveEratosthenes
    {
        public static int[] GetPrimeNumbers(int endNumber)
        {
            IsCorrectNumber(endNumber);
            List<int> numbers = new List<int>();
            for (int i = 2; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }
            return numbers.ToArray();
        }

        public static void ShowPrimeNumbers(int endNumber)
        {
            IsCorrectNumber(endNumber);
            for (int i = 2; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static bool IsPrime(int number)
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
