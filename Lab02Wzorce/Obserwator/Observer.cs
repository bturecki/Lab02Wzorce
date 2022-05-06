using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02Wzorce.Obserwator
{
    internal abstract class Observer
    {
        public abstract byte[] state { get; set; }
        public abstract void update(byte[] data);
    }
}
