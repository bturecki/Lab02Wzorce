using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02Wzorce.Iterator
{
    internal abstract class Iterator
    {
        public abstract bool hasNext();
        public abstract object next();
    }
}
