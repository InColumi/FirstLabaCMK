using System;
using SimpleNumbers;
namespace FirstLabaCMK
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowArray(SieveEratosthenes.GetSimpleNumbers(-10));
            SieveEratosthenes.ShowSimpleNumbers(10);
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
