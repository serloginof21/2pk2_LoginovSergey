using System;
using System.IO;
using System.Collections.Generic;

namespace pz14
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"D:\PZ.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            string str = reader.ReadToEnd();

            List<string> strList = new List<string>();
            strList.AddRange(str.Split("\n"));

            float f = 0f;

            foreach (var item in strList)
            {
                f += float.Parse(item.Split(" ")[1]);
            }
            Console.WriteLine("Сумма чисел " + f);
        }
    }
}
