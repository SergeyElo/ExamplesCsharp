using System;

namespace pp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=10, y=12, z=13;
            Addition(ref x, ref y, ref z); // вызов метода
            Console.WriteLine(x);   
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadLine();
        }
        // параметр x передается по ссылке
        static void Addition(ref double x, ref double y, ref double z)
        {
            x += y;
            y = 5;
            z += x;
        }
    }
    
}
