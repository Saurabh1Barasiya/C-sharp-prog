using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace polymorphism
{
    // Polymorphism is one of the four fundamental principles of object-oriented programming(OOP) in C#.
    // The term "polymorphism" comes from the Greek words "poly" (meaning "many") and "morph" (meaning "form").

    // There are two main types of polymorphism in C#:

    // Compile-time Polymorphism(Static Polymorphism):

        //Achieved through method overloading and operator overloading.
        //The decision of which method to call is made at compile time.

    // Run-time Polymorphism (Dynamic Polymorphism):

        //Achieved through method overriding using inheritance.
        //The decision of which method to call is made at runtime.


    // Method Overloading: 
        // This is when you have multiple methods in the same class with the same name but different signatures(i.e., different parameter lists).
        // The compiler determines which method to call based on the number and types of arguments passed.

    // Operator Overloading:
        // C# allows you to define or redefine the behavior of operators for user-defined data types.
        // For example, you can define how the + operator should behave when applied to instances of a class.


    // Method Overriding:
        // This allows a derived class to provide a specific implementation of a method that is already defined in its base class.
        // The method in the base class must be marked as virtual, and the method in the derived class must use the override keyword.




    public class Example
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
