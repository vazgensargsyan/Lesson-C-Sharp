using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_2
{
    internal class AnimalSwitch
    {
        public virtual void Voice(Animals animal)
        {
            Console.WriteLine("Auuuuuuu...");
        }
        public virtual void Speed(int speed)
        {
            Console.WriteLine("Speed..." + speed);
        }
    }
}
