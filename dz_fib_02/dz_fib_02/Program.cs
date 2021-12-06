using System;

namespace dz_fib_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько чисел вывести?");
            int k = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < k; i++)
            {
                Console.WriteLine(Fib(i));
            }
        }
        static int Fib(int n)
        {
            if (n < 2) { return 1; }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
