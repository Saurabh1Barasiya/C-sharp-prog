using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_hiding
{

    // Method hiding in C# occurs when a method in a derived class has the same name as a method in its base class,
    // but it is not an override of the base class method. Instead, it hides the base class method.
    // To indicate that you're hiding a method intentionally, you use the new keyword.

    public class Animal
    {
        public void makeSound()
        {
            Console.WriteLine("The Animal makes a sound:  ");
        }
    }


    // inheritance but yaha hamne overrriding nahi kiya h.
    public class Dog : Animal
    {
        // Method hiding the base class method.
        public new void makeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.makeSound();             // The dog barks.



            // yaha reference variable Animal class ka h and object Dog class ka h.
            // ...But reference variable parent class ka h to parent class wali method call hogi.

            Animal animal = new Dog();
            animal.makeSound();   // The Animal makes a sound.



            // ab object hi hamne parent class ka banayah to parent class ka method call hogi.
            Animal animalparent = new Animal();
            animalparent.makeSound();


            Console.ReadLine();
        }
    }
}
