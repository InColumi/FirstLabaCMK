using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLabaCMK
{
    public static class Converter
    {
        public static List<int> GetNumberFromDecimalToBinary(int numberInDecima)
        {
            IsCorrectNumber(numberInDecima);
            List<int> numberInBinary = new List<int>();

            while (numberInDecima >= 1)
            {
                numberInBinary.Add(numberInDecima % 2);
                numberInDecima /= 2;
            }
            numberInBinary.Reverse();
            return numberInBinary;
        }

        private static bool IsCorrectNumber(long number)
        {
            if (number < 0)
            {
                throw new Exception("Number cannot be negative!");
            }
            return true;
        }
    }
}
