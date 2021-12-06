using System;
using System.Collections.Generic;

namespace pp30
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new List<string>();
            t.Add("first");
            t.Add("second");

            foreach (string s in t)
            {
                Console.WriteLine(s);
            }

            string ss = "first";
            bool f = t.Contains(ss);
            Console.WriteLine($"1={f}");

            f = t.Contains("First");
            Console.WriteLine($"2={f}");
            
            ss = ss.ToUpper();
            f = t.Contains(ss);
            Console.WriteLine($"3={f}");
        }
    }
}
