using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input name:");
            string s = Console.ReadLine();
            Console.WriteLine($"Hello, {s}!");
            Console.ReadKey();
        }
    }
}
