using System;
using System.Collections;
using System.IO;

namespace prim10
{
    class Program
    {
        static void Main(string[] args)
        { ArrayList vopr = new ArrayList();
            vopr.Add("Как обозначается равно");
            vopr.Add("Назовите столицу Австралии");
            vopr.Add("Наиболее распространённая среда разработки для С#");
            foreach (object a in vopr) {
                Console.WriteLine($"{a}");
            }

            using (TextWriter tw = File.CreateText("test1.txt"))
            {
                try
                {
                    foreach (object s in vopr)
                    {
                        tw.WriteLine(s.ToString());
                    }
                    tw.Flush();
                }
                catch (Exception ex) {
                    Console.WriteLine("Error saving file!");
                }

            }

        }
    }
}
