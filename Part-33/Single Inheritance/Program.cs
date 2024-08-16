using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    // Single inheritance in C# is the most basic form of inheritance where a derived class inherits from only one base class.
    // This means that the derived class can access and use the methods and properties defined in the base class, as well as add its own unique members.

    public class Parent
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class child:Parent {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            child obj = new child();
            obj.Bark();
            obj.Eat();
            Console.ReadLine();
            //Console.WriteLine();
        }
    }
}
