using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            while(a!=b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }
    }
}
