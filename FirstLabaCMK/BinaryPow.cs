using System;
using System.Collections.Generic;

namespace FirstLabaCMK
{
    public static class BinaryPow
    {
        /// <summary>
        /// Возводит и возвращает число number в степень pow по модулю mod
        /// </summary>
        /// <param name="number">число</param>
        /// <param name="pow">степень</param>
        /// <param name="mod">модуль</param>
        /// <returns></returns>
        public static int GetNumber(int number, int pow, int mod)
        {
            List<int> numberInBinary = Converter.GetNumberFromDecimalToBinary(pow);
            int result = 1;
            for (int i = 0; i < numberInBinary.Count; i++)
            {
                int result2 = MathMethods.GetModulo(result * result, mod);
                result = (numberInBinary[i] == 0) ? result2 : MathMethods.GetModulo(result2 * number, mod);
            }
            return result;
        }
    }
}

            