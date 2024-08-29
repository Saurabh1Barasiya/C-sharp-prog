using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    // A delegate in C# is a type that represents references to methods with a specific parameter list and return type.
    // It's similar to a function pointer in C++, but it's object-oriented and type-safe.
    // Delegates are used to pass methods as arguments to other methods, making them essential for defining callback methods.
    // implementing event handlers, and enabling the design of extensible and flexible applications.


    // Key Points about Delegates:
    // Type Safety: Delegates are type-safe, meaning the method signature(return type and parameters) must match the delegate's signature.
    // Multicast: A single delegate can hold references to multiple methods. When invoked, all methods are called in sequence.
    // Asynchronous Execution: Delegates can be used to call methods asynchronously.


    // To declare a delegate, you specify the return type and parameters that the delegate will encapsulate.
    //                  public delegate int MyDelegate(int x, int y);
    // This declaration defines a delegate named MyDelegate that can reference any method that takes two integers and returns an integer.






    internal class Program
    {

        public delegate void PrintMessage(string message);

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }


        public static void ShowMessage(string message)
        {
            Console.WriteLine("ShowMessage: " + message);
        }


        static void Main(string[] args)
        {
            PrintMessage printer = DisplayMessage;
            printer("This is a Basic delegate example");

            printer += ShowMessage;
            printer("Hello, multicast delegate!");

            Console.ReadLine(); 
        }
    }
}