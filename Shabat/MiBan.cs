using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shabat
{
    class MiBan
    {
        public int t;
        public MiBan(int t)
        {
            this.t = t;
        }
        public MiBan()
        {
            Console.WriteLine(Sum(10, 60));
        }
        public MiBan(int a, int b)
        {
            Console.WriteLine("CTOR - " + Sum(a, b));
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
