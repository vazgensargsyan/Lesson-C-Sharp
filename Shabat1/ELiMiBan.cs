using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Shabat1
{
    static class ELiMiBan
    {
        static int x = 1;
        static ELiMiBan()
        {
            x++;
        }
        public static int Sum(int a, int b)
        {
            return a + b + x;
        }
        public static int Mul(int a, int b)
        {
            return a * b * x;
        }
    }
}
