using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_in_inhritance
{
    // Method overriding in C# allows a subclass (or derived class) to provide a specific implementation of a method
    // that is already defined in its superclass (or base class). This enables a derived class
    // to modify or extend the behavior of a method that is inherited from the base class.

    // Base Class and Derived Class:

    // Base Class:
        // The class whose method is being overridden.
    //Derived Class:
        //The class that overrides the method from the base class.

    // Virtual Method:
        // A method in the base class that you want to allow derived classes to override must be marked as virtual.

    // Override Method:
        // The method in the derived class that overrides the base class method must be marked as override.

    public class Animal
    {
        // virtual method in base class.

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    public class Dog : Animal {

        // Overriding the base class method
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    public class Dog2 : Animal {

        // override keyword is must.
        public override void MakeSound()
        {

            // calling base class method.
            base.MakeSound();

            Console.WriteLine("The dog 2 barks....");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();

            Dog2 dog2 = new Dog2();
            dog2.MakeSound();

            Console.ReadLine();
        }


     // Virtual and Override Keywords:

        //The method in the base class must be marked with the virtual keyword.
        //The method in the derived class must be marked with the override keyword.

     // Method Signature:

        // The overridden method in the derived class must have the same name, return type, and parameters as the method in the base class.

     // Access Modifiers:

        // The access level(like public, protected, etc.) of the overriding method must be the same or less restrictive than the method being overridden.

     // Calling the Base Method:

          // Inside the overridden method, you can still call the base class's version of the method using base.MethodName().
   
     //Polymorphism:

          // Method overriding is a key feature of polymorphism in C#. It allows objects to be treated as instances of their base class,
          // but when methods are called, the derived class's method is executed.
    }
}
