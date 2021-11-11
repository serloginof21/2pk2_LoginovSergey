using System;

namespace pz12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string[] array = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            str = string.Join(" ", array);
            array = str.Split(". ");
            for(int i = 0; i < array.Length; i++)
            {
                string ch = array[i][0].ToString().ToUpper();
                array[i] = ch + array[i].Remove(0, 1);
            }
            str = string.Join(". ", array);
            Console.WriteLine(str);
        }
    }
}
