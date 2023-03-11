using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Milk
    {
        private int tvarogPrice = 700;
        protected const int price = 500;
        readonly int matsoonPrice;

        public Milk(int x)
        {
            matsoonPrice = x;
        }
        public double MakeSmetan(double count)
        {
            return count * price;
        }
        public double MakeMatsoon(double count)
        {
            return count * matsoonPrice;
        }
        public double MakeTvarog(double count)
        {
            return count * tvarogPrice;
        }
    }
}
