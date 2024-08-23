using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_class
{

    // A sealed class in C# is a class that cannot be inherited.
    // Once you declare a class as sealed, you prevent other classes from deriving from it.
    // This is useful when you want to ensure that the class's implementation remains unchanged or to improve performance by avoiding the overhead associated with inheritance.

    // If you have a class that you don't want anyone to extend, either because it could lead to incorrect behavior or because you want to finalize its implementation, you make it sealed.


    public sealed class Vehicle
    {
        public void SartEngine()
        {
            Console.WriteLine("Engine started.");
        }
    }

    // cannot derive from sealed type
    public class Car : Vehicle {
        public void Drive()
        {
            Console.WriteLine("Driving the car.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
