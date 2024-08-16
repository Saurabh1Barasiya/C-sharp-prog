using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{

    // Multilevel inheritance in C# is a type of inheritance where a class is derived from a base class,
    // and then another class is derived from that derived class, forming a chain of inheritance.
    // This allows the last derived class to inherit properties and methods from both the immediate base class and the original base class.


    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating...");
        }
    }

    public class Dog : Animal
    {
        public void Walk()
        {
            Console.WriteLine("The dog in walking...");
        }
    }


    // multi level inheritance.
    public class Cat : Dog
    {
        public void Running()
        {
            Console.WriteLine("The cat is running...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat obj =  new Cat();
            obj.Running();  
            obj.Walk();
            obj.Eat();

            Console.ReadLine();
        }
    }
}
