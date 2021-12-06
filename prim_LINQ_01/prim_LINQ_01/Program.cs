using System;
using System.Linq;

namespace prim_LINQ_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 23, 67, 88, 15, 2, 88, 2, 6, 7, 13, 82, 7, 15 };
            Console.WriteLine("Original:");
            foreach (int t in numbers)
            {
                Console.WriteLine(t.ToString());
            }

            Console.WriteLine("Distinct:");
            var num = numbers.Distinct();
            foreach (int t in num)
            {
                Console.WriteLine(t.ToString());
            }

            var numb2 = from n in numbers
                    where n%2 == 0
                    select n;
            Console.WriteLine("Del na 2:");
            foreach (int t in numb2)
            {
                Console.WriteLine(t.ToString());
            }
            int m = numb2.Max();
            Console.WriteLine(m.ToString());
            
        }
    }
}
