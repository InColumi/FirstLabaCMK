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
                if (numberInBinary[i] == 0)
                    result = Cripto.GetModulo(result * result, mod);
                else
                    result = Cripto.GetModulo(Cripto.GetModulo(result * result, mod) * number, mod);
            }
            return result;
        }
    }
}

            