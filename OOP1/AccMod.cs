using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class AccMod
    {
        int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        private protected int f;

        public void met()
        {
            Console.WriteLine(a);
        }
    }
}
