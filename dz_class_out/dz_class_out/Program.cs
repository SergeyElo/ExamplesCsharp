using System;

namespace dz_class_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            double c = double.Parse(Console.ReadLine());
            //Triangle x = new Triangle();
            if (Triangle.Geron(a,b,c, out double y))
            {
                Console.WriteLine($"Square = {y}");
            }
            else 
                Console.WriteLine("Input error!");
        }
    }
}
