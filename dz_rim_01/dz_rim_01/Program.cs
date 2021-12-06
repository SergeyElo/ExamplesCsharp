using System;
using System.Linq;

namespace dz_rim_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sr = "";
            int x1 = 0;
            int x2 = 0;
            bool flag_correct = true;
            do
            {
                do
                {
                    Console.Write("Input rim number (0-exit): ");
                    sr = Console.ReadLine();
                    if (sr == "0") 
                        break;
                    flag_correct = (sr.Contains("I")) 
                        || (sr.Contains("V")) 
                        || (sr.Contains("X")) 
                        || (sr.Contains("L"))
                        || (sr.Contains("C")) 
                        || (sr.Contains("D"))
                        || (sr.Contains("M"))
                        || (sr == "0");
                    if (!flag_correct)
                    {
                        Console.WriteLine("Input error! Repeat.");
                    }
                }
                while (!flag_correct);
                sr = sr + "0";
                int rez = 0;
                for (int i = 0; i < sr.Length - 1; i++)
                {
                    x1 = RetDec(sr.Substring(i, 1));
                    x2 = RetDec(sr.Substring(i + 1, 1));
                    if (x1 >= x2)
                    {
                        rez = rez + x1;
                    }
                    else
                    {
                        rez = rez - x1;
                    }
                }
                if ( sr != "00")
                    Console.WriteLine($"Decimal num: {rez}");
            }
            while (sr != "00");
        }
        static int RetDec(string c)
        {
            int x = 0;
            if (c == "I") { x = 1; }
            if (c == "V") { x = 5; }
            if (c == "X") { x = 10; }
            if (c == "L") { x = 50; }
            if (c == "C") { x = 100; }
            if (c == "D") { x = 500; }
            if (c == "M") { x = 1000; }
            if (c == "0") { x = 0; }
            return x;
        }
    }
}
