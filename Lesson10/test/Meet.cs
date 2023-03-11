using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    static partial class Meet
    {
        static int bbqPrice = 2200;
        static public int BBQ(int count)
        {
            return bbqPrice * count;
        }
    }
}
