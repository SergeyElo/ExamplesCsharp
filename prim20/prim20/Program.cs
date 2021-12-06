using System;
using System.Collections.Generic;

namespace prim20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 56, 78, 22 };
            Console.WriteLine("Original List:");
            foreach (int x in num)
            {
                Console.WriteLine(x);
            }
            num.Add(14);
            num.Add(99);
            num.AddRange(new int [] { 33, 44, 66});
            num.RemoveAt(1);
            Console.WriteLine("List after operations:");
            foreach (int x in num)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("kol=" + num.Count.ToString());
            num.Sort();
            Console.WriteLine("Sort:");
            foreach (int x in num)
            {
                Console.WriteLine(x);
            }
        }
    }
}
