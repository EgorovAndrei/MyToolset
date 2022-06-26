using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Class1
    {
        static Class1()
        {
            Console.WriteLine("Static Constructor of Class1");
        }
        public Class1()
        {
            //something
            Console.WriteLine("Simple Constructor of Class1");
        }
    }
}
