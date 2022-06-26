using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SomeExtensibleClass sec = new SomeExtensibleClass();
            sec.ExtMet(1);
        }
    }
}
