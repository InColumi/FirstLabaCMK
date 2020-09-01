using System;
using SimpleNumbers;
namespace FirstLabaCMK
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowArray(SieveEratosthenes.GetSimpleNumbers(1000));
            Console.ReadKey();
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
