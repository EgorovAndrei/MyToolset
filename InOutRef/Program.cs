using System;

namespace InOutRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl1 = new Class1();

            //ref
            int i = 1;
            Console.WriteLine("Before " + i);
            cl1.MetRef(ref i);
            Console.WriteLine("After " + i);
            Console.ReadKey();

            //out 
            Class2 cl2;
            cl1.MetOut(out cl2, out var cl2_2);

            //in
            Class2 cl2_in = new Class2();
            cl1.MetIn(cl2_in);
        }
    }
}
