using System;
using System.Collections.Generic;

namespace FirstLabaCMK
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowArray(SieveEratosthenes.GetSimpleNumbers(1000));
            Console.ReadKey();
        }

        class SieveEratosthenes
        {
            public static int[] GetSimpleNumbers(int endNumber)
            {
                if (CheckNumberOnPositive(endNumber))
                {
                    int[] numbers = new int[endNumber];
                    Fill(numbers);
                    int size = numbers.Length;
                    for (int i = 1; i < size; i++)
                    {
                        for (int j = i + 1; j < size; j++)
                        {
                            if (numbers[i] != 0 &&
                                numbers[j] % numbers[i] == 0)
                            {
                                numbers[j] = 0;
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

            private static bool CheckNumberOnPositive(int number) { return number > 0; }

            private static void Fill(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
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

        static void ShowArray(int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length - 1; i++)
                Console.Write(array[i] + ", ");
            Console.Write(array[array.Length - 1] + " ]");
        }
    }
}
