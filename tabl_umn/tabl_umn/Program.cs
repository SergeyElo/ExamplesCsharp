using System;

namespace tabl_umn
{
    class Program
    {
        static void Main(string[] args)
        { int p = 1;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Таблица умножения");
            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    p = x * y;
                    Console.ForegroundColor = ConsoleColor.White;
                    if ((x == 1) | (y == 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }                    
                    Console.Write($"{p}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();  
        }
    }
}
