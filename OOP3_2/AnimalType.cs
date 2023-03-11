using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_2
{
    internal class AnimalType : AnimalSwitch
    {
        public override void Voice(Animals animal)
        {
            switch (animal)
            {
                case Animals.Dog:
                    Console.WriteLine("Haf haf");
                    break;
                case Animals.Cat:
                    Console.WriteLine("Myau myau");
                    break;
                case Animals.Lion:
                    Console.WriteLine("Lion lion");
                    break;
                default:
                    base.Voice(animal);
                    break;
            }
        }

        public override void Speed(int speed)
        {
            base.Speed(speed);
        }
    }
}
