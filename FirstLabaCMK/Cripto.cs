namespace FirstLabaCMK
{
    public static class Cripto
    {
        public static int GetNumberModulo(int number, int module)
        {
            int newNumber = number % module;
            return (newNumber < 0) ? newNumber + module : newNumber;
        }

		public static int Gcd(int a, int b)
		{
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
		}
	}
}
