using System;

namespace FirstLabaCMK
{
    public static class BinaryPow
    {
        public static int GetNumber(int numberInDecimal, int pow, int mod)
        {
            string numberInBineire = Converter.GetNumberFromDecimalToBinary(pow);
            int result = 1;
            for (int i = 0; i < numberInBineire.Length; i++)
            {
                byte number;
                if (byte.TryParse(numberInBineire[i].ToString(), out number))
                {
                    if (number == 0)
                    {
                        result = Gcd.GetGcd(result * result, mod);
                    }
                    else
                    {
                        result = Gcd.GetGcd(result * result * numberInDecimal, mod);
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
            