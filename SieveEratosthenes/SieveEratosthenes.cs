using System;
using System.Collections.Generic;

namespace SimpleNumbers
{
    public class SieveEratosthenes
    {
        public static int[] GetSimpleNumbers(int endNumber)
        {
            if (IsCorrect(endNumber))
            {
                int sqrtFromEndNumber = (int)Math.Sqrt(endNumber);
                int[] numbers = new int[endNumber];
                FillArrayStartWithTwo(numbers);
                for (int i = 1; i < sqrtFromEndNumber; i++)
                {
                    if(numbers[i] != 0)
                    {
                        for (int j = i + 1; j < endNumber; j++)
                        {
                            if (numbers[j] != 0 && numbers[j] % numbers[i] == 0)
                            {
                                numbers[j] = 0;
                            }
                        }
                    }
                }
                DeleteZeroFrom(ref numbers);
                return numbers;
            }
            else
            {
                throw new Exception("Number must be more than zero!");
            }
        }

        private static bool IsCorrect(int number)
        {
            return number > 0;
        }

        private static void FillArrayStartWithTwo(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
                arr[i] = i + 1;
        }

        private static void DeleteZeroFrom(ref int[] numbers)
        {
            List<int> newNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] != 0)
                    newNumbers.Add(numbers[i]);
            numbers = newNumbers.ToArray();
        }
    }
}
