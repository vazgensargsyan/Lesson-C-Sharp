using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{
    internal class GenericClass<T>
    {
        public T Value { get; set; }
        public T IsString(T myString, ref bool isString)
        {
            Value = myString;
            if (myString is string)
            {
                isString = true;
            }
            return Value;
        }
    }
}
