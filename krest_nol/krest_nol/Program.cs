using System;
using System.Collections.Generic;

namespace krest_nol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> igrok = new List<string>() { "крестики", "нолики" };
            int num = 0;
            int n = 0;
            int[] p = { 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            Print(p);
            do
            {
                Console.Write($"Ходят {igrok[num]} (0..8 9-выход): ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 9)
                {
                    if (p[n] != 2)
                    {
                        Console.WriteLine($"Поле {n} занято! Сделайте другой ход.");
                        continue;
                    }
                    num = 1 - num;
                    p[n] = num;
                    Print(p);
                    if (Prov(p, num) == -1)
                    {
                        Console.WriteLine("Поле заполнено. Ходов нет. Ничья.");
                        break;
                    }
                    if (Prov(p, num) == num)
                    {
                        Console.WriteLine($"Выиграли {igrok[1 - num]}. Игра окончена.");
                        break;
                    }
                }
            }
            while (n != 9);
        }
        static void Print(int[] p)
        {
            string c = "OX.";
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{c[p[i]]}\t");
                if ((i + 1) % 3 == 0) { Console.WriteLine(); }
            }
        }
        static int Prov(int[] p, int w)
        {
            int rez = - 1;
            if (((p[0] == w) && (p[1] == w) && (p[2] == w)) |
                ((p[3] == w) && (p[4] == w) && (p[5] == w)) |
                ((p[6] == w) && (p[7] == w) && (p[8] == w)) |
                ((p[0] == w) && (p[3] == w) && (p[6] == w)) |
                ((p[1] == w) && (p[4] == w) && (p[7] == w)) |
                ((p[2] == w) && (p[5] == w) && (p[8] == w)) |
                ((p[0] == w) && (p[4] == w) && (p[8] == w)) |
                ((p[2] == w) && (p[4] == w) && (p[6] == w)))
            {
                rez = w; 
                return rez;
            }
            for (int i = 0; i < 9; i++)
            {
                if (p[i] == 2) { rez = 2; }
            }
            return rez;
        }
    }
}
