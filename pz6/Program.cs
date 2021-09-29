using System;

namespace pz6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант №15:");
            int a = Convert.ToInt32(Console.ReadLine()); //конвертирование из строки в число
            double b; //результат
            b = 0f;
            int k;
            k = 1;
            while(k < a + 1)
            {
                b += 1f / k;
                k++;
            }
            Console.WriteLine(b);

        }
    }
}
