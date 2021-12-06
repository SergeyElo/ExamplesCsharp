using System;

namespace OOP_наследование_01
{
    class Program
    {
        static void Main(string[] args)
        {
            BankTerminal x = new BankTerminal("12345");
            x.Connect();
            BankTerminal t = new ModelXTerminal("12");
            t.Connect();
            BankTerminal w = new ModelYTerminal("34");
            w.Connect();


        }
    }
}
