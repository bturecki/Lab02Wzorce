using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02Wzorce.Strategia
{
    internal class ConcreteStrategy : IStrategy
    {
        public void execute()
        {
            Console.WriteLine("Executed");
        }
    }
}
