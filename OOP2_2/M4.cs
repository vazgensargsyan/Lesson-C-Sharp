using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_2
{
    internal class M4 : BMW
    {
        public M4()
        {
            Sport = true;
            Type = TypeEnum.Sedan;
        }
        public void printInfo(string color, short year)
        {
            Color = color;
            Year = year;
            Console.WriteLine("BMW M4");
            Console.WriteLine("Country - " + Country);
            Console.WriteLine("Sport - " + Sport);
            Console.WriteLine("Type - " + Type);
            Console.WriteLine("Color - " + Color);
            Console.WriteLine("Year - " + Year);
        }
    }
}
