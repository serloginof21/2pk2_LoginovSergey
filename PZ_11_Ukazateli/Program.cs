using System;

namespace PZ_11_Ukazateli
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string a = new string (Console.ReadLine());
            string[] b = a.Split(' ');
            foreach(string i in b)
            {
                if(i == ".")
                {
                    Console.WriteLine("camz");
                }
            }
        }
    }
}