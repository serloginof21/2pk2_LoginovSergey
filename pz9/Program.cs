using System;

namespace pz9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 6; //создание констант
            const int b = 7;
            double[,] A = new double[a, b]; //создание массива
            double count = 0; //создание результата
            Console.WriteLine("Массив А:");
            Random rnd = new Random(); //рандом
            for(int i = 0; i < a; i++) //столбцы
            {
                for(int j = 0; j < b; j++) //строки
                {
                    A[i, j] = rnd.Next(1, 9) / 10.0; //вывод рандомных чисел
                    Console.Write($"{A[i,j]}  "); //вывод массива
                }
                Console.WriteLine();
            }
            for(int i = 0; i < a; i++) //подсчет суммы 4-го столбца
            {
                count += A[i, 3];
            }
            Console.WriteLine("Сумма чисел 4-го столбца: " + count); //результат
        }
    }
}
