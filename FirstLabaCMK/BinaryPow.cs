using System;

namespace FirstLabaCMK
{
    public static class BinaryPow
    {
        public static int GetNumber(int number, int pow, int mod)
        {
            string numberInBinary = Converter.GetNumberFromDecimalToBinary(pow);
            int result = 1;
            for (int i = 0; i < numberInBinary.Length; i++)
            {
                byte binaryNumber;
                if (byte.TryParse(numberInBinary[i].ToString(), out binaryNumber))
                {
                    if (binaryNumber == 0)
                    {
                        result = Cripto.GetNumberModulo(result * result, mod);
                    }
                    else
                    {
                        result = Cripto.GetNumberModulo(result * result * number, mod);
                    }
                }
                else
                {
                    throw new Exception("TryParse is failed!");
                }
            }
            return result;
        }
    }
}
            