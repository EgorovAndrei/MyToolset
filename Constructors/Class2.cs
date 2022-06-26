using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Class2:Class1
    {
        static Class2()
        {
            Console.WriteLine("Static Constructor of Class2");
        }
        public Class2()
        {
            //something
            Console.WriteLine("Simple Constructor of Class2");
        }
    }
}
