using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLabaCMK
{
    public static class Converter
    {
        public static string GetNumberFromDecimalToBinary(long numberInDecima)
        {
            IsCorrectNumber(numberInDecima);
            StringBuilder stringBuilder = new StringBuilder();
            List<byte> list = new List<byte>();
            long numberIn10 = numberInDecima;

            while (numberIn10 >= 1)
            {
                list.Add((byte)(numberIn10 % 2));
                numberIn10 /= 2;
            }
            list.Reverse();

            foreach (var item in list)
            {
                stringBuilder.Append(item);
            }

            return stringBuilder.ToString();
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
