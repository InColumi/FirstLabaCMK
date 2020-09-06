using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabaCMK
{
    public static class MillerRabin
    {
        private static Random _rand = new Random();
        
        public static void IsPrimeNumber(int number)
        {
            int t = 1;
            int randNumber = _rand.Next(1, number);
            if (Cripto.GetGcd(randNumber, number) != 1)
            {
                Console.WriteLine($"{number} - is composite");
            }
            else
            {
                int y0 = BinaryPow.GetNumber(randNumber, t, number);
                if (y0 == 1 || y0 == -1)
                {
                    Console.WriteLine($"{number} - is prime");
                }
                else
                {
                    int yj;
                    for (int i = 1; i < randNumber; i++)
                    {
                        yj = y0 * y0;
                        if (yj == 1 || yj == -1)
                        {

                        }
                    }
                }
            }
        }

        private static int GetS(int number)
        {
            IsOddNumber(number);
            int count = 0;
            number -= 1;
            while(number != 1)
            {
                number /= 2;
                ++count;
            }
            return count;
        }

        private static bool IsOddNumber(int number)
        {
            IsPositive(number);
            if (number % 2 == 0)
            {
                throw new Exception("Number is even!");
            }
            return true;
        }

        private static bool IsPositive(int number)
        {
            if (number <= 0)
            {
                throw new Exception("Number is not positive!");
            }
            return true;
        }
    }
}
