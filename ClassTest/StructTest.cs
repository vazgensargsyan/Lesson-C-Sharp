using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal struct StructTest
    {
        readonly int myInt;
        public StructTest(int x)
        {
            myInt = x;
        }

        public string test(string x)
        {
            return x + myInt;
        }
    }
}
