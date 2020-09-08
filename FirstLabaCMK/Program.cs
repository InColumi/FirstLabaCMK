﻿using System;
using System.Numerics;
using System.Security.Cryptography;

namespace FirstLabaCMK
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowArray(SieveEratosthenes.GetPrimeNumbers(10));
            //SieveEratosthenes.ShowPrimeNumbers(1729);
            //Console.WriteLine(Converter.GetNumberFromDecimalToBinary(33));

            //Console.WriteLine(BinaryPow.GetNumber(1920, 1021, 3551));
            //Console.WriteLine(BinaryPow.GetNumber(1805, 1021, 3551));
            //Console.WriteLine(BinaryPow.GetNumber(0013, 1021, 3551));

            //Console.WriteLine(MillerRabin.IsPrimeNumber(907, 999));
            int n = 15;
            MillerRabin.ShowHowInTask(n, 1, 2);
            MillerRabin.ShowHowInTask(n, 1, 3);
            MillerRabin.ShowHowInTask(n, 1, 5);
            MillerRabin.ShowHowInTask(n, 1, 7);

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
