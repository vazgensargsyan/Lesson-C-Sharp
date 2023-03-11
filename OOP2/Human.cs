using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Human
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public short Age { get; set; }
        public GenderEnum Gender { get; set; }
        private string Test { get; set; }
        public Human()
        {
            
        }
        public Human(short t)
        {
            Age = t;
            Console.WriteLine(Age+"Human");
        }
        public void PublicHelloMen()
        {
            Console.WriteLine("PublicHelloMen");
        }
        internal void InternalByMen()
        {
            Console.WriteLine("InternalByMen");
        }
        protected void ProtectedWhyMen()
        {
            Console.WriteLine("ProtectedWhyMen");
        }
        private void PrivateWhyMen()
        {
            Console.WriteLine("PrivateWhyMen");
        }

    }
    public enum GenderEnum
    {
        Boy,
        Girl,
        Esiminch,
    }
}
