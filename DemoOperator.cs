using System;

namespace DemoOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            var b = 9;
            var d = 7;

            var e = (a + b) * d;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);

            //Console.WriteLine( !(a != b));

            Console.WriteLine(d > b && d > a);
            Console.WriteLine(a > b || d == a);
            Console.WriteLine(a > b && a > d);
        }
    }
}
