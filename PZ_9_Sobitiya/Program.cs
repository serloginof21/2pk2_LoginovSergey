using System;

public delegate void Delegate();

namespace PZ_9_Sobitiya
{
    public class Counter
    {
        public int num;
        public Counter(int x)
        {
            num = x;
        }

        public void Numbers()
        {
            Cutch a = new Cutch();
            for (int i = 1; i < 1001; i++)
            {
                a.ActiveateEvent(i);

                if (i == 800) break;
            }
        }
    }
    public class Cutch
    {
        public event Delegate num_get;
        public void ActiveateEvent(int now)
        {

            if (now == 200)
            {
                num_get = Dvesti;
            }
            else if (now == 800)
            {
                num_get = Vosemsot;
            }
            else num_get = null;
            if (num_get != null) num_get();
        }
        void Dvesti()
        {
            Console.WriteLine("Вот ты и попался друг, 200");
        }
        void Vosemsot()
        {
            Console.WriteLine("Как рулить?! 800");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter b = new Counter(1);
            b.Numbers();
        }
    }
}

