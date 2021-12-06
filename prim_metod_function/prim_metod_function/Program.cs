using System;

namespace prim_metod_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5!={Fakt(5)}");
            Console.WriteLine($"9!={Fakt(9)}");
            Console.ReadKey();
        }
        static long Fakt(int num)
        {
            long p = 1;
            for (int i = 1; i < num; i++)
            {
                p *= i;
            }
            return p;
        }

    }
}
