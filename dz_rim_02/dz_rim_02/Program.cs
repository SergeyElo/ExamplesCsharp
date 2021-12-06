using System;
using System.Collections.Generic;

namespace dz_rim_02
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Input Rim number: ");
            string s_rim = Console.ReadLine();
            Console.WriteLine($"Decimal number: {RimDec(s_rim)}");
        }
        static int RimDec(string s_rim)
        {   
            int result = 0;
            var RC = new Dictionary<char, short>  {{ 'I', 1 },
                { 'V', 5 },  { 'X', 10 }, { 'L', 50 },
                { 'C', 100 }, { 'D', 500 },  { 'M', 1000 } };
            for (int i = 0; i < s_rim.Length - 1; ++i)
            {  if (RC[s_rim[i]] < RC[s_rim[i + 1]]) 
                    result -= RC[s_rim[i]];
                else if (RC[s_rim[i]] >= RC[s_rim[i + 1]]) 
                    result += RC[s_rim[i]];
            }
            return result += RC[s_rim[^1]]; // s_rim[^1] - последний символ в строке
        }
    }
}
