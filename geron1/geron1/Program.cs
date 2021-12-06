using System;


namespace geron1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"s={s}");
        }
    }
}
