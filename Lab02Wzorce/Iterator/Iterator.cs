using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02Wzorce.Iterator
{
    public abstract class Iterator
    {
        public abstract object next();
        public abstract bool hasNext();

    }
}
