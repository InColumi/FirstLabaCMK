using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FirstLabaCMK
{
    public static class MillerRabin
    {
        private static Random _rand = new Random();
        
        public static void ShowHowInTask(int number, int countOftries, int x)
        {
            int s = GetS(number);
            int t = number - 1;

            int randNumber;
            for (int i = 0; i < countOftries; i++)
            {
                randNumber = x;
                int y = BinaryPow.GetNumber(randNumber, t, number);

                if (y == 1 || y == number - 1)
                    continue;
                Console.WriteLine($"x = {x}");
                for (int j = 1; j < s; j++)
                {
                    Console.WriteLine($"\ty{j} = {y}");
                    y = Cripto.GetModulo(y * y, number);

                    if (y == 1)
                        Console.WriteLine($"{number} is  not prime!");

                    if (y == number - 1)
                        break;
                }

                if (y != number - 1)
                    Console.WriteLine($"{number} is  not prime!");
            }
            Console.WriteLine($"{number} is prime!");
        }

        public static bool IsPrimeNumber(int number, int countOftries)
        {
            int s = GetS(number);
            int t = number - 1;

            int randNumber;
            for (int i = 0; i < countOftries; i++)
            {
                randNumber = _rand.Next(1, number);
                int y = BinaryPow.GetNumber(randNumber, t, number);

                if (y == 1 || y == number - 1)
                    continue;

                for (int j = 1; j < s; j++)
                {
                    y = Cripto.GetModulo(y * y, number);

                    if (y == 1)
                        return false;

                    if (y == number - 1)
                        break;
                }

                if (y != number - 1)
                    return false;
            }

            return true;
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
