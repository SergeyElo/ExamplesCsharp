using System;

namespace geron2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            do
            {
                Console.WriteLine("Enter the sides of the triangle: ");
                Console.WriteLine("a=");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("b=");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("c=");
                c = double.Parse(Console.ReadLine());
                if ((a + b < c) || (a + c < b) || (b + c < a))
                {
                    Console.WriteLine("Input error! Repeat.");
                }
            }
            while ((a + b < c) || (a + c < b) || (b + c < a));
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Area of triangle={s:0.####}");
        }
    }
}
