using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02Wzorce.Obserwator
{
    internal class ConcreteObserver : Observer
    {
        public override byte[] state { get; set; }

        public override void update(byte[] data)
        {
        }
    }
}
