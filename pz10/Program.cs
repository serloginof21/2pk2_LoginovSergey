using System;
using System.Linq;

namespace pz10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1 and 2");
            float[][] a = new float[3][];
            float[] Lastb = new float[3];
            float[] Maxb = new float[3];
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                a[i] = new float[random.Next(10, 30)];
                for(int j = 0; j < a[i].Length; j ++)
                {
                    a[i][j] = random.Next(50) + (float)random.NextDouble();
                }
            }
            foreach(float[] item in a)
            {
                foreach(float i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Number 3");
            for (int i = 0; i < 3; i++)
            {
                Lastb[i] = a[i][a[i].Length - 1];
            }

            foreach (var i in Lastb)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Number 4");
            for (int i = 0; i < 3; i++)
            {
                Maxb[i] = a[i].Max();
            }

            foreach (var i in Maxb)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
