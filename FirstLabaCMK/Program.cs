using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace FirstLabaCMK
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Laba123

            //ShowArray(SieveEratosthenes.GetPrimeNumbers(10));
            //SieveEratosthenes.ShowPrimeNumbers(1729);

            //foreach (var item in Converter.GetNumberFromDecimalToBinary(33))
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine(BinaryPow.GetNumber(1920, 1021, 3551));
            //Console.WriteLine(BinaryPow.GetNumber(1805, 1021, 3551));
            //Console.WriteLine(BinaryPow.GetNumber(0013, 1021, 3551));

            //Console.WriteLine(MillerRabin.IsPrimeNumber(907, 999));

            //int n = 15;
            //MillerRabin.ShowHowInTask(n, 1, 2);
            //MillerRabin.ShowHowInTask(n, 1, 3);
            //MillerRabin.ShowHowInTask(n, 1, 5);
            //MillerRabin.ShowHowInTask(n, 1, 7);
            #endregion
            #region Laba4

            Random rand = new Random();
            string alphabet = GetAlphaBet();
            Console.WriteLine(alphabet);
            
            int p; // простое число
            int q; // число по исловию q < p - 1  rand.Next(1, p);
            int a; // секретное числое абонента А из интервала (1, p- 1) rand.Next(1, p);
            int r; // секретное числое абонента B из интервала (1, p- 1) rand.Next(1, p);
            int h; // Участник A выбирает свой секретный ключ a,
                   // вычисляет величину (h = q^a mod p) и пересылает информацию участнику B
            int c1; // Участник B выбирает свой ключ r,
                    // вычисляет величину (с1 = q^r mod p) и отправляет r, C1 участнику A
            int c2; // Участник A, получив величины r и C1,
                    // зашифровывает информацию M по формуле (С2 = M * h^r mod p)
                    // и отсылает ее участнику B криптотекст С (с1, с2);
            p = 23;
            q = rand.Next(1, p); 
            // A пересылает(h) B
            a = rand.Next(1, p); 
            h = BinaryPow.GetNumber(q, a, p);
            Console.WriteLine($"A пересылает(h = {h}) B");

            
            // B пересылает(r, c1) A
            r = rand.Next(1, p); 
            c1 = BinaryPow.GetNumber(q, r, p);
            Console.WriteLine($"B пересылает(r = {r}, c1 = {c1}) A");
            // A шифрует
            int M = 7;
            c2 = MathMethods.GetModulo(M * BinaryPow.GetNumber(h, r, p), p);
            Console.WriteLine($"A шифрует M = {M} и пересылает(c1 = {c1}, c2 = {c2})");
            // B дешифрует
            int D;
            //D =
            //    Console.WriteLine($"B дешифрует");
            #endregion

            Console.ReadKey();
        }

        /// <summary>
        /// Возвращает алфавит
        /// </summary>
        /// <param name="startIndexAscii">начальное число в таблице Ascii</param>
        /// <param name="endIndexAscii">конечное число в таблице Ascii</param>
        /// <returns>алфавит в строке</returns>
        static string GetAlphaBet(int startIndexAscii = 65, int endIndexAscii = 90)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = startIndexAscii; i <= endIndexAscii; i++)
            {
                stringBuilder.Append((char)i);
            }
            return stringBuilder.ToString();
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
