using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_2
{
    internal class Car
    {
        protected TypeEnum Type { get; set; }
        public string Color { get; set; }
        protected string Country { get; set; }
        public short Year { get; set; }
        protected bool Sport { get; set; }
    }
    public enum TypeEnum
    {
        Sedan,
        Crossover,
        Jeep,
    }
}
