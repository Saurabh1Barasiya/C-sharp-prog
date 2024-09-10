using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct_class
{
    // An abstract class in C# is a class that cannot be instantiated on its own
    // It serves as a base class from which other classes can derive.
    // Abstract classes can contain both fully implemented methods and abstract methods,
    // which must be implemented by the derived classes.
    // The purpose of an abstract class is to provide a common interface and shared functionality
    // for subclasses while ensuring certain methods are implemented in the derived classes.



    //Key Features of an Abstract Class:
    //    Cannot be instantiated: You cannot create an object of an abstract class. It can only be used as a base class for other classes.
    //    Can have abstract and non-abstract methods: Abstract classes can define methods with implementations and abstract methods(methods without implementations).
    //    Supports inheritance: An abstract class is meant to be inherited by other classes, which then provide implementations for the abstract methods.
    //    Can have fields and properties: Unlike interfaces, an abstract class can have fields(variables), properties, constructors, and other members.
    //    Can have access modifiers: Abstract classes allow you to define access levels(e.g., public, protected, private) for its members, unlike interfaces.


    // To define an abstract class, you use the abstract keyword.You also use the abstract keyword to define any abstract methods inside the class.

    public abstract class Animal
    {
        public abstract void Makesound();

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }


    // A derived class must provide an implementation for all the abstract methods of the base abstract class.
    // If the derived class does not implement these methods, it must also be marked as abstract.

    public class Dog : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();  // // Error: Cannot create an instance of the abstract class.

            Dog dog = new Dog();
            dog.Sleep();
            dog.Makesound();
            Console.ReadLine();
            
        }
    }
}
