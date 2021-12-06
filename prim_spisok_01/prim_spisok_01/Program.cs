using System;
using System.Collections;

namespace prim_spisok_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(10);
            a.Add(4);

            Console.WriteLine("1 spisok:");
            foreach (object x in a)
            {
                Console.WriteLine($"{x} ", x);
            }
            a.Add(-234);
            for (int i = 2; i < 21; i = i + 2)
            {
                a.Add(i);
            }

            a.Sort();
            Console.WriteLine();
            Console.WriteLine("2 spisok:");
            foreach (object x in a)
            {
                Console.WriteLine($"{x} ", x);
            }
        }
    }
}
