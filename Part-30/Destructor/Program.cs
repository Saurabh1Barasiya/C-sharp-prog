using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{

    // In C#, a destructor is a special method used to clean up resources before an object is removed from memory.
    // Destructors are useful in scenarios where you need to perform clean-up operations
    // such as releasing unmanaged resources (e.g., file handles, database connections) that the garbage collector (GC) might not handle automatically.

    // A destructor is a method that is called automatically when an object is about to be destroyed or garbage collected.
    // It has the same name as the class, prefixed with a tilde ~.

    // A destructor cannot have parameters or a return type.

    // A class can have only one destructor, and it cannot be inherited or overloaded.

    public class Example
    {
        private double productnumber;
        private string productName;

        public Example(double number, string name) {
            this.productnumber = number;
            this.productName = name;
        }

        public void showData()
        {
            Console.WriteLine($"Product Number {productnumber}");
            Console.WriteLine($"Product Name {productName}");
        }

        // Creating Destructor.
        ~Example()
        {
            Console.WriteLine("Hey friend I am Destructor...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
              Example obj = new Example(123246.21,"Phone");

              obj.showData();
              //Console.ReadLine();

              // Press control + f5 to show  proper output.
        }
    }
}
