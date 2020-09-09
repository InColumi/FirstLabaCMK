using System;
using System.Collections.Generic;

namespace FirstLabaCMK
{
    public static class BinaryPow
    {
        public static int GetNumber(int number, int pow, int mod)
        {
            List<int> numberInBinary = Converter.GetNumberFromDecimalToBinary(pow);
            int result = 1;
            for (int i = 0; i < numberInBinary.Count; i++)
            {
                int result2 = Cripto.GetModulo(result * result, mod);
                result = (numberInBinary[i] == 0) ? result2 : Cripto.GetModulo(result2 * number, mod);
            }
            return result;
        }
    }
}

            