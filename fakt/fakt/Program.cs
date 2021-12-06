using System;

namespace fakt
{
    class Program
    {
        static void Main(string[] args)
        { int num = 0;
            do
            {
                Console.Write("Input number (1..20):");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while ((num < 1) || (num > 20));
            long p = 1;
            for (int i = 1; i <= num; i++) {
                p *= i;
                Console.WriteLine($"{i}!={p}");
            }
            Console.ReadKey();
        }
    }
}
