using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // A static class in C# is a class that cannot be instantiated, meaning you cannot create an object of it.
    // Instead, you access its members (methods, fields, properties, etc.) directly through the class itself. 

    // A static class is declared using the static keyword.

    // No Inheritance: Static classes cannot inherit from other classes or be inherited.

    // No Interfaces: A static class cannot implement interfaces.

    // static class contain only static members.


    static class Example
    {
        public static int Num;
        public static string Name;

        static Example() {
            Num = 100;
            Name = "Hello Saurabh";
            Console.WriteLine("Static constructor Called...");
        }

        public static void ShowData() {
            Console.WriteLine(Num);
            Console.WriteLine(Name);
        }


        // cannot declare instance members in static class.
        // public void display() { }
    }

    // Static classes cannot inherit from other classes or be inherited.
    
    // Dont uncomment.
    // public class Test : Example { }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example.ShowData();
            Console.ReadLine();
        }
    }
}
