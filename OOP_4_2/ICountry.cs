using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4_2
{
    internal interface ICountry
    {
        public string Capital { get; set; }
        public string Language { get; set; }
        public string Nationality { get; set; }
        public int Population { get; set; }
        public int Size { get; set; }

        public void PrintFullInfo();    
        public void PrintInfo(string c)
        {
            Console.WriteLine("Aystex larox e linel dzer govazdy..." + c);
        }    
    }
}
