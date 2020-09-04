using System;

namespace FirstLabaCMK
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowArray(SieveEratosthenes.GetPrimeNumbers(10));
            //SieveEratosthenes.ShowPrimeNumbers(10);
            //Console.WriteLine(Converter.GetNumberFromDecimalToBinary(33));

            Console.WriteLine(BinaryPow.GetNumber(33, 9, 5));
            //Console.WriteLine(3 % 2 + 4 % 2);
            //Console.WriteLine((3 + 4) % 2);

            Console.ReadKey();
        }
        static void ShowArray(int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length - 1; i++)
                Console.Write(array[i] + ", ");
            Console.WriteLine(array[array.Length - 1] + " ]");
        }
    }
}
