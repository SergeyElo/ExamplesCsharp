using System;
using System.Linq;

namespace prim_linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид",
                "Манчестер Сити", "ПСЖ", "Барселона" };

            // определяем каждый объект из teams как t
            var selectedTeams = from t in teams
                                where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                                orderby t  // упорядочиваем по возрастанию
                                select t; // выбираем объект

            foreach (string s in selectedTeams)
                Console.WriteLine(s);
        }
    }
}
