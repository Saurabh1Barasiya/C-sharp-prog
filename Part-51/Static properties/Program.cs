using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Static_properties
{
    public class Example
    {
        public static int count { get; private set; } = 0;
        public Example()
        {
            count++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // we cannot set value because set accessor is private.
            // Example.count = 10;

            Console.WriteLine($"first value when we want to access {Example.count}");

            Example obj1 = new Example();
            Example obj2 = new Example();
            Example obj3 = new Example();
            Example obj4 = new Example();


            Console.WriteLine($"Final value of static variable : {Example.count}");

            Console.ReadLine();

        }
    }
}
