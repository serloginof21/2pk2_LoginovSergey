using System;

namespace pz5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №1
            Console.WriteLine("Задание №1:");
            int a;
            for (a = 10; a <= 100; a += 5)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            //Зададние №2 
            Console.WriteLine("Задание №2:");
            string letters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; //Русский алфавит для задания №2
            for (int b = 0; b < 6; b++)
            {
                Console.WriteLine(letters[b]);
            }
            Console.WriteLine();

            //Задание №3
            Console.WriteLine("Задание №3:");
            for (int c = 0; c < 7; c++)
            {
                for (int d = 0; d < 6; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Задание №4
            Console.WriteLine("Задание №4:");
            for (int x = 0; x <= 100; x++)
            {
                if (x % 6 == 0)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine();

            //Задание №5
            Console.WriteLine("Задание №5:");
            for (int i = 3, j = 50; (i - j) != 29; i++, j--)
            {
                Console.WriteLine("{0} {1}", i, j);
            }
            Console.WriteLine();
        }
    }
}
