using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_наследование_01
{
    public class BankTerminal
    {
        protected string id;
        public BankTerminal(string id)
        {
            this.id = id;
        }
        public virtual void Connect()
        {
            Console.WriteLine($"General connecting protocol...id={id}");
        }
    }
    public class ModelXTerminal: BankTerminal
    {
        public ModelXTerminal(string id) : base(id)
        {
        }
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine("TerminalX connceting.");
        }
    }
    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id)
        {
        }
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine("TerminalY connceting.");
        }
    }
}
