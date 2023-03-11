using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Factorial
    {
        public int fac(int myInt)
        {
            if (myInt == 1)
            {
                return 1;
            }
            return myInt * fac(myInt-1);
        }

        public decimal? mult(decimal? myDecimal1, decimal? myDecimal2, decimal? myDecimal3, decimal? myDecimal4)
        {
            return myDecimal1 * myDecimal2 * myDecimal3 * myDecimal4;
        }
    }
}
