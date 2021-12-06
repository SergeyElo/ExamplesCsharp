using System;
using System.Text;

namespace dz_kres_nol_10
{
    class Program
    {
        private static KrestNolGame x = new KrestNolGame();
        static void Main(string[] args)
        {
            Console.WriteLine(GetPrintableState());
            while (x.GetWinner() == Winner.GameIsUnfinised)
            {
                int index = int.Parse(Console.ReadLine());
                x.MakeMove(index);
                Console.WriteLine();
                Console.WriteLine(GetPrintableState());
            }
            Console.WriteLine($"Result: {x.GetWinner()}");
            Console.ReadLine();
        }
        static string GetPrintableState()
        {
            var st = new StringBuilder();
            for (int i = 1; i <= 7; i += 3)
            {
                st.AppendLine("   |   |   |")
                    .AppendLine($" {GetPrintableChar(i)} | {GetPrintableChar(i + 1)} | {GetPrintableChar(i + 2)} |")
                    .AppendLine("___|___|___|");


            }
            return st.ToString();
        }
        static string GetPrintableChar(int index)
        {
            State state = x.GetState(index);
            if (state == State.Unset)
            {
                return index.ToString();
            }
            return state == State.Cross ? "X" : "O";
        }
    }
}
