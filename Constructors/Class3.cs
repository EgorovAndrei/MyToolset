using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Class3 : Class2
    {
        static Class3()
        {
            Console.WriteLine("Static Constructor of Class3");
        }

        public Class3()
        {
            Console.WriteLine("Simple Constructor of Class3");
        }
    }
}
