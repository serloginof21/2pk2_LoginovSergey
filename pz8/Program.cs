using System;

namespace pz8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[12];
            Random rnd = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(20, 100);
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            int[] B = new int[10];

            int iter_B = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 10 == 0)
                {
                    B[iter_B] = A[i];
                    iter_B++;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(B[i] + " ");
            }
        }
    }
}
