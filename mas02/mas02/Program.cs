using System;

namespace mas02
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[10] { 34, 12, 55, 3.4, 37, 77, 81, 6, 5, -2};
            foreach (double x in a)
            {
                Console.WriteLine(x);
            }
        }
    }
}
