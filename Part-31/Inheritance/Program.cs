using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    // Inheritance is a fundamental concept in object-oriented programming(OOP)
    // that allows a new class to inherit the properties and behaviors(fields and methods) of an existing class.
    // In C#, inheritance provides a way to create a new class (called a derived class or child class) based on an existing class (called a base class or parent class).

    // Base Class(Parent Class):
        // The class whose members are inherited by another class.
        // It provides a common definition of the behavior that can be shared among multiple derived classes.

    // Derived Class(Child Class):
        // The class that inherits from the base class.
        // It can use the members of the base class as well as define its own members.


    // In C#, inheritance is established using a colon (:) between the derived class and the base class.

    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating....");
        }
    }

    // inherirance New class name : Old class Name

    public class Dog : Animal {
        public void Bark()
        {
            Console.WriteLine("Bhow bhow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Eat();
            obj.Bark();
            Console.ReadLine();
        }
    }
}
