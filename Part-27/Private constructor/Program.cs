using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_constructor
{
    // A private constructor is a constructor that cannot be accessed from outside the class in which it is declared.
    // This means that you cannot create an instance of the class using the new keyword from any other class or code outside of the class itself.

    // Even we cannot inherid a class from satic consrtuctor class.

    // Purpose: To define a class that cannot be instantiated and is only meant to contain static members.

    public class Example
    {
        private Example(){

        }

        public static void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }



    public class MathHelper
    {
        private MathHelper() { }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void print()
        {
            Console.WriteLine("jab ham kisi class me private constructor bana dete h to maximum time us class me static member hi banate hai.");
        }
    }


    // we cannot inherid class from Example class due to Private constructor.

    //public class Child : Example { 

    //   }

    internal class Program
    {
        static void Main(string[] args)
        {
            // we can not create object of Example class due to Private constructor.
            // Example example = new Example();

            Example.DoSomething();
            MathHelper.print();
            Console.ReadLine();
        }
    }
}
