using System;
using System.Collections.Generic;
using System.Text;

namespace InOutRef
{
    class Class1
    {
        public void MetIn(in Class2 t)
        {
            // by ref 
            // t - readonly value
            // t = new Class2(); ERROR
        }
        public void MetOut(out Class2 p1, out Class2 p2)
        {
            //Main reason of usage - return a few values
            //The out parameter 't' must be assigned to before control leaves the current method
            p1 = new Class2();
            p2 = new Class2();
        }
        public void MetRef(ref int i)
        {
            i = 2;
            Console.WriteLine("In method " + i);
        }
    }
}
