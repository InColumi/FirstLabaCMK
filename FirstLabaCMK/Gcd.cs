namespace FirstLabaCMK
{
    public static class Gcd
    {
        public static int GetGcd(int number, int module)
        {
            int newNumber = number % module;
            return (newNumber < 0) ? newNumber + module : newNumber;
        }
    }
}
