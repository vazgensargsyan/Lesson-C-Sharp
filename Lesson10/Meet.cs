using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    static partial class Meet
    {
        static int kebabPrice = 800;
        static int shaurmaPrice = 1200;
        static public int Kebab(int count)
        {
            return kebabPrice * count;
        }
        static public int Shaurma(int count)
        {
            return shaurmaPrice * count;
        }
    }
}
