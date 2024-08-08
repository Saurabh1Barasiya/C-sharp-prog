using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // A static constructor in C# is a special type of constructor that is used to initialize static members of a class.
    // or to perform any action that needs to be performed only once,such as setting up static data.
    // Static constructors are called automatically before the first instance of a class is created or any static members are accessed.

    // A static constructor cannot take parameters.
    // It does not have any access modifiers like public, private, etc.,
    // It is called only once for the entire class, not per instance.
    // The static constructor is executed before any static member of the class is accessed or before the first instance of the class is created.

    public class Example
    {
        public static string name;
        
        static Example()
        {
            name = "Saurabh";
            Console.WriteLine("I am called");
            Console.WriteLine($"Static variable {name}");
        }

    }


    public class Test
    {
        public static int x;

        static Test() {
            x = 42;
            Console.WriteLine("I am static constructor...");
        }

        public Test() {
            Console.WriteLine("I am normal constructor...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // me jese hi static member ko access karunga to usse pahle statc constructor chal jayega.
            Console.WriteLine(Test.x); // 42

            Test t1 = new Test();

            // creating Example class object.
            // The static constructor is executed before any static member of the class is accessed or before the first instance of the class is created.
            Example example = new Example();
            
            Console.ReadLine();
        }
    }
}
