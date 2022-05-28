using System;

namespace random_num
{
    public static class Class1
    {
        public static int Mega_random(int a, int b)
        {
            Random rnd = new Random();
            int c = rnd.Next(a, b);
            return c;
        }
    }
}