namespace FirstLabaCMK
{
    public static class Cripto
    {
        public static int GetNumberModulo(int number, int module)
        {
            int newNumber = number % module;
            return (newNumber < 0) ? newNumber + module : newNumber;
        }

		public static int GetGcd(int a, int b)
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

		public static int GetReversNumber(int a, int n)
		{
			int x;
			int y;
			FindReversNumber(a, n, out x, out y);
			return x;
		}

		private static int FindReversNumber(int a, int n, out int x, out int y)
		{
			if (a == 0)
			{
				x = 0;
				y = 1;
				return n;
			}
			int x1 = 0;
			int y1 = 0;
			int d;
			d = FindReversNumber(n % a, a, out x1, out y1);
			x = y1 - (n / a) * x1;
			y = x1;
			return d;
		}
	}
}
